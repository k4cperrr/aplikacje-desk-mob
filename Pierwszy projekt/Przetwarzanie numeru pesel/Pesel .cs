using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Pesel
    {
        private string numerPesel;
        private object numer;

        public char Plec
        {
            get
            {
                return numerPesel[9];
            }
        }
        public string PlecOpisowa
        {
            get
            {
                if (int.Parse(numerPesel[9].ToString()) % 2 == 1)
                    return "męzczyzna";

                else
                    return "kobieta";

            }
        }
        public string Rok
        {
            get
            {
                string rok = numerPesel[0].ToString() + numerPesel[1].ToString();
                
                string wiekdosprawdzenia = numerPesel[2].ToString();

                string wiek;

                if (wiekdosprawdzenia == "8" ||wiekdosprawdzenia == "9")
                {
                    wiek = "18";
                    return wiek + rok;
                }
                else if (wiekdosprawdzenia == "0" || wiekdosprawdzenia == "1")
                {
                    wiek = "19";
                    return wiek + rok;
                }
                else if (wiekdosprawdzenia == "2" || wiekdosprawdzenia == "3")
                {
                    wiek = "20";
                    return wiek + rok;
                }
                else if (wiekdosprawdzenia == "4" || wiekdosprawdzenia == "5")
                {
                    wiek = "21";
                    return wiek + rok;
                }
                else
                {
                    wiek = "22";
                    return wiek + rok;
                }

            }
        }
        public string miesac
        {
            get
            {
                string miesace = numerPesel[2].ToString() + numerPesel[3].ToString();
                int miesiacint = int.Parse(miesace);
                if (miesace[0] == '8')
                {
                    char k = char.Parse(miesace[1].ToString());
                    return k.ToString();
                }
                else if (miesace[0] == '9')
                {
                    if (miesace[1] == '0')
                    {
                        return "10";
                    }
                    else if (miesace[1] == '1')
                    {
                        return "11";
                    }
                    else
                    {
                        return "12";
                    }
                }
                else if (miesace[0] == '0')
                {
                    char k = char.Parse(miesace[1].ToString());
                    return k.ToString();
                }
                else if (miesace[0] == '1')
                {
                    if (miesace[1] == '0')
                    {
                        return "10";
                    }
                    else if (miesace[1] == '1')
                    {
                        return "11";
                    }
                    else
                    {
                        return "12";
                    }
                }

                else if (miesace[0] == '2')
                {
                    char k = char.Parse(miesace[1].ToString());
                    return k.ToString();
                }
                else if (miesace[0] == '3')
                {
                    if (miesace[1] == '0')
                    {
                        return "10";
                    }
                    else if (miesace[1] == '1')
                    {
                        return "11";
                    }
                    else
                    {
                        return "12";
                    }
                }
                else if (miesace[0] == '4')
                {
                    char k = char.Parse(miesace[1].ToString());
                    return k.ToString();
                }
                else if (miesace[0] == '5')
                {
                    if (miesace[1] == '0')
                    {
                        return "10";
                    }
                    else if (miesace[1] == '1')
                    {
                        return "11";
                    }
                    else
                    {
                        return "12";
                    }
                }
                else if (miesace[0] == '6')
                {
                    char k = char.Parse(miesace[1].ToString());
                    return k.ToString();
                }
                else
                {
                    if (miesace[1] == '0')
                    {
                        return "10";
                    }
                    else if (miesace[1] == '1')
                    {
                        return "11";
                    }
                    else
                    {
                        return "12";
                    }
                }






            }
        }
        public string dzien
        {
            get
            {
                string dzien = numerPesel[4].ToString() + numerPesel[5].ToString();
                return dzien;
            }
        }
        public Pesel(string numer)
        {

            numerPesel = numer;
            Walidacja();
            CzytoCyfra();
            Miesiac();
            Dzien();
            KontrolnaLiczba();




        }
        public void Walidacja()
        {
            if (numerPesel.Length != 11)
            {
                throw new Exception("Numer ma nieprawidłową ilość znaków");
            }
        }

        public void CzytoCyfra()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (numerPesel[i] > 58 || numerPesel[i] < 47)
                {
                    throw new Exception("nie jest cyfra");
                }
            }
        }

        public void KontrolnaLiczba()
        {
            int[] numerkontrolne = { (numerPesel[0]-48) * 1 , (numerPesel[1]-48) *3, (numerPesel[2]-48) * 7 ,(numerPesel[3]-48) * 9, (numerPesel[4]-48) * 1, (numerPesel[5]-48) * 3, (numerPesel[6]-48) * 7,
                                     (numerPesel[7]-48) * 9, (numerPesel[8]-48) * 1, (numerPesel[9]-48) * 3, (numerPesel[10]-48)};
            int suma = 0;

            int k = 0;
            while (k < 10)
            {

                if (numerkontrolne[k] >= 10)
                {
                    suma += numerkontrolne[k] % 10;
                }
                else
                {
                    suma += numerkontrolne[k];
                }
                k++;
            }

            int sprawdzenie = 10 - suma % 10;
            if ((numerkontrolne[10]) != sprawdzenie)
            {
                throw new Exception("nie jest dobra liczba kontrolna");
            }

        }

        public void Miesiac()
        {
            string k = numerPesel[2].ToString() + numerPesel[3].ToString();
            if (k != "81" || k != "82" || k != "83" || k != "84"
                || k != "85" || k != "86" || k != "87" || k != "88" ||
                k != "89" || k != "90" || k != "91" || k != "92" || k != "01"
                || k != "02" || k != "03" || k != "02" || k != "03" || k != "04" || k != "05"
                || k != "06" || k != "07" || k != "08" || k != "09" || k != "10" || k != "11" ||
                k != "12" || k != "21" || k != "22" || k != "23" || k != "24" || k != "25" ||
                k != "26" || k != "27" || k != "28" || k != "29" || k != "30" || k != "31" ||
                k != "32" || k != "41" || k != "42" || k != "43" || k != "44" || k != "45" || k != "46" || k != "47" ||
                k != "48" || k != "49" || k != "50" || k != "51" || k != "52" || k != "61" || k != "62" || k != "63" ||
                k != "64" || k != "65" || k != "66" || k != "67" || k != "68" || k != "69" || k != "70" || k != "71" || k != "72")
            {

            }
            else
            {
                throw new Exception("zly miesiac");

            }
        }
        public void Dzien()
        {
            {
                string rok = numerPesel[0].ToString() + numerPesel[1].ToString();
                string wiek;
                string dzien = numerPesel[4].ToString() + numerPesel[5].ToString();
                int dzienint = int.Parse(dzien);
                string miesiac = numerPesel[2].ToString() + numerPesel[3].ToString();
                char okreslajaca_miesiac = miesiac[1];
                int okreslajac_m = okreslajaca_miesiac;
                if (miesac[0] == '8' && miesac[0] == '9')
                {
                    wiek = "18";
                }
                else if (miesac[0] == '0' && miesac[0] == '1')
                {
                    wiek = "19";
                }
                else if (miesac[0] == '0' && miesac[0] == '1')
                {
                    wiek = "19";
                }
                else if (miesac[0] == '2' && miesac[0] == '3')
                {
                    wiek = "20";
                }
                else if (miesac[0] == '4' && miesac[0] == '5')
                {
                    wiek = "21";
                }
                else
                {
                    wiek = "22";
                }
                string rokstringg = wiek + rok;
                int rokint = int.Parse(rokstringg);

                if ((rokint % 4 == 0 && rokint % 100 != 0) || (rokint % 100 == 0 && rokint % 400 == 0))//rok przystepny
                {
                    if (((dzienint < 0 && dzienint > 31) && (miesiac != "81" || miesiac != "01" || miesiac != "21" || miesiac != "41" || miesiac != "61" || miesiac != "83" || miesiac != "03"
                        || miesiac != "23" || miesiac != "43" || miesiac != "63" || miesiac != "85" || miesiac != "05" || miesiac != "25" || miesiac != "45" || miesiac != "65"
                        || miesiac != "87" || miesiac != "07" || miesiac != "27" || miesiac != "47" || miesiac != "67" || miesiac != "88" || miesiac != "08" || miesiac != "28" || miesiac != "48"
                        || miesiac != "68" || miesiac != "90" || miesiac != "10" || miesiac != "30" || miesiac != "50" || miesiac != "70" || miesiac != "92" || miesiac != "12" || miesiac != "32" || miesiac != "52" || miesiac != "72"))
                        || ((dzienint < 0 && dzienint > 29) && (miesiac != "82" || miesiac != "02" || miesiac != "22" || miesiac != "42" || miesiac != "62"))
                        || ((dzienint < 0 && dzienint > 30) && (miesiac != "84" || miesiac != "04" || miesiac != "24" || miesiac != "44" || miesiac != "64"
                        || miesiac != "86" || miesiac != "06" || miesiac != "26" || miesiac != "46" || miesiac != "66" || miesiac != "89" || miesiac != "09"
                        || miesiac != "29" || miesiac != "49" || miesiac != "69" || miesiac != "91" || miesiac != "11" || miesiac != "31" || miesiac != "51" || miesiac != "71" || miesiac != "69"))
                        )
                    {
                        throw new Exception("zly dzien");
                    }


                }
                else
                {
                    if (((dzienint < 0 && dzienint > 31) && (miesiac != "81" || miesiac != "01" || miesiac != "21" || miesiac != "41" || miesiac != "61" || miesiac != "83" || miesiac != "03"
                        || miesiac != "23" || miesiac != "43" || miesiac != "63" || miesiac != "85" || miesiac != "05" || miesiac != "25" || miesiac != "45" || miesiac != "65"
                        || miesiac != "87" || miesiac != "07" || miesiac != "27" || miesiac != "47" || miesiac != "67" || miesiac != "88" || miesiac != "08" || miesiac != "28" || miesiac != "48"
                        || miesiac != "68" || miesiac != "90" || miesiac != "10" || miesiac != "30" || miesiac != "50" || miesiac != "70" || miesiac != "92" || miesiac != "12" || miesiac != "32" || miesiac != "52" || miesiac != "72"))
                        || ((dzienint < 0 && dzienint > 29) && (miesiac != "82" || miesiac != "02" || miesiac != "22" || miesiac != "42" || miesiac != "62"))
                        || ((dzienint < 0 && dzienint > 30) && (miesiac != "84" || miesiac != "04" || miesiac != "24" || miesiac != "44" || miesiac != "64"
                        || miesiac != "86" || miesiac != "06" || miesiac != "26" || miesiac != "46" || miesiac != "66" || miesiac != "89" || miesiac != "09"
                        || miesiac != "29" || miesiac != "49" || miesiac != "69" || miesiac != "91" || miesiac != "11" || miesiac != "31" || miesiac != "51" || miesiac != "71" || miesiac != "69"))
                        )
                    {
                        throw new Exception("zly dzien");
                    }
                }



            }



        }






    }
}