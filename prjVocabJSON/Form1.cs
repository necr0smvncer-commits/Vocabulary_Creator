using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace prjVocabJSON
{
    public partial class Form1 : Form
    {
        // Declaring the dictionary
        Dictionary<string, string> dicVocabulary = new Dictionary<string, string>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Saving Dictionary into a JSON File
            string strVocabJSON = JsonSerializer.Serialize(dicVocabulary);
            if (sfdVocabulary.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdVocabulary.FileName, strVocabJSON);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Declairing the variabeles
            string strKey, strValue;
            
            strKey = txtKey.Text.Trim();
            strValue = txtValue.Text.Trim();
            // Checks if textBoxes are empty
            if (string.IsNullOrEmpty(strKey)|| string.IsNullOrEmpty(strValue))
            {
                MessageBox.Show("Your input is wrong!");
                return;
            }
            if (dicVocabulary.ContainsKey(strKey))
            {
                MessageBox.Show("This word already exists");
                return;
            }
            
            // Updates the quantity counter
            lblObjectQuantity.Text = "Quantity of cards in your Vocabulary: " + (dicVocabulary.Count+1);
            // Adds the new card to your vocabulary 
            dicVocabulary.Add(strKey, strValue);
            // Clears the textBoxes
            txtKey.Clear();
            txtValue.Clear();
        }
    }
}
