using pdfforge.DataStorage.Storage;
using pdfforge.DataStorage;
using pdfforge.PDFCreator.Conversion.Settings.Enums;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System;

// ! This file is generated automatically.
// ! Do not edit it outside the sections for custom code.
// ! These changes will be deleted during the next generation run

namespace pdfforge.PDFCreator.Conversion.Settings
{
	[ImplementPropertyChanged]
	public partial class ConversionProfile : INotifyPropertyChanged {
		#pragma warning disable 67
		public event PropertyChangedEventHandler PropertyChanged;
		#pragma warning restore 67
		
		
		/// <summary>
		/// Appends one or more pages at the end of the converted document
		/// </summary>
		public AttachmentPage AttachmentPage { get; set; } = new AttachmentPage();
		
		/// <summary>
		/// AutoSave allows to create PDF files without user interaction
		/// </summary>
		public AutoSave AutoSave { get; set; } = new AutoSave();
		
		/// <summary>
		/// Adds a page background to the resulting document
		/// </summary>
		public BackgroundPage BackgroundPage { get; set; } = new BackgroundPage();
		
		/// <summary>
		/// Inserts one or more pages at the beginning of the converted document
		/// </summary>
		public CoverPage CoverPage { get; set; } = new CoverPage();
		
		/// <summary>
		/// Dropbox settings for currently logged user
		/// </summary>
		public DropboxSettings DropboxSettings { get; set; } = new DropboxSettings();
		
		/// <summary>
		/// Opens the default E-mail client with the converted document as attachment
		/// </summary>
		public EmailClientSettings EmailClientSettings { get; set; } = new EmailClientSettings();
		
		/// <summary>
		/// Sends a mail without user interaction through SMTP
		/// </summary>
		public EmailSmtpSettings EmailSmtpSettings { get; set; } = new EmailSmtpSettings();
		
		/// <summary>
		/// Upload the converted documents with FTP
		/// </summary>
		public Ftp Ftp { get; set; } = new Ftp();
		
		/// <summary>
		/// Ghostscript settings
		/// </summary>
		public Ghostscript Ghostscript { get; set; } = new Ghostscript();
		
		/// <summary>
		/// Action to upload files to a HTTP server
		/// </summary>
		public HttpSettings HttpSettings { get; set; } = new HttpSettings();
		
		/// <summary>
		/// Settings for the JPEG output format
		/// </summary>
		public JpegSettings JpegSettings { get; set; } = new JpegSettings();
		
		/// <summary>
		/// Settings for the PDF output format
		/// </summary>
		public PdfSettings PdfSettings { get; set; } = new PdfSettings();
		
		/// <summary>
		/// Settings for the PNG output format
		/// </summary>
		public PngSettings PngSettings { get; set; } = new PngSettings();
		
		/// <summary>
		/// Print the document to a physical printer
		/// </summary>
		public Printing Printing { get; set; } = new Printing();
		
		/// <summary>
		/// Properties of the profile
		/// </summary>
		public Properties Properties { get; set; } = new Properties();
		
		/// <summary>
		/// Settings to control the behaviour of the save dialog
		/// </summary>
		public SaveDialog SaveDialog { get; set; } = new SaveDialog();
		
		/// <summary>
		/// The scripting action allows to run a script after the conversion
		/// </summary>
		public Scripting Scripting { get; set; } = new Scripting();
		
		/// <summary>
		/// Place a stamp text on all pages of the document
		/// </summary>
		public Stamping Stamping { get; set; } = new Stamping();
		
		public TextSettings TextSettings { get; set; } = new TextSettings();
		
		/// <summary>
		/// Settings for the TIFF output format
		/// </summary>
		public TiffSettings TiffSettings { get; set; } = new TiffSettings();
		
		/// <summary>
		/// Parse ps files for user definied tokens
		/// </summary>
		public UserTokens UserTokens { get; set; } = new UserTokens();
		
		/// <summary>
		/// Template for the Author field. This may contain tokens.
		/// </summary>
		public string AuthorTemplate { get; set; } = "<PrintJobAuthor>";
		
		/// <summary>
		/// Template of which the filename will be created. This may contain Tokens.
		/// </summary>
		public string FileNameTemplate { get; set; } = "<Title>";
		
