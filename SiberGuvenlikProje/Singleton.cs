using System;
using System.Collections.Generic;
using System.Text;

namespace SiberGuvenlikProje
{
    public sealed class Singleton
    {
        private string resimYolu = "";

        public static Singleton instance = null;

        private Singleton()
        {

        }

        public static Singleton Instance { 
            get {
                
                if(instance == null){
                    instance = new Singleton();
                }
                return Instance;
            }

        }

        public string ResimYolu { get => resimYolu; set => resimYolu = value; }
    }
}
