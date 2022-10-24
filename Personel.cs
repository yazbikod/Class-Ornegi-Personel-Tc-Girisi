using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Personel_Tc
{
    public class Personel
    {
        private string tcKimlikNo;

        public string TCKİMLİKNO
        {
            get
            {
                return tcKimlikNo.Substring(0, 5) + "******";
            }
            set
            {
                bool kontrol = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi = char.IsNumber(value[i]);
                        if (sayimi)
                        {
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Sadece Rakam Girişi Yapılmalıdır....");
                    }
                    else
                    {
                        tcKimlikNo = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girilen Kimlik No 11 karakter olmalıdır....");
                }

            }
        }
    }
}

