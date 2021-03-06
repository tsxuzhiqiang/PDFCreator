using pdfforge.DataStorage.Storage;
using pdfforge.DataStorage;
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
	public partial class SmtpAccount : INotifyPropertyChanged {
		#pragma warning disable 67
		public event PropertyChangedEventHandler PropertyChanged;
		#pragma warning restore 67
		
		
		public string AccountId { get; set; } = "";
		
		/// <summary>
		/// E-mail address that is displayed as sender
		/// </summary>
		public string Address { get; set; } = "";
		
		/// <summary>
		/// Password that is used to authenticate at the server
		/// </summary>
		private string _password = "";
		public string Password { get { try { return Data.Decrypt(_password); } catch { return ""; } } set { _password = Data.Encrypt(value); } }
		
		/// <summary>
		/// SMTP server port
		/// </summary>
		public int Port { get; set; } = 25;
		
		/// <summary>
		/// Hostname or IP address of the SMTP server
		/// </summary>
		public string Server { get; set; } = "";
		
		/// <summary>
		/// If true, the connection will be encrypted with SSL (must be supported by the server)
		/// </summary>
		public bool Ssl { get; set; } = false;
		
		/// <summary>
		/// User name that is used to authenticate at the server
		/// </summary>
		public string UserName { get; set; } = "";
		
		
		public void ReadValues(Data data, string path) {
			try { AccountId = Data.UnescapeString(data.GetValue(@"" + path + @"AccountId")); } catch { AccountId = "";}
			try { Address = Data.UnescapeString(data.GetValue(@"" + path + @"Address")); } catch { Address = "";}
			_password = data.GetValue(@"" + path + @"Password");
			try { Port = int.Parse(data.GetValue(@"" + path + @"Port"), System.Globalization.CultureInfo.InvariantCulture); } catch { Port = 25;}
			try { Server = Data.UnescapeString(data.GetValue(@"" + path + @"Server")); } catch { Server = "";}
			try { Ssl = bool.Parse(data.GetValue(@"" + path + @"Ssl")); } catch { Ssl = false;}
			try { UserName = Data.UnescapeString(data.GetValue(@"" + path + @"UserName")); } catch { UserName = "";}
		}
		
		
		public void StoreValues(Data data, string path) {
			data.SetValue(@"" + path + @"AccountId", Data.EscapeString(AccountId));
			data.SetValue(@"" + path + @"Address", Data.EscapeString(Address));
			data.SetValue(@"" + path + @"Password", _password);
			data.SetValue(@"" + path + @"Port", Port.ToString(System.Globalization.CultureInfo.InvariantCulture));
			data.SetValue(@"" + path + @"Server", Data.EscapeString(Server));
			data.SetValue(@"" + path + @"Ssl", Ssl.ToString());
			data.SetValue(@"" + path + @"UserName", Data.EscapeString(UserName));
		}
		
		public SmtpAccount Copy()
		{
			SmtpAccount copy = new SmtpAccount();
			
			copy.AccountId = AccountId;
			copy.Address = Address;
			copy.Password = Password;
			copy.Port = Port;
			copy.Server = Server;
			copy.Ssl = Ssl;
			copy.UserName = UserName;
			
			return copy;
		}
		
		public override bool Equals(object o)
		{
			if (!(o is SmtpAccount)) return false;
			SmtpAccount v = o as SmtpAccount;
			
			if (!AccountId.Equals(v.AccountId)) return false;
			if (!Address.Equals(v.Address)) return false;
			if (!Password.Equals(v.Password)) return false;
			if (!Port.Equals(v.Port)) return false;
			if (!Server.Equals(v.Server)) return false;
			if (!Ssl.Equals(v.Ssl)) return false;
			if (!UserName.Equals(v.UserName)) return false;
			
			return true;
		}
		
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.AppendLine("AccountId=" + AccountId.ToString());
			sb.AppendLine("Address=" + Address.ToString());
			sb.AppendLine("Password=" + Password.ToString());
			sb.AppendLine("Port=" + Port.ToString());
			sb.AppendLine("Server=" + Server.ToString());
			sb.AppendLine("Ssl=" + Ssl.ToString());
			sb.AppendLine("UserName=" + UserName.ToString());
			
			return sb.ToString();
		}
		
		public override int GetHashCode()
		{
			// ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
			return base.GetHashCode();
		}
		
// Custom Code starts here
// START_CUSTOM_SECTION:GENERAL
// END_CUSTOM_SECTION:GENERAL
// Custom Code ends here. Do not edit below
		
	}
}
