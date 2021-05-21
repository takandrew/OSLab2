using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OSLab2
{
    public partial class MainForm : Form
    {
        List<int> files = new List<int>();
        List<int> clusters = new List<int>();
        List<List<int>> chains = new List<List<int>>();
        List<int> freeClusters = new List<int>();
        List<int> badClusters = new List<int>();
        List<int> fixedClusters = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void GetData(TextBox textBox, List<int> dataList)
        {
            try
            {
                string dataString = textBox.Text;
                string[] splittedDataString = dataString.Split(' ');
                int zero = 0;
                int countSpaces = zero;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        countSpaces++;
                    }
                }
                if (countSpaces == zero)
                {
                    MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                    return;
                }
                string[] withoutSpacesDataString = new string[countSpaces];
                int j = 0;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        withoutSpacesDataString[j] = splittedDataString[i];
                        j++;
                    }
                }
                for (int i = 0; i < withoutSpacesDataString.Length; i++)
                {
                    dataList.Add(Convert.ToInt32(withoutSpacesDataString[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void PrintFilesStart()
        {
            for (int i = 0; i < files.Count; i++)
                FileStartRichTextBox.Text += "[№" + i + "]: " + files[i] + "\n";
        }

        private void PrintClusters()
        {
            for (int i = 0; i < clusters.Count; i++)
            {
                if (clusters[i] == -1)
                    ClusterRichTextBox.Text += "[№" + i + "]: " + "" + "\n";
                else if (clusters[i] == -2)
                    ClusterRichTextBox.Text += "[№" + i + "]: " + "eof" + "\n";
                else if (clusters[i] == -3)
                    ClusterRichTextBox.Text += "[№" + i + "]: " + "bad" + "\n";
                else
                    ClusterRichTextBox.Text += "[№" + i + "]: " + clusters[i] + "\n";
            }
        }

        private void ChainBuild()
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < files.Count; i++)
            {
                temp.Add(files[i]);
            }
            for (int i = 0; i < files.Count; i++)
            {
                chains.Add(new List<int>());
                chains[i].Add(temp[i]);
                while (true)
                {
                    if (clusters[temp[i]] != -2)
                    {
                        chains[i].Add(clusters[temp[i]]);
                        temp[i] = clusters[temp[i]];
                    }
                    else
                        break;
                }
            }
        }

        private void PrintChains()
        {
            for (int i = 0; i < chains.Count; i++)
            {
                ChainRichTextBox.Text += "[№" + i + "]: " + string.Join(", ", chains[i]) + "\n";
            }
            ChainRichTextBox.Text += "\n";
            List<int> temp = new List<int>();
            for (int i = 0; i < chains.Count; i++)
                for (int j = i+1; j < chains.Count; j++)
                {
                    temp = chains[i].Intersect(chains[j]).ToList();
                    if (temp.Count > 0)
                        ChainRichTextBox.Text += "Цепочки " + i + " и " + j + " пересекаются" + "\n";
                }
        }

        private void ClustersFix()
        {
            var tempList = new List<int>();

            for (int i = 0; i < chains.Count; i++)
            {
                for (int j = 0; j < chains[i].Count; j++)
                {
                    tempList.Add(chains[i][j]);
                }
            }

            for (int i = 2; i < clusters.Count - 1; i++)
            {
                if (!tempList.Contains(clusters[i]) && clusters[i] > 0)
                {
                    fixedClusters.Add(i);
                    if (clusters[i + 1] == -2) fixedClusters.Add(i + 1 - (i + 2));
                }

            }
            for (int k = 1; k < fixedClusters.Count; k++)
            {
                if (k == 1)
                {
                    files.Add(fixedClusters[k - 1]);
                }
                else if (fixedClusters[k - 1] == -2)
                {
                    files.Add(fixedClusters[k]);
                }

            }
        }

        private void ClustersBadFreeFind()
        {
            for (int i = 0; i < clusters.Count; i++)
            {
                if (clusters[i] == -3)
                    badClusters.Add(i);
                if (clusters[i] == -1)
                    freeClusters.Add(i);
            }
        }

        private void ChainIntersectionFix()
        {
            int currentCluster = 0;
            for (int i = 0; i < chains.Count; i++)
            {
                for (int j = i + 1; j < chains.Count; j++)
                {
                    var tempList = chains[i].Intersect(chains[j]).ToList();
                    if (tempList.Count > 0)
                    {
                        int firstChangingCluster = chains[j].Count - tempList.Count;
                        for (int k = 0; k < chains[j].Count; k++)
                        {
                            if (tempList.Any(cluster => cluster == chains[j][k]))
                            {
                                if (k == firstChangingCluster)
                                {
                                    clusters[chains[j][firstChangingCluster - 1]] = freeClusters[currentCluster];
                                }
                                if (k == chains[j].Count - 1)
                                {
                                    clusters[freeClusters[currentCluster]] = -2;
                                    currentCluster++;
                                }
                                else
                                {
                                    clusters[freeClusters[currentCluster]] = freeClusters[currentCluster + 1];
                                    currentCluster++;
                                }
                            }
                        }
                    }
                    tempList.Clear();
                }
            }
        }

        private void ChainsFragmentationCheck()
        {
            for (int i = 0; i < chains.Count; i++)
            {
                int counter = 0;
                for (int j = 1; j < chains[i].Count; j++)
                {
                    if (chains[i][j] - 1 == chains[i][j - 1])
                    {
                        counter++;
                        if (counter == chains[i].Count - 1)
                        {
                            FragmentationRichTextBox.Text += "[№" + i + "]: \n" + "фрагментирован" + "\n";
                        }
                    }
                    else
                    {
                        FragmentationRichTextBox.Text += "[№" + i + "]: \n" + "дефрагментирован" + "\n";
                        break;
                    }
                }
            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            files.Clear();
            clusters.Clear();
            chains.Clear();
            badClusters.Clear();
            freeClusters.Clear();
            FileStartRichTextBox.Clear();
            ClusterRichTextBox.Clear();
            ChainRichTextBox.Clear();
            FragmentationRichTextBox.Clear();

            GetData(FileStartTextBox, files);
            GetData(ClusterTextBox, clusters);
            try
            {
                ChainBuild();
          
                PrintFilesStart();
                PrintClusters();
                PrintChains();
                ChainsFragmentationCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            FileStartRichTextBox.Clear();
            ClusterRichTextBox.Clear();
            ChainRichTextBox.Clear();
            FragmentationRichTextBox.Clear();
            try
            {
                ClustersFix();
                ClustersBadFreeFind();
                ChainIntersectionFix();
                chains.Clear();
                ChainBuild();

                PrintFilesStart();
                PrintClusters();
                PrintChains();
                ChainsFragmentationCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
