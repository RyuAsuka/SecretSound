using SecretSound.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SecretSound.View
{
    class EncipheringView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string fileinputpath;
        private string fileoutputpath;
        private int mixBitsNum;
        private int mixPB;

        public EncipheringView()
        {
            fileinputpath = @"";
            fileoutputpath = @"";
            mixBitsNum = 4;
            mixPB = 0;
        }

        public void Extract()
        {
            Thread thr = new Thread(new ThreadStart(
                delegate
                {
                    int result = Keeper.Extract(fileinputpath, "SSOutFile", new Keeper.ProgressCallback(MixPB_Change));
                    StringBuilder errorMessage = new StringBuilder(100);
                    if (result != 0)
                    {
                        Keeper.GetErrorMessage(result, errorMessage);
                        MessageBox.Show(errorMessage.ToString());
                    }
                    else
                    {
                        string dir = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                        DirectoryInfo di = new DirectoryInfo(dir);
                        FileInfo[] arry_fi = di.GetFiles();
                        foreach (FileInfo a in arry_fi)
                        {
                            if (a.Name.StartsWith("SSOutFile"))
                            {
                                string target = fileoutputpath + @"\" + a.Name;
                                if (File.Exists(target))
                                {
                                    File.Delete(target);
                                }
                                File.Move(a.FullName, target);
                                break;
                            }
                        }
                    }

                }));
            thr.Start();
            
        }

        public bool Check()
        {
            if (!File.Exists(fileinputpath))
            {
                MessageBox.Show("加密文件路径不正确");
                return false;
            }
            if (!Directory.Exists(fileoutputpath))
            {
                MessageBox.Show("输出文件路径不正确");
                return false;
            }

            return true;
        }

        private void MixPB_Change(int e)
        {
            MixPB = e;
            if (MixPB == 100)
            {
                MessageBox.Show("解密完成");
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
