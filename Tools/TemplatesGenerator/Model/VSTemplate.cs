using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.ToolTrigger.TemplatesGenerator.Model
{



    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005", IsNullable = false)]
    public partial class VSTemplate
    {

        private VSTemplateTemplateData templateDataField;

        private VSTemplateTemplateContent templateContentField;

        private string versionField;

        private string typeField;

        /// <remarks/>
        public VSTemplateTemplateData TemplateData
        {
            get
            {
                return this.templateDataField;
            }
            set
            {
                this.templateDataField = value;
            }
        }

        /// <remarks/>
        public VSTemplateTemplateContent TemplateContent
        {
            get
            {
                return this.templateContentField;
            }
            set
            {
                this.templateContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateData
    {

        private string nameField;

        private string descriptionField;

        private string projectTypeField;

        private object projectSubTypeField;

        private ushort sortOrderField;

        private bool createNewFolderField;

        private string defaultNameField;

        private bool provideDefaultNameField;

        private string locationFieldField;

        private bool enableLocationBrowseButtonField;

        private bool createInPlaceField;

        private string iconField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string ProjectType
        {
            get
            {
                return this.projectTypeField;
            }
            set
            {
                this.projectTypeField = value;
            }
        }

        /// <remarks/>
        public object ProjectSubType
        {
            get
            {
                return this.projectSubTypeField;
            }
            set
            {
                this.projectSubTypeField = value;
            }
        }

        /// <remarks/>
        public ushort SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }

        /// <remarks/>
        public bool CreateNewFolder
        {
            get
            {
                return this.createNewFolderField;
            }
            set
            {
                this.createNewFolderField = value;
            }
        }

        /// <remarks/>
        public string DefaultName
        {
            get
            {
                return this.defaultNameField;
            }
            set
            {
                this.defaultNameField = value;
            }
        }

        /// <remarks/>
        public bool ProvideDefaultName
        {
            get
            {
                return this.provideDefaultNameField;
            }
            set
            {
                this.provideDefaultNameField = value;
            }
        }

        /// <remarks/>
        public string LocationField
        {
            get
            {
                return this.locationFieldField;
            }
            set
            {
                this.locationFieldField = value;
            }
        }

        /// <remarks/>
        public bool EnableLocationBrowseButton
        {
            get
            {
                return this.enableLocationBrowseButtonField;
            }
            set
            {
                this.enableLocationBrowseButtonField = value;
            }
        }

        /// <remarks/>
        public bool CreateInPlace
        {
            get
            {
                return this.createInPlaceField;
            }
            set
            {
                this.createInPlaceField = value;
            }
        }

        /// <remarks/>
        public string Icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContent
    {

        private VSTemplateTemplateContentProject projectField;

        private VSTemplateTemplateContentProjectCollection[] projectCollectionField;

        /// <remarks/>
        public VSTemplateTemplateContentProject Project
        {
            get
            {
                return this.projectField;
            }
            set
            {
                this.projectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProjectCollection")]
        public VSTemplateTemplateContentProjectCollection[] ProjectCollection
        {
            get
            {
                return this.projectCollectionField;
            }
            set
            {
                this.projectCollectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProject
    {

        private VSTemplateTemplateContentProjectFolder[] folderField;

        private VSTemplateTemplateContentProjectProjectItem[] projectItemField;

        private string targetFileNameField;

        private string fileField;

        private bool replaceParametersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Folder")]
        public VSTemplateTemplateContentProjectFolder[] Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProjectItem")]
        public VSTemplateTemplateContentProjectProjectItem[] ProjectItem
        {
            get
            {
                return this.projectItemField;
            }
            set
            {
                this.projectItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFileName
        {
            get
            {
                return this.targetFileNameField;
            }
            set
            {
                this.targetFileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReplaceParameters
        {
            get
            {
                return this.replaceParametersField;
            }
            set
            {
                this.replaceParametersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectFolder
    {

        private VSTemplateTemplateContentProjectFolderFolder folderField;

        private VSTemplateTemplateContentProjectFolderProjectItem[] projectItemField;

        private string nameField;

        private string targetFolderNameField;

        /// <remarks/>
        public VSTemplateTemplateContentProjectFolderFolder Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }

        /// <remarks/>
        public VSTemplateTemplateContentProjectFolderProjectItem[] ProjectItem
        {
            get
            {
                return this.projectItemField;
            }
            set
            {
                this.projectItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFolderName
        {
            get
            {
                return this.targetFolderNameField;
            }
            set
            {
                this.targetFolderNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectFolderFolder
    {

        private VSTemplateTemplateContentProjectFolderFolderFolder folderField;

        private VSTemplateTemplateContentProjectFolderFolderProjectItem projectItemField;

        private string nameField;

        private string targetFolderNameField;

        /// <remarks/>
        public VSTemplateTemplateContentProjectFolderFolderFolder Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }

        /// <remarks/>
        public VSTemplateTemplateContentProjectFolderFolderProjectItem ProjectItem
        {
            get
            {
                return this.projectItemField;
            }
            set
            {
                this.projectItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFolderName
        {
            get
            {
                return this.targetFolderNameField;
            }
            set
            {
                this.targetFolderNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectFolderFolderFolder
    {

        private VSTemplateTemplateContentProjectFolderFolderFolderProjectItem[] projectItemField;

        private string nameField;

        private string targetFolderNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProjectItem")]
        public VSTemplateTemplateContentProjectFolderFolderFolderProjectItem[] ProjectItem
        {
            get
            {
                return this.projectItemField;
            }
            set
            {
                this.projectItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFolderName
        {
            get
            {
                return this.targetFolderNameField;
            }
            set
            {
                this.targetFolderNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectFolderFolderFolderProjectItem
    {

        private bool replaceParametersField;

        private string targetFileNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReplaceParameters
        {
            get
            {
                return this.replaceParametersField;
            }
            set
            {
                this.replaceParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFileName
        {
            get
            {
                return this.targetFileNameField;
            }
            set
            {
                this.targetFileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectFolderFolderProjectItem
    {

        private bool replaceParametersField;

        private string targetFileNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReplaceParameters
        {
            get
            {
                return this.replaceParametersField;
            }
            set
            {
                this.replaceParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFileName
        {
            get
            {
                return this.targetFileNameField;
            }
            set
            {
                this.targetFileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectFolderProjectItem
    {

        private bool replaceParametersField;

        private string targetFileNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReplaceParameters
        {
            get
            {
                return this.replaceParametersField;
            }
            set
            {
                this.replaceParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFileName
        {
            get
            {
                return this.targetFileNameField;
            }
            set
            {
                this.targetFileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectProjectItem
    {

        private bool replaceParametersField;

        private string targetFileNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReplaceParameters
        {
            get
            {
                return this.replaceParametersField;
            }
            set
            {
                this.replaceParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFileName
        {
            get
            {
                return this.targetFileNameField;
            }
            set
            {
                this.targetFileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectCollection
    {

        private VSTemplateTemplateContentProjectCollectionSolutionFolder[] solutionFolderField;

        private VSTemplateTemplateContentProjectCollectionProjectTemplateLink[] projectTemplateLinkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SolutionFolder")]
        public VSTemplateTemplateContentProjectCollectionSolutionFolder[] SolutionFolder
        {
            get
            {
                return this.solutionFolderField;
            }
            set
            {
                this.solutionFolderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProjectTemplateLink")]
        public VSTemplateTemplateContentProjectCollectionProjectTemplateLink[] ProjectTemplateLink
        {
            get
            {
                return this.projectTemplateLinkField;
            }
            set
            {
                this.projectTemplateLinkField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectCollectionSolutionFolder
    {

        private VSTemplateTemplateContentProjectCollectionSolutionFolderProjectTemplateLink[] projectTemplateLinkField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProjectTemplateLink")]
        public VSTemplateTemplateContentProjectCollectionSolutionFolderProjectTemplateLink[] ProjectTemplateLink
        {
            get
            {
                return this.projectTemplateLinkField;
            }
            set
            {
                this.projectTemplateLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectCollectionSolutionFolderProjectTemplateLink
    {

        private string projectNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProjectName
        {
            get
            {
                return this.projectNameField;
            }
            set
            {
                this.projectNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005")]
    public partial class VSTemplateTemplateContentProjectCollectionProjectTemplateLink
    {

        private string projectNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProjectName
        {
            get
            {
                return this.projectNameField;
            }
            set
            {
                this.projectNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }



}
