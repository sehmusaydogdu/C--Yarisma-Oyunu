namespace YarismaDunyasi.Models
{
    public class Fil : Hayvan
    {
        public override void KonumDegistir()
        {
            if (UretilenSayi >= 0 && UretilenSayi <= 50) KonumX += 2;
            else if (UretilenSayi > 50 && UretilenSayi <= 70) KonumX+=0;
            else KonumX += 4;
        }
    }
}
