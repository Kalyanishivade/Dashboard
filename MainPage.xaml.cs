namespace Baclground
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }





        private async void OnImageTapped(object sender, EventArgs e)
        {
            if (sender is Image image)
            {
                // Create a new Image for the Frame
                var selectedImage = new Image
                {
                    Source = image.Source,
                    Aspect = Aspect.AspectFit,

                };

                // Set the Frame's content to the selected image
                SelectedImageFrame.Content = selectedImage;
            }


        }



        private async void OnUploadImageTapped(object sender, EventArgs e)
        {
            // Use a file picker to allow the user to select an image (cross-platform support)
            try
            {
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Select an Image",
                    FileTypes = FilePickerFileType.Images
                });

                if (result != null)
                {
                    // Display the selected image or perform other actions
                    await DisplayAlert("Image Selected", $"File name: {result.FileName}", "OK");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., if the user cancels the picker
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }





    }
}



