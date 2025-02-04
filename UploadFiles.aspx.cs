using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploading
{
    public partial class UploadFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFiles)
            {
                // Generate a new folder name based on the current timestamp
                string folderName = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string folderPath = Server.MapPath("~/Uploads/" + folderName);

                try
                {
                    // Create the folder if it doesn't exist
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    // Save each file to the newly created folder
                    foreach (var file in fileUpload.PostedFiles)
                    {
                        string fileName = Path.GetFileName(file.FileName);
                        string filePath = Path.Combine(folderPath, fileName);
                        file.SaveAs(filePath);
                    }

                    lblStatus.Text = $"Files uploaded successfully to folder: {folderName}";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error: " + ex.Message;
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                   lblStatus.Text = "No files selected.";
                   lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            



        }

    }
}
