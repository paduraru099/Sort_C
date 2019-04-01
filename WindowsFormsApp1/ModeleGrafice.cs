using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class ModeleGrafice : Form
    {
        public ModeleGrafice()
        {
            InitializeComponent();
        }


        private void ModeleGrafice_Load(object sender, EventArgs e)
        {
            Generat = false;
            G = groupBox1.CreateGraphics();
        }

        bool Generat = false;
        int[] a = new int[21];
        int[] V = new int[30];
        Graphics G;
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        private void colorare(int i, SolidBrush p)
        {
            G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
            G.FillRectangle(p, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
        }
        private void colorare_merge(int []a, int i, SolidBrush p, int pozitie)
        {
            G.FillRectangle(whiteBrush, 35 * (pozitie + 1), 466 - 20 * a[i], 20, 20 * a[i]);
            G.FillRectangle(p, 35 * (pozitie + 1), 466 - 20 * a[i], 20, 20 * a[i]);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generat = true;
       
            for (int i = 1; i <= 29; ++i)
                V[i] = 0;
            int nrG = 0;
          
            while (nrG < 20)
            {
                Random rnd = new Random();
                int nr = rnd.Next(1, 21);
                if(V[nr] == 0)
                {
                    V[nr] = 1;
                    a[++nrG] = nr;
                    
                }
            }
            MessageBox.Show("Sirul a fost generat");
         
            G.Clear(Color.White);
            Pen p = new Pen(Color.Black, 1);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            for (int i = 1; i <= 20; ++i)
                G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Generat == true)
            {
               
                for (int i = 1; i <= 19; ++i)
                {
                    G.FillRectangle(blueBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    Application.DoEvents();
                    Thread.Sleep(125);
                    for (int j = i + 1; j <= 20; ++j)
                    {
                        G.FillRectangle(redBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                        Application.DoEvents();
                        Thread.Sleep(125);
                        if (a[i] > a[j])
                        {
                            G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                            G.FillRectangle(blueBrush, 35 * i, 466 - 20 * a[j], 20, 20 * a[j]);
                            G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                            G.FillRectangle(redBrush, 35 * j, 466 - 20 * a[i], 20, 20 * a[i]);
                            int aux = a[i];
                            a[i] = a[j];
                            a[j] = aux;

                        }
                        G.FillRectangle(blackBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    }
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                }
                for (int i = 1; i <= 20; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                }
                for (int i = 1; i <= 20; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    Application.DoEvents();
                    Thread.Sleep(95);
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                }
                MessageBox.Show("Sirul a fost ordonat !");
            }
            else
                MessageBox.Show("Genereaza sirul mai intai !");

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            if (Generat == true)
            {
                    for (int i = 1; i < 20; ++i)
                     {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    int min_act = i;
                    Application.DoEvents();
                    Thread.Sleep(105);
                    bool ok = false;
                    for (int j = i + 1; j <= 20; ++j)
                    {
                    
                        G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                        G.FillRectangle(blueBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                        Application.DoEvents();
                        Thread.Sleep(105);
                        if (a[j] < a[min_act])
                        {
                            if(ok == true)
                            {
                                G.FillRectangle(blackBrush, 35 * min_act, 466 - 20 * a[min_act], 20, 20 * a[min_act]);
                            }

                            ok = true;
                            min_act = j;
                            G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                            G.FillRectangle(greenBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                        }
                   
                        else
                        {
                            G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                            G.FillRectangle(blackBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                        }
                    }


                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[min_act], 20, 20 * a[min_act]);

                    G.FillRectangle(whiteBrush, 35 * min_act, 466 - 20 * a[min_act], 20, 20 * a[min_act]);
                    G.FillRectangle(blackBrush, 35 * min_act, 466 - 20 * a[i], 20, 20 * a[i]);
                    int aux = a[min_act];
                    a[min_act] = a[i];
                    a[i] = aux;

                     }
                for (int i = 1; i <= 20; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                }
                for (int i = 1; i <= 20; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    Application.DoEvents();
                    Thread.Sleep(95);
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                }
                MessageBox.Show("Sirul a fost ordonat !");
            }
            else
                MessageBox.Show("Genereaza sirul mai intai !");
        }

        private void shellSort(int [] arr, int n)
        {
            // Start with a big gap, then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already in gapped order
                // keep adding one more element until the entire array is
                // gap sorted 
                for (int i = gap; i <= n; i += 1)
                {
                    // add a[i] to the elements that have been gap sxorted
                    // save a[i] in temp and make a hole at position i
                    int temp = arr[i];

                    // shift earlier gap-sorted elements up until the correct 
                    // location for a[i] is found
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];

                    //  put temp (the original a[i]) in its correct location
                    arr[j] = temp;
                }
            }
           
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void QuickSort(int st, int dr)
        {
            int pivot = a[(st + dr) / 2], i = st, j = dr;
            int ipivot = (st + dr) / 2;
            G.FillRectangle(whiteBrush, 35 * ipivot, 466 - 20 * a[ipivot], 20, 20 * a[ipivot]);
            G.FillRectangle(greenBrush, 35 * ipivot, 466 - 20 * a[ipivot], 20, 20 * a[ipivot]);

            while (i <= j)
            {
                G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                while (a[i] < pivot)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    Application.DoEvents();
                    Thread.Sleep(125);
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    i++;

                }
                G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);

                G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                G.FillRectangle(blueBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);

                while (a[j] > pivot)
                {
                    G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    G.FillRectangle(blueBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    Application.DoEvents();
                    Thread.Sleep(125);
                    G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    G.FillRectangle(blackBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    j--;

                }
                G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                G.FillRectangle(blueBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                if(i <= j)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    int aux = a[i];
                    a[i] = a[j];
                    a[j] = aux;
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);

                    G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    G.FillRectangle(blueBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);

                    Application.DoEvents();
                    Thread.Sleep(125);

                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);

                    G.FillRectangle(whiteBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);
                    G.FillRectangle(blackBrush, 35 * j, 466 - 20 * a[j], 20, 20 * a[j]);

                    i++;
                    j--;


                }
               

            }

            if (i < dr) QuickSort(i, dr);
            if (st < j) QuickSort(st, j);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Generat)
            {
                QuickSort(1, 20);
                for (int i = 1; i <= 20; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                }
                    for (int i = 1; i <= 20; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(redBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    Application.DoEvents();
                    Thread.Sleep(95);
                    G.FillRectangle(whiteBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * i, 466 - 20 * a[i], 20, 20 * a[i]);
                }
                MessageBox.Show("Sirul a fost ordonat !");
            }
            else
                MessageBox.Show("Genereaza sirul mai intai !");
        }
        /*private void merge(int[] a, int l, int m, int r)
        {
            
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[20];
            int[] R = new int[20];
            for ( i = 0; i < n1; ++i)
                L[i] = a[l + i];
            for ( j = 0; j < n2; ++j)
                R[j] = a[m + 1 + j];
            i = 0;
            j = 0;
            k = l;
            while( i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                    a[k] = L[i++];
                else
                    a[k] = R[j++];
                k++;
            }
            while( i < n1 )
            {
                a[k++] = L[i++]; 
            }
            while (j < n2)
                a[k++] = L[j++];
        }


        private void merge_sort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                merge_sort(a, l, m);
                merge_sort(a, m + 1, r);
                merge(a, l, m, r);
            }
           
        }*/

        private void merge(int []arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            int []L = new int[20];
            int[] R = new int[20];

            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
                G.FillRectangle(whiteBrush, 35 * ( l + i + 1), 466 - 20 * L[i], 20, 20 * L[i]);
                G.FillRectangle(redBrush, 35 * (l + i + 1), 466 - 20 * L[i], 20, 20 * L[i]);
                Application.DoEvents();
                Application.DoEvents();
                Thread.Sleep(100);
            }
         
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
                int u = m + 1 + j;
                G.FillRectangle(whiteBrush, 35 * (u + 1), 466 - 20 * R[j], 20, 20 * R[j]);
                G.FillRectangle(blueBrush, 35 * (u + 1), 466 - 20 * R[j], 20, 20 * R[j]);
                Application.DoEvents();
                Thread.Sleep(100);
            }

          
           
        
            

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray
            j = 0; // Initial index of second subarray
            k = l; // Initial index of merged subarray
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    G.FillRectangle(whiteBrush, 35 * (k + 1), 466 - 20 * arr[k], 20, 20 * arr[k]);
                    arr[k] = L[i];
                   
                    G.FillRectangle(blackBrush, 35 * (k + 1), 466 - 20 * arr[k], 20, 20 * arr[k]);
                    i++;
                    Application.DoEvents();
                    Thread.Sleep(150);
                }
                else
                {
                    G.FillRectangle(whiteBrush, 35 * (k + 1), 466 - 20 * arr[k], 20, 20 * arr[k]);
                    arr[k] = R[j];

                   
                    G.FillRectangle(blackBrush, 35 * (k + 1), 466 - 20 * R[j], 20, 20 * R[j]);
                    j++;
                    Application.DoEvents();
                    Thread.Sleep(150);
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there
               are any */
            while (i < n1)
            {
                G.FillRectangle(whiteBrush, 35 * (k + 1), 466 - 20 * arr[k], 20, 20 * arr[k]);
                arr[k] = L[i];
               
                G.FillRectangle(blackBrush, 35 * (k + 1), 466 - 20 * arr[k], 20, 20 * arr[k]);
                Application.DoEvents();
                Thread.Sleep(150);

                i++;
                k++;
            }

            /* Copy the remaining elements of R[], if there
               are any */
            while (j < n2)
            {
                G.FillRectangle(whiteBrush, 35 * (k + 1), 466 - 20 * arr[k], 20, 20 * arr[k]);
                arr[k] = R[j];
                
                G.FillRectangle(blackBrush, 35 * (k + 1), 466 - 20 * arr[k], 20, 20 * arr[k]);
                Application.DoEvents();
                Thread.Sleep(150);
                j++;
                k++;
            }
        }

        /* l is for left index and r is right index of the
           sub-array of arr to be sorted */
        private void mergeSort(int[]arr, int l, int r)
        {
            if (l < r)
            {
                // Same as (l+r)/2, but avoids overflow for
                // large l and h
                int m = l + (r - l) / 2;

                // Sort first and second halves
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Generat)
            {
                for (int i = 0; i < 20; ++i)
                    a[i] = a[i + 1];

                mergeSort(a, 0, 19);
                for (int i = 0; i <= 19; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * (i + 1), 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * (i + 1), 466 - 20 * a[i], 20, 20 * a[i]);
                }
                for (int i = 0; i <= 19; ++i)
                {
                    G.FillRectangle(whiteBrush, 35 * (i + 1), 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(redBrush, 35 * (i + 1), 466 - 20 * a[i], 20, 20 * a[i]);
                    Application.DoEvents();
                    Thread.Sleep(95);
                    G.FillRectangle(whiteBrush, 35 * (i + 1), 466 - 20 * a[i], 20, 20 * a[i]);
                    G.FillRectangle(blackBrush, 35 * (i + 1), 466 - 20 * a[i], 20, 20 * a[i]);
                }
                MessageBox.Show("Sirul a fost ordonat !");
            }
            else
                MessageBox.Show("Ordoneaza Sirul mai intai");


        }
    }
}
