using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Obsługa_biurowca
{
    class DB_Access
    {
        SqlConnection conn;
        public DB_Access()
        {
            conn = DB_Connection.polacz();
        }


    /**
     * Wszystkie metody typu String zwracają komunikat dla użytkownika o pomyślności działania.
     * Metody typu DataTable pobierają dane z bazy wspomagające wprowadzanie nowych danych przez użytkownika.
     */


        /**
         * Metoda dodaje firmę z parametrami podanymi przez użytkownika, sprawdza czy piętro jest poprawnie zapisane
         */
        public String dodaj_firme(string nazwa, string pietro) { 
            if (conn.State.ToString()=="Closed"){
                conn.Open();
            }
            int pietroInt;
            try
            {
                pietroInt = Convert.ToInt32(pietro);
            }
            catch (FormatException f) {
                return "Nieprawidłowa wartość w polu \"Piętro\"";
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "exec dodaj_firme \'" + nazwa + "\', " + pietroInt;
        try
            {
                if (newCmd.ExecuteNonQuery() > 0)
                {
                    return "Firma dodana pomyślnie!";
                }
                else
                    return "Firma jest już w bazie!";
            }
            catch (SqlException e)
            {
                return "Wystąpił błąd: " + e.Message;
            }
        
        }


        /**
         * Metoda pobierająca informację o dostępnych piętrach, używana w formularzu dodawania nowej Firmy i dodawania nowego pomieszczenia do bazy
         */
        public DataTable PietroFirmy() {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pietro", typeof(String));

            if (conn.State.ToString() == "Closed") {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pietra";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                tbl.Rows.Add(dr["numer"]);
            }

            conn.Close();
            return tbl;
        }

        /**
         * Metoda usuwająca firmę o podanej przez użytkownika nazwie
         */
        public String usun_firme(string nazwa) {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }


            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from Firmy where nazwa=\'" + nazwa + "\'";
            try
            {
                if (newCmd.ExecuteNonQuery() > 0)
                {
                    return "Firma usunięta z bazy danych!";
                }
                else return "Firma nie istniała w bazie danych!";
            }
            catch (SqlException e) {
                return "Wystąpił błąd";
            }
            
            }

        /**
         * Metoda pobierająca listę firm znajdujących się w bazie, używana do formularza usuwania firmy oraz dodawania nowego pracownika
         */
        public DataTable ListaFirm() {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("firma", typeof(String));
            
            if (conn.State.ToString() == "Closed") {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Firmy";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read()) {
                tbl.Rows.Add(dr["nazwa"]);
            }
            conn.Close();
            return tbl;
        
        }

        /**
         * Metoda dodająca odwiedzającego do bazy danych.
         */
        public String dodaj_goscia(string imie, string nazwisko, string dzien, string miesiac,
            string rok, string godz_wej, string min_wej, string godz_wyj, string min_wyj,
            string imie_odw, string nazwisko_odw)
        {
            string data = dzien + "-" + miesiac + "-" + rok;
            string godzina_Wejscia = godz_wej + ":" + min_wej;
            string godzina_Wyjscia = godz_wyj + ":" + min_wyj;

            if (CzyOsobaIstnieje(nazwisko_odw, imie_odw))
            {

                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;
                newCmd.CommandText = "exec dodaj_goscia \'" + nazwisko + "\', \'" + imie + "\', \'" +
                    data + "\', \'" + godzina_Wejscia + "\', \'" + godzina_Wyjscia + "\', \'" +
                    imie_odw + "\', \'" + nazwisko_odw + "\'";
                try
                {
                    if (newCmd.ExecuteNonQuery() > 0)
                    {
                        return "Gość dodany pomyślnie!";
                    }
                    else
                        return "Wystąpił błąd!";
                }
                catch (SqlException e)
                {
                    return "Wystąpił błąd";
                }
            }
            else return "Osoba podana jako odwiedzana nie istnieje w bazie danych!";
        }

        /**
         * Metoda dodająca nowego pracownika do bazy danych, sprawdza poprawność formatu podanych przez użytkownika danych.
         */
        public String dodaj_pracownika(string nazwisko, string imie, string stanowisko, string firma,
            string pokoj, string telefon, string email)
        {

            int pokojInt;
            int telefonInt;

            try
            {
                pokojInt = int.Parse(pokoj);
                telefonInt = int.Parse(telefon);
            }
            catch (FormatException f)
            {
                return "Nieprawidłowa wartość w polu \"Piętro\" lub \"Telefon\"";
            }
            catch (OverflowException o) {
                return "Nieprawidłowa wartość w polu \"Piętro\" lub \"Telefon\"";
            }

            if (!CzyFirmaIstnieje(firma)) return "Podana firma nie istnieje!";
            if (!CzyPokojNalezy(firma, pokojInt)) return "Pokój nie należy do firmy!";

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "exec dodaj_pracownika \'" + nazwisko + "\', \'" + imie + "\', \'" +
                firma + "\', \'" + stanowisko + "\', " + pokojInt + ", " + telefonInt + ", \'" +
                email + "\'";
            
            try
            {
                if (newCmd.ExecuteNonQuery() > 0)
                {
                    return "Pracownik dodany pomyślnie!";
                }
                else
                    return "Pracownik jest już w bazie!";
            }
            catch (SqlException e) {

                return "Wystąpił błąd";
            }

        }

        /**
         * Edytuje dane konkretnego pracownika konkretnej firmy.
         */
        public String edytuj_pracownika(String nazw_edyt, String imie_edyt, String firma_edyt, String nazwisko,
            String imie, String firma, String stanowisko, String pokoj, String telefon, String mail) {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                int pokojInt;
                int telefonInt;

                try
                {
                    pokojInt = int.Parse(pokoj);
                    telefonInt = int.Parse(telefon);
                }
                catch (FormatException f)
                {
                    return "Nieprawidłowa wartość w polu \"Piętro\" lub \"Telefon\"";
                }
                catch (OverflowException o) {
                    return "Nieprawidłowa wartość w polu \"Piętro\" lub \"Telefon\"";
                }

                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;
                newCmd.CommandText = "update Pracownicy_firm set nazwisko = \'" + nazwisko + "\', imie = \'" + imie +
                    "\', stanowisko = \'" + stanowisko + "\', firma = (select id from Firmy where nazwa = \'" + firma + "\'), pokoj = \'" + pokojInt +
                    "\', telefon = \'" + telefonInt + "\', email = \'" + mail + "\' where nazwisko = \'" + nazw_edyt +
                    "\' and imie = \'" + imie_edyt + "\' and firma = (select id from Firmy where nazwa = \'" + firma_edyt + "\')";

                try
                {
                    if (newCmd.ExecuteNonQuery() > 0)
                    {
                        return "Dane zmienione pomyślnie!";
                    }
                    else
                        return "Wystąpił błąd!";
                }
                catch (SqlException e)
                {

                    return "Wystąpił błąd: " + e.Message;
                }
        
        }


        /**
         * Metoda pobierające dane o pokojach znajdujących się na piętrze zajmowanym przez konkretną firmę. Używana przy dodawaniu nowego pracownika.
         */
        public DataTable PokojeFirmy(String firma) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pokoj");

            if (conn.State.ToString() == "Closed") {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pokoje where pietro = (select pietro from Firmy where nazwa=\'" + firma + "\')";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                tbl.Rows.Add(dr["numer"]);
            }

            conn.Close();
            return tbl;

        }


        /**
         * Metoda usuwa pracownika z bazy danych, o ile w niej istnieje.
         */
        public String usun_pracownika(string imie, string nazwisko)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }


            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from Pracownicy_firm where nazwisko=\'" + nazwisko + 
                "\' and imie=\'" + imie + "\'";

            try
            {
                if (newCmd.ExecuteNonQuery() > 0)
                {
                    return "Pracownik usunięty z bazy danych!";
                }
                else return "Pracownik nie istnieje w bazie danych!";
            }
            catch (SqlException e) {
                return "Wystąpił błąd";
            }
        }

        /**
         * Metoda pobiera nazwiska wszystkich pracowników znajdujących się w bazie danych.
         */
        public DataTable Nazwiska() {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pracownik");

            if (conn.State.ToString() == "Closed") {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pracownicy_firm";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                tbl.Rows.Add(dr["nazwisko"]);
            }

            conn.Close();
            return tbl;
        }

        /**
         * Metoda pobiera imiona pracowników o danych nazwiskach. Razem z poprzednią, służą do wybierania konkretnego pracownika.
         * Zastosowane przy usuwaniu pracownika, zmianie danych, dodawaniu odwiedzającego.
         */
        public DataTable Imiona(String nazwisko) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pracownik");

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pracownicy_firm where nazwisko = \'"+ nazwisko +"\'";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                tbl.Rows.Add(dr["imie"]);
            }

            conn.Close();
            return tbl;
        }

        /**
         * W przypadku, gdy w kilku firmach są pracownicy o tych samych nazwiskach, możemy wybrać o którego nam chodzi przy zmianie danych.
         */
        public DataTable FirmaPracownika(String imie, String nazwisko) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("firmy");
            
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pracownicy_firm p left outer join Firmy f on p.firma = f.id where p.imie = \'"+ imie +
                "\' and p.nazwisko = \'"+ nazwisko + "\'";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                tbl.Rows.Add(dr["nazwa"]);
            }

            conn.Close();
            return tbl;
        }

        /**
         * Dodawanie pomieszczenia do bazy danych. Metoda sprawdza, czy dane zostały podane we właściwym formacie.
         */
        public String dodaj_pomieszczenie(string nr, string pietro) {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            int nrInt;
            int pietroInt;

            try
            {
                nrInt = Convert.ToInt32(nr);
                pietroInt = Convert.ToInt32(pietro);
            }
            catch (FormatException f) {
                return "Błędnie wprowadzony numer pokoju!";
            
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into Pokoje values (" + pietroInt + ", " + nrInt + ")";
            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch (SqlException e) {
                return "Pokój istnieje już w bazie!";
            }
            return "Pokój wprowadzony pomyślnie do bazy!";
        }

        /*
         * Usuwa, o ile istniało, pomieszczenie z bazy danych.
         */
        public String usun_pomieszczenie(string nr, string pietro) {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            int nrInt;
            int pietroInt;

            try
            {
                nrInt = Convert.ToInt32(nr);
                pietroInt = Convert.ToInt32(pietro);
            }
            catch (FormatException f) {
                return "Błędne wprowadzony numer piętra lub pokoju!";
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from Pokoje where numer = " + nrInt + " and pietro = " 
                + pietroInt;
            try {
            if (newCmd.ExecuteNonQuery() > 0)
            {
                return "Pomieszczenie pomyślnie usunięte z bazy!";
            }
            else return "Pomieszczenie nie istnieje w bazie!";
            }
            catch(SqlException e){
                return "Pokój zajęty przez pracownika, zmień najpierw dane pracownika!";
            }

        }

        /**
         * Wypisuje pokoje dostępne na konkretnym piętrze. Używana przy usuwaniu pomieszczeń z bazy.
         */
        public DataTable PokojePietra(String pietro) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("pietro");

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            int pietroInt = int.Parse(pietro);

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pokoje where pietro = \'" + pietroInt + "\'";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                tbl.Rows.Add(dr["numer"]);
            }

            conn.Close();
            return tbl;
        }

        /**
         * Dodawanie piętra do bazy danych.
         */
        public String dodaj_pietro(string pietro) {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            int pietroInt;

            try
            {
                pietroInt = Convert.ToInt32(pietro);
            }
            catch (FormatException f) {
                return "Błędnie wprowadzony numer piętra!";
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into Pietra values (" + pietroInt + ")";
            try
            {
                if (newCmd.ExecuteNonQuery() > 0)
                {
                    return "Piętro wprowadzone pomyślnie do bazy!";
                }
                else return "Podane piętro zostało już wprowadzone do bazy!";
            }
            catch (SqlException e) {
                return "Podane piętro zostało już wprowadzone do bazy!";
            }
        }

        /**
         * Metoda pobierająca dane z bazy danych "Biurowiec", zależne od wywołanego okienka.
         */
        public DataSet Tabela(string Query) {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = Query;

            SqlDataAdapter sda = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Biurowiec");

            conn.Close();

            return ds;
        }

        /**
         * Sprawdza, przy dodawaniu nowego pracownika, czy podana firma istnieje.
         */
        public bool CzyFirmaIstnieje(String firma) {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Firmy where nazwa = \'" + firma + "\'";
            SqlDataReader dr = newCmd.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                dr.Close();
                return true;
            }
            conn.Close();
            dr.Close();
            return false;
        }

        /**
         * Sprawdza, przy dodawaniu pracownika, czy pokoj nalezy do firmy, w której pracownik pracuje.
         */
        public bool CzyPokojNalezy(String firma, int pokoj) {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pokoje where pietro = (select pietro from Firmy where nazwa = \'" + firma + 
                "\') and numer = \'" + pokoj + "\'";
            SqlDataReader dr = newCmd.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                dr.Close();
                return true;
            }
            conn.Close();
            dr.Close();
            return false;        
        }

        /*
         * Sprawdza, czy podana w formularzu osoba istnieje.
         */
        public bool CzyOsobaIstnieje(String nazwisko, String imie) {
            
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Pracownicy_firm where nazwisko = \'" + nazwisko +
                "\' and imie = \'" + imie + "\'";
            SqlDataReader dr = newCmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                conn.Close();
                return true;
            }
            dr.Close();
            conn.Close();
            return false;        
        
        }
    }

}
