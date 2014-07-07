using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using SecretSound.Core;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace SecretSound.View
{
    class DecipheringView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string filesourcepath;
        private string fileinputpath;
        private string fileoutputpath;
        private int mixBitsNum;
        private int mixPB;

        public DecipheringView()
        {
            fileinputpath = @"";
            fileoutputpath = @"";
            filesourcepath = @"";
            mixBitsNum = 4;
            mixPB = 0;
        }

        public void Mix()
        {
            Thread thr = new Thread(new ThreadStart(
                delegate
                {
                    int result = Keeper.Mix(filesourcepath, fileinputpath, fileoutputpath, mixBitsNum, new Keeper.ProgressCallback(MixPB_Change));
                    StringBuilder errorMessage = new StringBuilder(100);
                    if (result != 0)
                    {
                        Keeper.GetErrorMessage(result, errorMessage);
                        MessageBox.Show(errorMessage.ToString());
                    }
                    
                }));
            thr.Start();
        }

        public bool Check()
        {
            if (!File.Exists(filesourcepath))
            {
                MessageBox.Show("原音频文件路径不正确");
                return false;
            }
            if (!File.Exists(fileinputpath))
            {
                MessageBox.Show("待加密文件路径不正确");
                return false;
            }

            return true;
        }

        private void MixPB_Change(int e)
        {
            MixPB = e;
            if (MixPB == 100)
            {
                MessageBox.Show("加密完毕");
            }
        }

        public string FileSource_Path
        {
            get
            {
                return filesourcepath;
            }
            set
            {
                filesourcepath = value;
                NotifyPropertyChange("FileSource_Path");
            }
        }

        public string FileInput_Path
        {
            get
            {
                return fileinputpath;
            }
            set
            {
                fileinputpath = value;
                NotifyPropertyChange("FileInput_Path");
            }
        }

        public string FileOutput_Path
        {
            get
            {
                return fileoutputpath;
            }
            set
            {
                fileoutputpath = value;
                NotifyPropertyChange("FileOutput_Path");
            }
        }

        public int MixBitsNum
        {
            get
            {
                return mixBitsNum;
            }
            set
            {
                mixBitsNum = value;
                NotifyPropertyChange("MixBitsNum");
            }
        }

        public int MixPB
        {
            get
            {
                return mixPB;
            }
            set
            {
                mixPB = value;
                NotifyPropertyChange("MixPB");
            }
        }
    }
}
