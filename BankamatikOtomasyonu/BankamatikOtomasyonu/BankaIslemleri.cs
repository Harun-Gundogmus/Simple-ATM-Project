using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikOtomasyonu
{
    public class BankaIslemleri
    {
        public string musteri_ad;
        public string musteri_soyad;
        public int musteri_hesaptaki_para;
        public int musteri_yatirilacak_para;
        public int musteri_cekilecek_para;
        public int musteri_bakiye = 10000;
        public int kart_borcu, odenecek_miktar, guncel_borc;
        public string MusteriAdDondur(string _musteriad, string _musterisoyad)
        {
            musteri_ad = _musteriad;
            return musteri_ad;
            musteri_soyad = _musterisoyad;
            return musteri_ad;

        }
        public int ParaYatirma(int _musteri_hesaptakipara, int _musteriyatiralacak_para)
        {
            musteri_hesaptaki_para = _musteri_hesaptakipara;
            musteri_yatirilacak_para = _musteriyatiralacak_para;
            return musteri_hesaptaki_para = _musteri_hesaptakipara + _musteriyatiralacak_para;
        }
        public int ParaCekme(int _musteri_hesaptakipara, int _mustericekilecek_para)
        {
            musteri_hesaptaki_para = _musteri_hesaptakipara;
            musteri_cekilecek_para = _mustericekilecek_para;
            return musteri_hesaptaki_para = _musteri_hesaptakipara - _mustericekilecek_para;
        }
        public int BakiyeOgrenme(int _musteribakiye)
        {
            _musteribakiye = musteri_bakiye;
            return _musteribakiye;
        }
        public int KartBorcuOdeme(int _kartborcu, int _odenecekmiktar, int _guncelborc)
        {
            kart_borcu = _kartborcu;
            odenecek_miktar = _odenecekmiktar;
            guncel_borc = _guncelborc;
            return guncel_borc = kart_borcu - odenecek_miktar;
        }
    }
}
