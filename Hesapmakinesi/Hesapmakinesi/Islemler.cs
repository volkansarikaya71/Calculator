using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesapmakinesi
{
    class islemler
    {

    }

    public class Islemler
    {
        public double _sonuc;
        public int _sayiatama= 0;
        public double Topla(double Toplam)
        {
            if(_sayiatama==0)
            {
                _sonuc = Toplam;
                _sayiatama++;
            }
            else 
            {             
            _sonuc +=  Toplam;
            }
            return (_sonuc);

        }
        public double Cıkar(double Cıkartma)
        {
            if (_sayiatama == 0)
            {
                _sonuc = Cıkartma;
                _sayiatama++;
            }
            else
            {
                _sonuc -= Cıkartma;
            }
            return (_sonuc);
        }
        public double Carp(double Carpma)
        {
            if (_sayiatama == 0)
            {
                _sonuc = Carpma;
                _sayiatama++;
            }
            else
            {
                _sonuc *= Carpma;
            }
            return (_sonuc);
        }
        public double Bol(double Bolme)
        {
            if (_sayiatama == 0)
            {
                _sonuc = Bolme;
                _sayiatama++;
            }
            else
            {
                _sonuc /= Bolme;
            }
            return (_sonuc);
        }
        public double Mod(double Modalma)
        {
            if (_sayiatama == 0)
            {
                _sonuc = Modalma;
                _sayiatama++;
            }
            else
            {
                _sonuc %= Modalma;
            }
            return (_sonuc);
        }
        public void Sifirla()
        {
            _sonuc = 0;
            _sayiatama = 0;
        }


    }

}