		/// <summary>
		/// GUID of the profile
		/// </summary>
		public string Guid { get; set; } = "";
		
		/// <summary>
		/// Template for the Keyword field. This may contain tokens.
		/// </summary>
		public string KeywordTemplate { get; set; } = "";
		
		/// <summary>
		/// Name of the profile
		/// </summary>
		public string Name { get; set; } = "NewProfile";
		
		/// <summary>
		/// Open the default viewer after converting the document
		/// </summary>
		public bool OpenViewer { get; set; } = true;
		
		/// <summary>
		/// If the output is a PDF, use PDF Architect instead of the default PDF viewer
		/// </summary>
		public bool OpenWithPdfArchitect { get; set; } = true;
		
		/// <summary>
		/// Default format for this print job.
		/// </summary>
		public OutputFormat OutputFormat { get; set; } = OutputFormat.Pdf;
		
		/// <summary>
		/// If true, a progress window will be shown during conversion
		/// </summary>
		public bool ShowProgress { get; set; } = true;
		
		/// <summary>
		/// Show quick actions page after converting the document
		/// </summary>
		public bool ShowQuickActions { get; set; } = true;
		
		/// <summary>
		/// Allows to skip the print dialog (where metadata are set) and directly proceed to the save dialog
		/// </summary>
		public bool SkipPrintDialog { get; set; } = false;
		
		/// <summary>
		/// Template for the Subject field. This may contain tokens.
		/// </summary>
		public string SubjectTemplate { get; set; } = "";
		
		/// <summary>
		/// Directory in which the files will be saved (in interactive mode, this is the default location that is presented to the user)
		/// </summary>
		public string TargetDirectory { get; set; } = "";
		
