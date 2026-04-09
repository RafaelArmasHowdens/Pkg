namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("567f920f-a35f-425a-aea6-375fe19ca473");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e8cc8f7-fb39-4b6e-ba7f-1487c36616fd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,93,107,219,48,20,125,47,244,63,92,252,100,67,16,235,235,186,21,150,44,27,133,178,141,217,41,140,177,7,69,190,113,52,244,97,36,57,93,54,250,223,119,37,37,105,106,119,176,3,198,150,238,209,209,61,199,215,112,141,190,231,2,161,65,231,184,183,155,192,22,214,108,100,55,56,30,164,53,151,23,127,46,47,128,48,120,105,58,168,247,62,160,190,62,223,58,63,168,181,53,255,44,58,100,75,19,100,144,232,255,135,195,150,59,52,33,82,51,249,123,42,236,211,238,157,164,54,12,186,178,22,91,212,252,19,185,128,183,80,172,188,251,198,197,54,20,213,143,124,166,31,214,74,10,16,138,123,15,169,244,130,8,188,134,57,247,248,66,37,139,28,2,56,211,179,59,106,89,182,8,59,43,91,248,108,106,190,35,35,165,93,255,68,17,192,163,105,209,205,32,11,206,113,67,174,146,236,59,215,121,192,234,73,238,76,57,98,77,93,176,147,218,81,6,171,235,231,180,172,11,251,104,135,92,151,121,93,101,254,136,219,162,144,154,43,232,157,20,49,162,116,136,125,196,208,236,123,108,23,86,13,218,220,115,53,224,155,3,243,166,140,41,126,137,244,162,58,101,127,132,220,64,153,165,110,224,234,85,66,245,156,49,178,20,129,236,214,47,184,17,168,176,165,22,130,27,112,34,28,225,131,139,227,64,3,233,121,135,13,234,94,241,16,155,54,248,0,119,86,112,37,127,243,181,194,58,241,202,108,101,229,209,209,192,26,10,158,166,149,125,69,111,7,39,136,99,29,137,204,166,183,68,156,6,37,143,88,49,131,98,162,239,89,202,229,214,55,214,206,101,151,87,69,197,26,123,184,127,154,206,212,4,53,159,55,216,7,235,52,15,229,200,28,93,124,5,20,98,122,86,245,251,98,252,175,35,194,214,217,135,20,194,242,151,192,62,250,60,234,140,233,143,79,203,195,39,189,30,255,2,219,17,49,127,229,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5dd1ed6d-dbda-dcca-a683-84c6eb0022fc"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("5e8cc8f7-fb39-4b6e-ba7f-1487c36616fd"),
				CreatedInSchemaUId = new Guid("567f920f-a35f-425a-aea6-375fe19ca473"),
				ModifiedInSchemaUId = new Guid("567f920f-a35f-425a-aea6-375fe19ca473")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("567f920f-a35f-425a-aea6-375fe19ca473"));
		}

		#endregion

	}

	#endregion

}

