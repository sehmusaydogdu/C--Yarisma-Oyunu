using YarismaDunyasi.Models;

namespace Yarisma.Models
{
    public class DeveKusu : Hayvan
    {
        public override void KonumDegistir()
        {
            if (UretilenSayi >= 0 && UretilenSayi <= 20) KonumX += 0;
            else if (UretilenSayi > 20 && UretilenSayi <= 40) KonumX += 9;
            else if (UretilenSayi > 40 && UretilenSayi <= 50) KonumX -= 12;
            else if (UretilenSayi > 50 && UretilenSayi <= 80) KonumX += 1;
            else KonumX -= 2;
        }
    }
}
