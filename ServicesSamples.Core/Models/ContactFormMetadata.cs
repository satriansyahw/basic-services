using Intersoft.Crosslight;
using Intersoft.Crosslight.Forms;

namespace ServicesSamples.Models
{
    [Form(Title = "{FormState} Contact")]
    public class ContactFormMetadata
    {
        #region Fields

        [Section]
        public static DetailSection Detail;

        [Section(Style = SectionLayoutStyle.ImageWithFields)]
        public static GeneralSection General;

        #endregion

        #region Nested type: DetailSection

        public class DetailSection
        {
            #region Fields

            [Layout(Style = LayoutStyle.RightDetail)]
            [Binding(Path = "Email.Address", SourceType = BindingSourceType.ViewModel, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged)]
            public static string Email;

            [Layout(Style = LayoutStyle.RightDetail)]
            [Binding(Path = "Phone.Number", SourceType = BindingSourceType.ViewModel, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged)]
            public static string Phone;

            #endregion
        }

        #endregion

        #region Nested type: GeneralSection

        public class GeneralSection
        {
            #region Fields

            [StringInput(Placeholder = "First Name")]
            [Layout(Style = LayoutStyle.DetailOnly)]
            public static string FirstName;

            [StringInput(Placeholder = "Last Name")]
            [Layout(Style = LayoutStyle.DetailOnly)]
            public static string LastName;

            [Editor(EditorType.Image)]
            [Image(Height = 83, Width = 80, Placeholder = "photo_placeholder.jpg", Frame = "frame.png", FramePadding = 6, FrameShadowHeight = 3)]
            [ImagePicker(ImageResultMode = ImageResultMode.Both, PickerResultCommand = "FinishImagePickerCommand")]
            public static byte[] Photo;

            #endregion
        }

        #endregion
    }
}