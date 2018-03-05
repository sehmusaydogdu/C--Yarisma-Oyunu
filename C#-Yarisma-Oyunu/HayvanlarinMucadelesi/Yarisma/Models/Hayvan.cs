﻿
namespace YarismaDunyasi.Models
{

    public abstract class Hayvan:Yaris
    {
        private int _konumX;
        public  int KonumX
        {
            get => _konumX;
            set
            {
                if (_konumX < 0)
                    this._konumX = 0;
                else
                    this._konumX = value;
            }
        }

        public abstract void KonumDegistir();


    }
}