		/// <summary>
		/// Template for the Title field. This may contain tokens.
		/// </summary>
		public string TitleTemplate { get; set; } = "<PrintJobName>";
		
		
		public void ReadValues(Data data, string path) {
			AttachmentPage.ReadValues(data, path + @"AttachmentPage\");
			AutoSave.ReadValues(data, path + @"AutoSave\");
			BackgroundPage.ReadValues(data, path + @"BackgroundPage\");
			CoverPage.ReadValues(data, path + @"CoverPage\");
			DropboxSettings.ReadValues(data, path + @"DropboxSettings\");
			EmailClientSettings.ReadValues(data, path + @"EmailClientSettings\");
			EmailSmtpSettings.ReadValues(data, path + @"EmailSmtpSettings\");
			Ftp.ReadValues(data, path + @"Ftp\");
			Ghostscript.ReadValues(data, path + @"Ghostscript\");
			HttpSettings.ReadValues(data, path + @"HttpSettings\");
			JpegSettings.ReadValues(data, path + @"JpegSettings\");
			PdfSettings.ReadValues(data, path + @"PdfSettings\");
			PngSettings.ReadValues(data, path + @"PngSettings\");
			Printing.ReadValues(data, path + @"Printing\");
			Properties.ReadValues(data, path + @"Properties\");
			SaveDialog.ReadValues(data, path + @"SaveDialog\");
			Scripting.ReadValues(data, path + @"Scripting\");
			Stamping.ReadValues(data, path + @"Stamping\");
			TextSettings.ReadValues(data, path + @"TextSettings\");
			TiffSettings.ReadValues(data, path + @"TiffSettings\");
			UserTokens.ReadValues(data, path + @"UserTokens\");
			try { AuthorTemplate = Data.UnescapeString(data.GetValue(@"" + path + @"AuthorTemplate")); } catch { AuthorTemplate = "<PrintJobAuthor>";}
			try { FileNameTemplate = Data.UnescapeString(data.GetValue(@"" + path + @"FileNameTemplate")); } catch { FileNameTemplate = "<Title>";}
			try { Guid = Data.UnescapeString(data.GetValue(@"" + path + @"Guid")); } catch { Guid = "";}
			try { KeywordTemplate = Data.UnescapeString(data.GetValue(@"" + path + @"KeywordTemplate")); } catch { KeywordTemplate = "";}
			try { Name = Data.UnescapeString(data.GetValue(@"" + path + @"Name")); } catch { Name = "NewProfile";}
			try { OpenViewer = bool.Parse(data.GetValue(@"" + path + @"OpenViewer")); } catch { OpenViewer = true;}
			try { OpenWithPdfArchitect = bool.Parse(data.GetValue(@"" + path + @"OpenWithPdfArchitect")); } catch { OpenWithPdfArchitect = true;}
			try { OutputFormat = (OutputFormat) Enum.Parse(typeof(OutputFormat), data.GetValue(@"" + path + @"OutputFormat")); } catch { OutputFormat = OutputFormat.Pdf;}
			try { ShowProgress = bool.Parse(data.GetValue(@"" + path + @"ShowProgress")); } catch { ShowProgress = true;}
			try { ShowQuickActions = bool.Parse(data.GetValue(@"" + path + @"ShowQuickActions")); } catch { ShowQuickActions = true;}
			try { SkipPrintDialog = bool.Parse(data.GetValue(@"" + path + @"SkipPrintDialog")); } catch { SkipPrintDialog = false;}
			try { SubjectTemplate = Data.UnescapeString(data.GetValue(@"" + path + @"SubjectTemplate")); } catch { SubjectTemplate = "";}
			try { TargetDirectory = Data.UnescapeString(data.GetValue(@"" + path + @"TargetDirectory")); } catch { TargetDirectory = "";}
			try { TitleTemplate = Data.UnescapeString(data.GetValue(@"" + path + @"TitleTemplate")); } catch { TitleTemplate = "<PrintJobName>";}
		}
		
		
		public void StoreValues(Data data, string path) {
			AttachmentPage.StoreValues(data, path + @"AttachmentPage\");
			AutoSave.StoreValues(data, path + @"AutoSave\");
			BackgroundPage.StoreValues(data, path + @"BackgroundPage\");
			CoverPage.StoreValues(data, path + @"CoverPage\");
			DropboxSettings.StoreValues(data, path + @"DropboxSettings\");
			EmailClientSettings.StoreValues(data, path + @"EmailClientSettings\");
			EmailSmtpSettings.StoreValues(data, path + @"EmailSmtpSettings\");
			Ftp.StoreValues(data, path + @"Ftp\");
			Ghostscript.StoreValues(data, path + @"Ghostscript\");
			HttpSettings.StoreValues(data, path + @"HttpSettings\");
			JpegSettings.StoreValues(data, path + @"JpegSettings\");
			PdfSettings.StoreValues(data, path + @"PdfSettings\");
			PngSettings.StoreValues(data, path + @"PngSettings\");
			Printing.StoreValues(data, path + @"Printing\");
			Properties.StoreValues(data, path + @"Properties\");
			SaveDialog.StoreValues(data, path + @"SaveDialog\");
			Scripting.StoreValues(data, path + @"Scripting\");
			Stamping.StoreValues(data, path + @"Stamping\");
			TextSettings.StoreValues(data, path + @"TextSettings\");
			TiffSettings.StoreValues(data, path + @"TiffSettings\");
			UserTokens.StoreValues(data, path + @"UserTokens\");
			data.SetValue(@"" + path + @"AuthorTemplate", Data.EscapeString(AuthorTemplate));
			data.SetValue(@"" + path + @"FileNameTemplate", Data.EscapeString(FileNameTemplate));
			data.SetValue(@"" + path + @"Guid", Data.EscapeString(Guid));
			data.SetValue(@"" + path + @"KeywordTemplate", Data.EscapeString(KeywordTemplate));
			data.SetValue(@"" + path + @"Name", Data.EscapeString(Name));
			data.SetValue(@"" + path + @"OpenViewer", OpenViewer.ToString());
			data.SetValue(@"" + path + @"OpenWithPdfArchitect", OpenWithPdfArchitect.ToString());
			data.SetValue(@"" + path + @"OutputFormat", OutputFormat.ToString());
			data.SetValue(@"" + path + @"ShowProgress", ShowProgress.ToString());
			data.SetValue(@"" + path + @"ShowQuickActions", ShowQuickActions.ToString());
			data.SetValue(@"" + path + @"SkipPrintDialog", SkipPrintDialog.ToString());
			data.SetValue(@"" + path + @"SubjectTemplate", Data.EscapeString(SubjectTemplate));
			data.SetValue(@"" + path + @"TargetDirectory", Data.EscapeString(TargetDirectory));
			data.SetValue(@"" + path + @"TitleTemplate", Data.EscapeString(TitleTemplate));
		}
		
		public ConversionProfile Copy()
		{
			ConversionProfile copy = new ConversionProfile();
			
			copy.AttachmentPage = AttachmentPage.Copy();
			copy.AutoSave = AutoSave.Copy();
			copy.BackgroundPage = BackgroundPage.Copy();
			copy.CoverPage = CoverPage.Copy();
			copy.DropboxSettings = DropboxSettings.Copy();
			copy.EmailClientSettings = EmailClientSettings.Copy();
			copy.EmailSmtpSettings = EmailSmtpSettings.Copy();
			copy.Ftp = Ftp.Copy();
			copy.Ghostscript = Ghostscript.Copy();
			copy.HttpSettings = HttpSettings.Copy();
			copy.JpegSettings = JpegSettings.Copy();
			copy.PdfSettings = PdfSettings.Copy();
			copy.PngSettings = PngSettings.Copy();
			copy.Printing = Printing.Copy();
			copy.Properties = Properties.Copy();
			copy.SaveDialog = SaveDialog.Copy();
			copy.Scripting = Scripting.Copy();
			copy.Stamping = Stamping.Copy();
			copy.TextSettings = TextSettings.Copy();
			copy.TiffSettings = TiffSettings.Copy();
			copy.UserTokens = UserTokens.Copy();
			copy.AuthorTemplate = AuthorTemplate;
			copy.FileNameTemplate = FileNameTemplate;
			copy.Guid = Guid;
			copy.KeywordTemplate = KeywordTemplate;
			copy.Name = Name;
			copy.OpenViewer = OpenViewer;
			copy.OpenWithPdfArchitect = OpenWithPdfArchitect;
			copy.OutputFormat = OutputFormat;
			copy.ShowProgress = ShowProgress;
			copy.ShowQuickActions = ShowQuickActions;
			copy.SkipPrintDialog = SkipPrintDialog;
			copy.SubjectTemplate = SubjectTemplate;
			copy.TargetDirectory = TargetDirectory;
			copy.TitleTemplate = TitleTemplate;
			
			return copy;
		}
		
		public override bool Equals(object o)
		{
			if (!(o is ConversionProfile)) return false;
			ConversionProfile v = o as ConversionProfile;
			
			if (!AttachmentPage.Equals(v.AttachmentPage)) return false;
			if (!AutoSave.Equals(v.AutoSave)) return false;
			if (!BackgroundPage.Equals(v.BackgroundPage)) return false;
			if (!CoverPage.Equals(v.CoverPage)) return false;
			if (!DropboxSettings.Equals(v.DropboxSettings)) return false;
			if (!EmailClientSettings.Equals(v.EmailClientSettings)) return false;
			if (!EmailSmtpSettings.Equals(v.EmailSmtpSettings)) return false;
			if (!Ftp.Equals(v.Ftp)) return false;
			if (!Ghostscript.Equals(v.Ghostscript)) return false;
			if (!HttpSettings.Equals(v.HttpSettings)) return false;
			if (!JpegSettings.Equals(v.JpegSettings)) return false;
			if (!PdfSettings.Equals(v.PdfSettings)) return false;
			if (!PngSettings.Equals(v.PngSettings)) return false;
			if (!Printing.Equals(v.Printing)) return false;
			if (!Properties.Equals(v.Properties)) return false;
			if (!SaveDialog.Equals(v.SaveDialog)) return false;
			if (!Scripting.Equals(v.Scripting)) return false;
			if (!Stamping.Equals(v.Stamping)) return false;
			if (!TextSettings.Equals(v.TextSettings)) return false;
			if (!TiffSettings.Equals(v.TiffSettings)) return false;
			if (!UserTokens.Equals(v.UserTokens)) return false;
			if (!AuthorTemplate.Equals(v.AuthorTemplate)) return false;
			if (!FileNameTemplate.Equals(v.FileNameTemplate)) return false;
			if (!Guid.Equals(v.Guid)) return false;
			if (!KeywordTemplate.Equals(v.KeywordTemplate)) return false;
			if (!Name.Equals(v.Name)) return false;
			if (!OpenViewer.Equals(v.OpenViewer)) return false;
			if (!OpenWithPdfArchitect.Equals(v.OpenWithPdfArchitect)) return false;
			if (!OutputFormat.Equals(v.OutputFormat)) return false;
			if (!ShowProgress.Equals(v.ShowProgress)) return false;
			if (!ShowQuickActions.Equals(v.ShowQuickActions)) return false;
			if (!SkipPrintDialog.Equals(v.SkipPrintDialog)) return false;
			if (!SubjectTemplate.Equals(v.SubjectTemplate)) return false;
			if (!TargetDirectory.Equals(v.TargetDirectory)) return false;
			if (!TitleTemplate.Equals(v.TitleTemplate)) return false;
			
			return true;
		}
		
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.AppendLine("[AttachmentPage]");
			sb.AppendLine(AttachmentPage.ToString());
			sb.AppendLine("[AutoSave]");
			sb.AppendLine(AutoSave.ToString());
			sb.AppendLine("[BackgroundPage]");
			sb.AppendLine(BackgroundPage.ToString());
			sb.AppendLine("[CoverPage]");
			sb.AppendLine(CoverPage.ToString());
			sb.AppendLine("[DropboxSettings]");
			sb.AppendLine(DropboxSettings.ToString());
			sb.AppendLine("[EmailClientSettings]");
			sb.AppendLine(EmailClientSettings.ToString());
			sb.AppendLine("[EmailSmtpSettings]");
			sb.AppendLine(EmailSmtpSettings.ToString());
			sb.AppendLine("[Ftp]");
			sb.AppendLine(Ftp.ToString());
			sb.AppendLine("[Ghostscript]");
			sb.AppendLine(Ghostscript.ToString());
			sb.AppendLine("[HttpSettings]");
			sb.AppendLine(HttpSettings.ToString());
			sb.AppendLine("[JpegSettings]");
			sb.AppendLine(JpegSettings.ToString());
			sb.AppendLine("[PdfSettings]");
			sb.AppendLine(PdfSettings.ToString());
			sb.AppendLine("[PngSettings]");
			sb.AppendLine(PngSettings.ToString());
			sb.AppendLine("[Printing]");
			sb.AppendLine(Printing.ToString());
			sb.AppendLine("[Properties]");
			sb.AppendLine(Properties.ToString());
			sb.AppendLine("[SaveDialog]");
			sb.AppendLine(SaveDialog.ToString());
			sb.AppendLine("[Scripting]");
			sb.AppendLine(Scripting.ToString());
			sb.AppendLine("[Stamping]");
			sb.AppendLine(Stamping.ToString());
			sb.AppendLine("[TextSettings]");
			sb.AppendLine(TextSettings.ToString());
			sb.AppendLine("[TiffSettings]");
			sb.AppendLine(TiffSettings.ToString());
			sb.AppendLine("[UserTokens]");
			sb.AppendLine(UserTokens.ToString());
			sb.AppendLine("AuthorTemplate=" + AuthorTemplate.ToString());
			sb.AppendLine("FileNameTemplate=" + FileNameTemplate.ToString());
			sb.AppendLine("Guid=" + Guid.ToString());
			sb.AppendLine("KeywordTemplate=" + KeywordTemplate.ToString());
			sb.AppendLine("Name=" + Name.ToString());
			sb.AppendLine("OpenViewer=" + OpenViewer.ToString());
			sb.AppendLine("OpenWithPdfArchitect=" + OpenWithPdfArchitect.ToString());
			sb.AppendLine("OutputFormat=" + OutputFormat.ToString());
			sb.AppendLine("ShowProgress=" + ShowProgress.ToString());
			sb.AppendLine("ShowQuickActions=" + ShowQuickActions.ToString());
			sb.AppendLine("SkipPrintDialog=" + SkipPrintDialog.ToString());
			sb.AppendLine("SubjectTemplate=" + SubjectTemplate.ToString());
			sb.AppendLine("TargetDirectory=" + TargetDirectory.ToString());
			sb.AppendLine("TitleTemplate=" + TitleTemplate.ToString());
			
			return sb.ToString();
		}
		
		public override int GetHashCode()
		{
			// ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
			return base.GetHashCode();
		}
		
// Custom Code starts here
// START_CUSTOM_SECTION:GENERAL

        public bool IsDefault
        {
            get { return Guid == ProfileGuids.DEFAULT_PROFILE_GUID; }
        }

// END_CUSTOM_SECTION:GENERAL
// Custom Code ends here. Do not edit below
		
	}
}
