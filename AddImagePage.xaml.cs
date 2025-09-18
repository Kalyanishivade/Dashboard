namespace Baclground;

public partial class AddImagePage : ContentPage
{
	public AddImagePage()
	{
		InitializeComponent();
	}

    //private void OnImageTapped(object sender, EventArgs e)
    //{
    //    if (sender is Image image)
    //    {
    //        // Create a new Image for the Frame
    //        var selectedImage = new Image
    //        {
    //            Source = image.Source,
    //            Aspect = Aspect.AspectFit,
    //            HeightRequest = 200,
    //            WidthRequest = 200
    //        };

    //        // Set the Frame's content to the selected image
    //        SelectedImageFrame.Content = selectedImage;
    //    }
    //}


  

        private async void OnDownloadButtonClicked(object sender, EventArgs e)
        {
            try
            {
                // Path to the image you want to download
                string imageUrl = "https://example.com/your-image.jpg";

                // Download the image
                using var httpClient = new HttpClient();
                var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);

                // Save the image to the device
                string fileName = "CustomBackground.jpg";
                string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, fileName);

                await File.WriteAllBytesAsync(filePath, imageBytes);

                // Show a confirmation message to the user
                await DisplayAlert("Download Complete", $"Image saved to: {filePath}", "OK");
            }
            catch (Exception ex)
            {
                // Handle errors
                await DisplayAlert("Error", $"Failed to download image: {ex.Message}", "OK");
            }
        }
    }


    