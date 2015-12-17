//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRUSTLEVEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRUSTLEVEL()
        {
            this.ACCOUNT = new HashSet<ACCOUNT>();
            this.ACCOUNTAUTHENTICATIONTYPE = new HashSet<ACCOUNTAUTHENTICATIONTYPE>();
            this.ADDRESS = new HashSet<ADDRESS>();
            this.ALGORITHM = new HashSet<ALGORITHM>();
            this.ASSET = new HashSet<ASSET>();
            this.ASSETCREDENTIAL = new HashSet<ASSETCREDENTIAL>();
            this.ASSETDEVICE = new HashSet<ASSETDEVICE>();
            this.ASSETFORORGANISATION = new HashSet<ASSETFORORGANISATION>();
            this.ASSETNETWORKZONE = new HashSet<ASSETNETWORKZONE>();
            this.ASSETNETWORKZONERESTRICTION = new HashSet<ASSETNETWORKZONERESTRICTION>();
            this.ASSETSECURITYCONTROL = new HashSet<ASSETSECURITYCONTROL>();
            this.ATTACHMENT = new HashSet<ATTACHMENT>();
            this.AUTHENTICATIONTOKENPROTECTIONMECHANISM = new HashSet<AUTHENTICATIONTOKENPROTECTIONMECHANISM>();
            this.AUTHENTICATIONTYPE = new HashSet<AUTHENTICATIONTYPE>();
            this.CCE = new HashSet<CCE>();
            this.CERTIFICATION = new HashSet<CERTIFICATION>();
            this.CODE = new HashSet<CODE>();
            this.COLLECTIONMETHOD = new HashSet<COLLECTIONMETHOD>();
            this.COMPLIANCE = new HashSet<COMPLIANCE>();
            this.CONNECTIONFORASSET = new HashSet<CONNECTIONFORASSET>();
            this.CONTROLCATEGORY = new HashSet<CONTROLCATEGORY>();
            this.CPE = new HashSet<CPE>();
            this.CPEFORASSET = new HashSet<CPEFORASSET>();
            this.CREDENTIAL = new HashSet<CREDENTIAL>();
            this.CWEDETECTIONMETHOD = new HashSet<CWEDETECTIONMETHOD>();
            this.DEFENSETOOL = new HashSet<DEFENSETOOL>();
            this.DOMAINNAME = new HashSet<DOMAINNAME>();
            this.EMAILADDRESS = new HashSet<EMAILADDRESS>();
            this.EMAILFORORGANISATION = new HashSet<EMAILFORORGANISATION>();
            this.EMAILMESSAGE = new HashSet<EMAILMESSAGE>();
            this.EMAILMESSAGELINK = new HashSet<EMAILMESSAGELINK>();
            this.EMAILRECIPIENTSLIST = new HashSet<EMAILRECIPIENTSLIST>();
            this.ENCRYPTIONMECHANISM = new HashSet<ENCRYPTIONMECHANISM>();
            this.EVALUATIONMETHOD = new HashSet<EVALUATIONMETHOD>();
            this.EVIDENCE = new HashSet<EVIDENCE>();
            this.FILE = new HashSet<FILE>();
            this.FILEEXTENSION = new HashSet<FILEEXTENSION>();
            this.FILEREPOSITORY = new HashSet<FILEREPOSITORY>();
            this.FINDINGREFERENCE = new HashSet<FINDINGREFERENCE>();
            this.FIREWALLRULE = new HashSet<FIREWALLRULE>();
            this.HASHNAME = new HashSet<HASHNAME>();
            this.HTTPHEADER = new HashSet<HTTPHEADER>();
            this.HTTPREQUESTHEADERFIELDS = new HashSet<HTTPREQUESTHEADERFIELDS>();
            this.IMAGEFILETYPE = new HashSet<IMAGEFILETYPE>();
            this.LANGUAGEFUNCTION = new HashSet<LANGUAGEFUNCTION>();
            this.LINK = new HashSet<LINK>();
            this.MEASURESOURCE = new HashSet<MEASURESOURCE>();
            this.MECHANISM = new HashSet<MECHANISM>();
            this.METHODOLOGY = new HashSet<METHODOLOGY>();
            this.MITIGATIONSTRATEGY = new HashSet<MITIGATIONSTRATEGY>();
            this.NETWORKZONE = new HashSet<NETWORKZONE>();
            this.ORGANISATION = new HashSet<ORGANISATION>();
            this.OSPATCH = new HashSet<OSPATCH>();
            this.PATCH = new HashSet<PATCH>();
            this.PERMISSION = new HashSet<PERMISSION>();
            this.PERSON = new HashSet<PERSON>();
            this.PERSONDEVICE = new HashSet<PERSONDEVICE>();
            this.PERSONFORAPPLICATION = new HashSet<PERSONFORAPPLICATION>();
            this.PERSONFORASSET = new HashSet<PERSONFORASSET>();
            this.PERSONFORORGANISATION = new HashSet<PERSONFORORGANISATION>();
            this.PERSONFORPROJECT = new HashSet<PERSONFORPROJECT>();
            this.PERSONGROUP = new HashSet<PERSONGROUP>();
            this.PHYSICALLOCATION = new HashSet<PHYSICALLOCATION>();
            this.PROVIDER = new HashSet<PROVIDER>();
            this.REFERENCE = new HashSet<REFERENCE>();
            this.REFERENCE1 = new HashSet<REFERENCE>();
            this.REFERENCECATEGORY = new HashSet<REFERENCECATEGORY>();
            this.REGEX = new HashSet<REGEX>();
            this.REPOSITORY = new HashSet<REPOSITORY>();
            this.RISKRATING = new HashSet<RISKRATING>();
            this.SECURITYCONTROL = new HashSet<SECURITYCONTROL>();
            this.SECURITYMETRIC = new HashSet<SECURITYMETRIC>();
            this.SECURITYPRINCIPLE = new HashSet<SECURITYPRINCIPLE>();
            this.SENSOR = new HashSet<SENSOR>();
            this.SIGNATUREEXPLOIT = new HashSet<SIGNATUREEXPLOIT>();
            this.STAGE = new HashSet<STAGE>();
            this.STRUCTUREDAUTHENTICATIONMECHANISM = new HashSet<STRUCTUREDAUTHENTICATIONMECHANISM>();
            this.TAG = new HashSet<TAG>();
            this.TASK = new HashSet<TASK>();
            this.TECHNIQUE = new HashSet<TECHNIQUE>();
            this.TECHNIQUEREFERENCE = new HashSet<TECHNIQUEREFERENCE>();
            this.TECHNIQUEREFERENCETAG = new HashSet<TECHNIQUEREFERENCETAG>();
            this.TELEPHONE = new HashSet<TELEPHONE>();
            this.TOOL = new HashSet<TOOL>();
            this.TOOLINFORMATIONREFERENCE = new HashSet<TOOLINFORMATIONREFERENCE>();
            this.TOOLREFERENCE = new HashSet<TOOLREFERENCE>();
            this.VOCABULARY1 = new HashSet<VOCABULARY>();
            this.VOCABULARYTAG = new HashSet<VOCABULARYTAG>();
            this.X509CERTIFICATE = new HashSet<X509CERTIFICATE>();
            this.X509CERTIFICATEOBJECT = new HashSet<X509CERTIFICATEOBJECT>();
            this.X509SIGNATURE = new HashSet<X509SIGNATURE>();
            this.ZONE = new HashSet<ZONE>();
        }
    
        public int TrustLevelID { get; set; }
        public string TrustLevelGUID { get; set; }
        public string TrustLevelName { get; set; }
        public string TrustLevelDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNTAUTHENTICATIONTYPE> ACCOUNTAUTHENTICATIONTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADDRESS> ADDRESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALGORITHM> ALGORITHM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSET> ASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETCREDENTIAL> ASSETCREDENTIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETDEVICE> ASSETDEVICE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETFORORGANISATION> ASSETFORORGANISATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETNETWORKZONE> ASSETNETWORKZONE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETNETWORKZONERESTRICTION> ASSETNETWORKZONERESTRICTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETSECURITYCONTROL> ASSETSECURITYCONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACHMENT> ATTACHMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTHENTICATIONTOKENPROTECTIONMECHANISM> AUTHENTICATIONTOKENPROTECTIONMECHANISM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTHENTICATIONTYPE> AUTHENTICATIONTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCE> CCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CERTIFICATION> CERTIFICATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CODE> CODE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLLECTIONMETHOD> COLLECTIONMETHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPLIANCE> COMPLIANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONNECTIONFORASSET> CONNECTIONFORASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTROLCATEGORY> CONTROLCATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPE> CPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPEFORASSET> CPEFORASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CREDENTIAL> CREDENTIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CWEDETECTIONMETHOD> CWEDETECTIONMETHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEFENSETOOL> DEFENSETOOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOMAINNAME> DOMAINNAME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAILADDRESS> EMAILADDRESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAILFORORGANISATION> EMAILFORORGANISATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAILMESSAGE> EMAILMESSAGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAILMESSAGELINK> EMAILMESSAGELINK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAILRECIPIENTSLIST> EMAILRECIPIENTSLIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENCRYPTIONMECHANISM> ENCRYPTIONMECHANISM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVALUATIONMETHOD> EVALUATIONMETHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVIDENCE> EVIDENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILE> FILE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILEEXTENSION> FILEEXTENSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILEREPOSITORY> FILEREPOSITORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINDINGREFERENCE> FINDINGREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIREWALLRULE> FIREWALLRULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HASHNAME> HASHNAME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTTPHEADER> HTTPHEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTTPREQUESTHEADERFIELDS> HTTPREQUESTHEADERFIELDS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMAGEFILETYPE> IMAGEFILETYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LANGUAGEFUNCTION> LANGUAGEFUNCTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINK> LINK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEASURESOURCE> MEASURESOURCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MECHANISM> MECHANISM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METHODOLOGY> METHODOLOGY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MITIGATIONSTRATEGY> MITIGATIONSTRATEGY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NETWORKZONE> NETWORKZONE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORGANISATION> ORGANISATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OSPATCH> OSPATCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATCH> PATCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERMISSION> PERMISSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSON> PERSON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONDEVICE> PERSONDEVICE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONFORAPPLICATION> PERSONFORAPPLICATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONFORASSET> PERSONFORASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONFORORGANISATION> PERSONFORORGANISATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONFORPROJECT> PERSONFORPROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONGROUP> PERSONGROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHYSICALLOCATION> PHYSICALLOCATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVIDER> PROVIDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFERENCE> REFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFERENCE> REFERENCE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFERENCECATEGORY> REFERENCECATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGEX> REGEX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPOSITORY> REPOSITORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISKRATING> RISKRATING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYCONTROL> SECURITYCONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYMETRIC> SECURITYMETRIC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYPRINCIPLE> SECURITYPRINCIPLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SENSOR> SENSOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIGNATUREEXPLOIT> SIGNATUREEXPLOIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STAGE> STAGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREDAUTHENTICATIONMECHANISM> STRUCTUREDAUTHENTICATIONMECHANISM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAG> TAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK> TASK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TECHNIQUE> TECHNIQUE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TECHNIQUEREFERENCE> TECHNIQUEREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TECHNIQUEREFERENCETAG> TECHNIQUEREFERENCETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEPHONE> TELEPHONE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOOL> TOOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOOLINFORMATIONREFERENCE> TOOLINFORMATIONREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOOLREFERENCE> TOOLREFERENCE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOCABULARY> VOCABULARY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOCABULARYTAG> VOCABULARYTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<X509CERTIFICATE> X509CERTIFICATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<X509CERTIFICATEOBJECT> X509CERTIFICATEOBJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<X509SIGNATURE> X509SIGNATURE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZONE> ZONE { get; set; }
    }
}