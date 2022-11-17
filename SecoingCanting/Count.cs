
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SecoingCanting
{
    public class Count : INotifyPropertyChanged
    {

        private int test;


        public int i
        {
            get
            { return test; }


            set
            {
                test = value;
                OnPropertyChanged("i");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }




}
