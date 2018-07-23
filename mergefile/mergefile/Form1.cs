using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mergefile
{
    public partial class Form1 : Form
    {
        string filePath;
        string fileDestPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTopenFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.SelectedPath;
                DirectoryInfo theFolder = new DirectoryInfo(filePath);
                textEfilePath.Text = filePath;
            }

        }

        private void BTStart_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            string fileExtent = ".cs";
            ArrayList alist = new ArrayList();
            ArrayList afileName = new ArrayList();
            GetAllFiles(alist, afileName,fileExtent, directoryInfo);
            //打开文件
            FileStream fsWrite = new FileStream(fileDestPath, FileMode.Append);
            for(int i=0;i<alist.Count;i++)
            {
                FileStream fsRead = new FileStream(alist[i].ToString(), FileMode.Open);
                int fsLen = (int)fsRead.Length;
                byte[] heByte = new byte[fsLen];
                int r = fsRead.Read(heByte, 0, heByte.Length);
                string filename = "文件名称："+afileName[i].ToString()+"\r\n";
                byte[] myByte = System.Text.Encoding.UTF8.GetBytes(filename);
                fsWrite.Write(myByte, 0, myByte.Length);
                //写入文本
                fsWrite.Write(heByte, 0, heByte.Length);
                //string myStr = System.Text.Encoding.UTF8.GetString(heByte);
                //Console.WriteLine(myStr);
                //Console.ReadKey();
                fsRead.Flush();
                fsRead.Close();
            }
            fsWrite.Flush();
            fsWrite.Close();
            MessageBox.Show("文件解析完成！");
        }
        private void GetAllFiles(ArrayList list,ArrayList afileName, string fileExtension, DirectoryInfo directoryInfo)
        {

            

            //获取该目录下指定类型的所有文件

            FileInfo[] fileInfos = directoryInfo.GetFiles();



            foreach (FileInfo fileInfo in fileInfos)
            {

              if(fileInfo.Extension.ToLower() ==fileExtension )
              {

                  list.Add(fileInfo.FullName);
                  afileName.Add(fileInfo.Name);
              }

            }

            //获取该目录下的所有子目录

            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();



            foreach (DirectoryInfo subDirectory in subDirectories)
            {

                GetAllFiles(list, afileName,fileExtension, subDirectory);

            }

            return ;

        }

        private void openDest_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                     fileDestPath = dialog.FileName;
                destPath.Text = fileDestPath;
                 }
        }
    }
}
