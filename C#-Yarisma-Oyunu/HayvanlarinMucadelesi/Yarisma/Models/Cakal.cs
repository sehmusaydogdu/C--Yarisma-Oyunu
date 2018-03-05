namespace YarismaDunyasi.Models
{
    public class Cakal : Hayvan
    {
        public override void KonumDegistir()
        {
            if (UretilenSayi >= 0 && UretilenSayi <= 30) KonumX += 3;
            else if (UretilenSayi > 30 && UretilenSayi <= 50) KonumX -= 6;
            else KonumX += 2;
        }
    }
}
