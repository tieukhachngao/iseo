namespace iSEO
{
    using iSEO.iSEOService;
    using iSEO.Properties;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Web;
    using System.Windows.Forms;
    using System.Xml;
    using System.Xml.Linq;

    public class frmMain : Form
    {
        private const string string_0 = "<RSAKeyValue><Modulus>wFEjE5yiTXL3r8n9QQvpXgSbuOYwGQXxFpBZrLQct8ENPUIPhxr/ywSjMj3UfUWow75tvE7ccIZN+DroPNDcIrr596PO2ztOVRxuPaikTpC1H0xldvpR3p3sLpfH+e9NMXS40ACh11irux5JTx1qbNiriucrT2BASPuNR2dmC4s=</Modulus><Exponent>AQAB</Exponent><P>/vvf9WSuOYwCfhd24ymEDBPzu28spX0Jq6UxeYVEa1EBWIRgjUCs3TuSluYSlJ7uShAhUTyZwdvuDbbCpl9Rbw==</P><Q>wRVU6INfs/198fjA2TusUg/QtFq8VmqJpTAUmPsqDanJlecW1g4CwHKzX1+KAWgkjBke3LVPHW/p3t0PNtzhpQ==</Q><DP>0kmlxXrYGQu4DoeJfAUEKvXVgBJLDtxVOmMNr3vSFnODGZ5rBnN9XSNBXQO39Swxt5Ef+SByaifYZyT/2TgpLw==</DP><DQ>a4/TnjfZb66Oo+a8oAezJn/y9xX5B3cQOPrA7rw0oCnux9hVi2eAtu7u5/mUKtZ2TamM3M0QRsjakzG40QpZlQ==</DQ><InverseQ>pAOfuf0RikJ1vIyTIfGBVTP9vxl6DNavbqd/0g7UCz38bH/qeEmhdZhCSlUFswG95do6snWexpobyLsmoEeYpg==</InverseQ><D>gX7g0Jbazq3ITC0Fg6QiqnUN6cIRJvhSQzBFwb2xzKWIZaRC+31ZmflwbicmCog6QDvaoRu04Wv92lTIBhNY9jgdPPGHHNzt2YqK8RAH3CyOpZEAiVczearZ7w23hBfTGkf6kt20nX8Spa2g97ikVHp2Axy/ot7YObysitHSpXk=</D></RSAKeyValue>";
        private const string string_1 = "<RSAKeyValue><Modulus>keuFw++iHf6aXfHGpvEJ9ReFx2GTmbppEk2YehoUMU8W3zAjk8BkpM2e+t6Fk9fDv+skvr/j2q+SjjKUvK1rXAEYLVt56SHE1PD8UxP8QP0N/vQd2eddEqp1BBqynLp1c8EWze7nI9NSfMQSHghZZVI6WjhZmbzw/JWMULBtbKs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private bool bool_0;
        private Point point_0;
        public static List<string> list_0;
        private InfoSEO infoSEO_0;
        private GClass4 gclass4_0 = new GClass4();
        private string string_2;
        private iSEOSoapClient iSEOSoapClient_0 = new iSEOSoapClient();
        private List<Class5> list_1;
        private int int_0;
        private GClass18 gclass18_0 = new GClass18();
        private IntPtr intptr_0 = GetCurrentProcess();
        private int int_1;
        private List<Class7> list_2;
        private List<Class11> list_3;
        private List<Class11> list_4;
        private int int_2;
        private int int_3;
        private string string_3;
        private string[] string_4;
        private int int_4;
        private int int_5;
        private List<string> list_5;
        private List<string> list_6;
        private bool bool_1;
        private List<Class14> list_7;
        private int int_6;
        private int int_7;
        private bool bool_2;
        private bool bool_3;
        private int int_8;
        private int int_9;
        private List<GClass9> list_8;
        private int int_10;
        private int int_11;
        private List<Class15> list_9;
        private int int_12;
        private int int_13;
        private bool bool_4;
        private List<Class16> list_10;
        private bool bool_5;
        private bool bool_6;
        private List<Class17> list_11;
        private GClass15 gclass15_0;
        private int int_14;
        private int int_15;
        private List<Class18> list_12;
        private List<string> list_13;
        private int int_16;
        private string string_5;
        private bool bool_7;
        private WebBrowser webBrowser_0;
        private List<GClass13> list_14;
        private int int_17;
        private string string_6;
        private int int_18;
        private int int_19;
        private List<GClass5> list_15;
        private int int_20;
        private bool bool_8;
        private IContainer icontainer_0;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolBar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton btnClose;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private TabPage tbSeoTool;
        private GroupBox groupBox3;
        private TabPage tbPingURL;
        private GroupBox groupBox2;
        private TabPage tbKeyword;
        private WebBrowser webMain;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnCheck;
        private TextBox txtKeyword;
        private TextBox txtDomain;
        private Label label3;
        private TextBox txtLang;
        private Label label2;
        private Label label8;
        private TextBox txtWebsiteCheck;
        private Button btnCheckIndex;
        private Button btnCheckPlus;
        private TabPage tbSocial;
        private GroupBox groupBox5;
        private Label label13;
        private Label label17;
        private ToolStripButton btnExit;
        private PictureBox picLoader;
        private Button btnOpenLink;
        private TabPage tbWebAnalytics;
        private GroupBox groupBox10;
        private TextBox txtWebsiteUrl;
        private Button btnAnalytics;
        private ToolStripButton btnHide;
        private TabPage tbArticle;
        private Label label23;
        private TextBox txtKeywordAnalytics;
        private Label label24;
        private PictureBox btnSaveCheck;
        private PictureBox btnSaveAnalytics;
        private PictureBox btnSavePosition;
        private TabPage tbKeyResearch;
        private GroupBox groupBox13;
        private Button btnSuggest;
        private Label label4;
        private TextBox txtKeyResearch;
        private Label label26;
        private TextBox txtLangSuggest;
        private TextBox txtKeyFilter;
        private Label label29;
        private Button btnKeyFilter;
        private GroupBox groupBox14;
        private GroupBox groupBox15;
        private DataGridView dtvTags;
        private Label lbSuggestTotal;
        private Label lbTagsTotal;
        private ContextMenuStrip mnuSuggest;
        private ToolStripMenuItem mbtnSearch;
        private ToolStripMenuItem mbtnResearch;
        private ToolStripMenuItem mbtnInsights;
        private Label label27;
        private ToolStripMenuItem mbtnTopGoogle;
        private Button btnOptimize;
        private PictureBox btnSaveSuggest;
        private GClass23 dtvSuggest;
        private Button btnPing;
        private GroupBox groupBox16;
        private Timer timer_0;
        private TextBox txtPingTitle;
        private Label label31;
        private ListBox listSocial;
        private TabPage tbRival;
        private GroupBox groupBox9;
        private TabControl tbMain;
        private ToolStripLabel toolStripLabel3;
        private GroupBox groupBox19;
        private WebBrowser webKeyRelated;
        private GroupBox groupBox20;
        private RichTextBox richTextBox_0;
        private Button btnCheckPR;
        private GroupBox groupBox21;
        private ComboBox cbSEOOther;
        private ComboBox cbGoogleTool;
        private GroupBox groupBox22;
        private ToolStripButton btnInfo;
        private Button btnSocialSend;
        private TabControl tabSocial;
        private PictureBox btnSocialClose;
        private Button btnKeyAdd;
        private ComboBox cbKeyCate;
        private Label label19;
        private PictureBox btnKeyCateAdd;
        private DataGridView dtvKeyLogs;
        private ContextMenuStrip mnuKey;
        private ToolStripMenuItem btnKeyCheck;
        private ToolStripMenuItem btnKeyDelete;
        private Panel panel1;
        private Label label21;
        private Label lbAnalyticsAnchor;
        private DataGridView dtvAnalyticsLink;
        private TabPage tbBacklink;
        private GroupBox groupBox8;
        private Label label34;
        private DataGridView dtvBacklinkCate;
        private TextBox txtBacklinkCate;
        private GroupBox groupBox11;
        private PictureBox btnBacklinkEdit;
        private PictureBox btnBacklinkAdd;
        private DataGridView dtvBacklink;
        private TextBox txtBacklinkWeblink;
        private DataGridViewTextBoxColumn CateID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label35;
        private TextBox txtBacklinkUrl;
        private Button btnBacklinkCheck;
        private PictureBox btnBacklinkDelete;
        private GroupBox groupBox12;
        private PictureBox btnArticleDelete;
        private PictureBox btnArticleEdit;
        private Label label40;
        private PictureBox btnArticleAdd;
        private DataGridView dtvArticle;
        private TextBox txtArticleLink;
        private GroupBox groupBox23;
        private PictureBox btnArticleCateAdd;
        private DataGridView dtvArticleCate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private TextBox txtArticleCate;
        private Label label42;
        private DataGridView dtvAnalyticsHeading;
        private Label lbAnalyticsHeading;
        private DataGridView dtvAnalyticsImage;
        private Label lbAnalyticsImage;
        private Button btnKeyCheckAll;
        private DataGridView dtvAnalyticsWord1;
        private Label label44;
        private DataGridView dtvAnalyticsWord4;
        private DataGridView dtvAnalyticsWord3;
        private DataGridView dtvAnalyticsWord2;
        private Label label47;
        private Label label46;
        private Label label45;
        private Label label48;
        private RichTextBox txtAnalyticsHTML;
        private Button btnCheckError;
        private CheckBox ckAnchorImage;
        private CheckBox ckAnchorError;
        private CheckBox ckAnchorExternal;
        private CheckBox ckAnchorTitle;
        private CheckBox ckAnchorNofollow;
        private RadioButton radioURL2;
        private RadioButton radioURL1;
        private TextBox txtWebsiteUrl2;
        private TextBox txtExt;
        private Label label20;
        private TextBox txtExtSuggest;
        private Label label22;
        private DataGridViewTextBoxColumn Key2;
        private DataGridViewTextBoxColumn Loop2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn KeyKey1;
        private DataGridViewTextBoxColumn KeyDensity1;
        private DataGridViewTextBoxColumn KeyLoop1;
        private DataGridViewTextBoxColumn BacklinkID;
        private DataGridViewTextBoxColumn BacklinkName;
        private DataGridViewTextBoxColumn BacklinkTitle;
        private DataGridViewLinkColumn BacklinkUrl;
        private DataGridViewLinkColumn BacklinkWebsite;
        private DataGridViewTextBoxColumn BacklinkPR;
        private DataGridViewTextBoxColumn BacklinkRel;
        private DataGridViewTextBoxColumn BacklinkDensity;
        private DataGridViewTextBoxColumn BacklinkIndex;
        private DataGridView dtvRivalTop;
        private TextBox txtRivalDomain;
        private Button btnRivalCheck;
        private Label Domain;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridView dtvRivalMonth2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dtvRivalMonth1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label36;
        private Label label33;
        private Label label25;
        private DataGridView dtvRivalList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn Column1;
        private Label label37;
        private DataGridView dtvRivalHigh;
        private Label label38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private ComboBox cbDepthKey;
        private Label label9;
        private Button btnUpdateProxy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn AnalyticsName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewLinkColumn AnalyticsUrl;
        private DataGridViewTextBoxColumn AnalyticsTitle;
        private DataGridViewTextBoxColumn AnalyticsRel;
        private DataGridViewTextBoxColumn Analytics404;
        private DataGridViewTextBoxColumn AnalyticsType;
        private DataGridViewTextBoxColumn AnalyticsImg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn ImageAlt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewLinkColumn dataGridViewLinkColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private Button btnAnalyticsCompare;
        private TextBox txtPingProxy;
        private Label label12;
        private Label label50;
        private Label label5;
        private Button btnArticleCheck;
        private ContextMenuStrip mnuArticle;
        private ToolStripMenuItem btnArticleOpenChange;
        private ToolStripMenuItem btnArticleOpenAll;
        private Timer timer_1;
        private Button btnArticleRefresh;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewLinkColumn ArticleLink;
        private DataGridViewImageColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewCheckBoxColumn ArticleAuthor;
        private NotifyIcon notifyIcon_0;
        private ContextMenuStrip mnuHide;
        private ToolStripMenuItem btnNotiShow;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem btnNotiExit;
        private ToolStripMenuItem btnArticleRemove;
        private ToolStripMenuItem btnArticleCheckOne;
        private ComboBox cbWebReport;
        private Button btnCheckWeb;
        private TextBox txtWebReport;
        private GroupBox groupBox4;
        private Label label10;
        private PictureBox btnArticleSearch;
        private PictureBox btnBacklinkCateSearch;
        private PictureBox btnArticleCateSearch;
        private PictureBox btnBacklinkSearch;
        private TabPage tbSubmit;
        private GroupBox groupBox6;
        private Label lbnhom;
        private PictureBox txtSubmitAdd;
        private ComboBox cbAttributeCate;
        private PictureBox btnSubmitAttribute;
        private PictureBox btnSubmitSearch;
        private PictureBox btnSubmitDelete;
        private PictureBox btnSubmitEdit;
        private PictureBox btnSubmitAdd;
        private Button btnSubmitOK;
        private TextBox txtSubmitAddress;
        private TabPage tbCheckBacklink;
        private GroupBox groupBox26;
        private Label label64;
        private DataGridView dtvCheckBacklink;
        private Button btnCheckBLOK;
        private TextBox txtCheckBLUrl;
        private GroupBox groupBox27;
        private Button btnCheckGoogleIndex;
        private Label label65;
        private Label label63;
        private TextBox txtCheckIndexUrl;
        private TextBox txtCheckIndexKey;
        private TabPage tbAdword;
        private GroupBox groupBox28;
        private PictureBox btnAdwordSearch;
        private Button btnAdwordCheck;
        private PictureBox btnAdwordDelete;
        private PictureBox btnAdwordEdit;
        private PictureBox btnAdwordAdd;
        private DataGridView dtvAdword;
        private GroupBox groupBox29;
        private PictureBox btnAdwordCateSearch;
        private PictureBox btnAdwordCateAdd;
        private DataGridView dtvAdwordCate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private TextBox txtAdwordCate;
        private Label label70;
        private TextBox txtAdwordKey;
        private Label label74;
        private Label label73;
        private TextBox txtAdwordWeb;
        private TextBox txtAdwordExt;
        private Label label71;
        private Label label72;
        private Label label68;
        private TextBox txtAdwordLang;
        private Button btnSocialAuto;
        private RichTextBox txtSocialUrl;
        private Label label14;
        private NumericUpDown numAuto;
        private Label label39;
        private Label label52;
        private CheckBox ckFollow;
        private Button btnArticleFollow;
        private Button btnCheckSERP;
        private ToolStripMenuItem mbtnSERP;
        private PictureBox btnBacklinkCateAdd;
        private Label label16;
        private TextBox txtCheckBacklinkExt;
        private Button btnCheckBacklinkFilter;
        private ComboBox cbSubmitCate;
        private Button btnSitemap;
        private Button btnSubmitView;
        private ComboBox cbAuto;
        private Label label11;
        private Button btnAutoClick;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewLinkColumn dataGridViewLinkColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private TabPage tbNews;
        private GroupBox groupBox24;
        private DataGridView dtvNews;
        private GroupBox groupBox30;
        private PictureBox btnNewsCateSearch;
        private PictureBox btnNewsCateAdd;
        private DataGridView dtvNewsCate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private TextBox txtNewsCate;
        private TabPage tbHTML;
        private WebBrowser webEditor;
        private Button btnHTMLRemoveHref;
        private TextBox txtWebCompare;
        private Label label67;
        private TextBox txtHTMLTitle;
        private Label label66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewLinkColumn Column11;
        private DataGridViewTextBoxColumn Column7;
        private TabPage tbRegex;
        private GroupBox groupBox7;
        private Button btnRegexGetLink;
        private NumericUpDown numericRegexFrom;
        private TextBox txtRegexURL;
        private Label label69;
        private GroupBox groupBox31;
        private NumericUpDown numericRegexTo;
        private Label label76;
        private Button btnHTMLPost;
        private Button btnGetProxy;
        private PictureBox btnHTMLAddAccount;
        private ComboBox cbHTMLAccount;
        private Label label79;
        private PictureBox btnHTMLAddContent;
        private ComboBox cbHTMLContent;
        private Label label78;
        private PictureBox btnHTMLAddAnchor;
        private ComboBox cbHTMLAnchor;
        private Label label53;
        private ComboBox cbHTMLTitle;
        private Label label80;
        private Button btnHTMLAutoInsertContent;
        private Button btnHTMLInsertContent;
        private GroupBox groupBox33;
        private GroupBox groupBox32;
        private ListBox listHTMLCategory;
        private Label label81;
        private RichTextBox txtHTMLDesc;
        private GroupBox groupBox34;
        private Button btnHTMLInsertAnchor;
        private TextBox txtHTMLTags;
        private Label label82;
        private TextBox txtHTMLKeyword;
        private Label label83;
        private NumericUpDown numericHTMLRandomContent;
        private GroupBox groupBox35;
        private Button btnRegexGetContentByRegex;
        private TextBox txtRegexRegex;
        private ComboBox cbRegexType;
        private TextBox txtReplaceContent;
        private RichTextBox rtbRegexURL;
        private RichTextBox rtbRegexResult;
        private Button btnRegexReplace;
        private TabPage tbKeywordTool;
        private GroupBox groupBox37;
        private DataGridView dtvKTList;
        private GroupBox groupBox36;
        private Button btnKTSend;
        private Label label86;
        private TextBox txtKTKey;
        private TextBox txtKTEmail;
        private Timer timer_2;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Top;
        private DataGridViewTextBoxColumn Result;
        private DataGridViewTextBoxColumn Loop;
        private Label label85;
        private Label label84;
        private Button btnKTLogin;
        private Label label88;
        private Label label87;
        private TextBox txtKTLang;
        private TextBox txtKTPosition;
        private PictureBox btnKTSave;
        private Button btnKTFilter;
        private Label label89;
        private TextBox txtKTKeyFilter;
        private Label label90;
        private DataGridViewTextBoxColumn TuKhoa;
        private DataGridViewTextBoxColumn CanhTranh;
        private DataGridViewTextBoxColumn TimKiemToanCau;
        private DataGridViewTextBoxColumn TimKiemCucBo;
        private DataGridViewTextBoxColumn SERP;
        private DataGridViewTextBoxColumn KEI1;
        private DataGridViewTextBoxColumn KEI2;
        private ContextMenuStrip mnuSuggest_1;
        private ToolStripMenuItem btnmKTSERP;
        private ToolStripMenuItem btnmKTSearch;
        private ToolStripMenuItem btnmKTInsight;
        private Button btnKTCheckDomain;
        private Label label92;
        private Label label91;
        private TextBox txtKTExt;
        private TextBox txtKTDomain;
        private Button btnCheckProxy;
        private Label label75;
        private Button btnKTCheckSERP;
        private NumericUpDown numericRegexDelay;
        private TabPage tbSearchBL;
        private GroupBox groupBox18;
        private Button btnSearchExport;
        private Label label59;
        private Label label58;
        private TextBox txtSearchBLKey;
        private TextBox txtSearchBLExt;
        private TextBox txtSearchBLGExt;
        private ComboBox cbSearchBLFilter;
        private Label label60;
        private Button btnSearchBacklink;
        private Label label55;
        private Label label57;
        private TextBox txtSearchBLLang;
        private DataGridView dtvSearchBacklink;
        private DataGridViewLinkColumn SearchWebsite;
        private DataGridViewTextBoxColumn SearchExt;
        private DataGridViewTextBoxColumn SearchPR;
        private DataGridViewTextBoxColumn SearchLoop;
        private GroupBox groupBox17;
        private Label label32;
        private TextBox txtLinkSitemap;
        private Button btnPingSitemap;
        private ToolStripMenuItem btnmKTCheckDomain;
        private TextBox txtKTPass;
        private PictureBox btnKeyListSave;
        private Label label77;
        private Button btnHTMLBold;
        private TabPage tbView;
        private GroupBox groupBox38;
        private TextBox txtViewWebsite;
        private Button btnViewGetSite;
        private Button btnViewUpdate;
        private TabControl tabView;
        private Label label41;
        private Label label93;
        private Timer timer_3;
        private Label label94;
        private Label lbViewTime;
        private Label lbViewCoin;
        private Button btnExitsWebsite;
        private Label lbViewClick;
        private Label label61;
        private RadioButton rdViewDisable;
        private RadioButton rdViewEnable;
        private Timer timer_4;
        private NumericUpDown numericUpDown_0;
        private Button btnHTMLSaveImage;
        private DataGridView dtvSubmit;
        private Button btnKeySave;
        private DataGridView dtvCheckResult;
        private DataGridViewTextBoxColumn GiaTri;
        private DataGridViewLinkColumn CheckUrl;
        private PictureBox btnCheckResultSave;
        private Label label15;
        private Label label51;
        private Button btnSubmitAuto;
        private Timer timer_5;
        private NumericUpDown numSubmitTime;
        private Label label54;
        private DataGridView dtvAnalytics;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn GaiTri;
        private DataGridViewTextBoxColumn TuKhoaOnpage;
        private DataGridViewTextBoxColumn SoLanXuatHien;
        private DataGridView dtvResultCheck;
        private DataGridViewTextBoxColumn SEOTools;
        private DataGridViewLinkColumn Link;
        private Button btnSubmitNext;
        private GroupBox groupBox25;
        private CheckBox ckNewsAuto4;
        private CheckBox ckNewsAuto3;
        private CheckBox ckNewsAuto1;
        private CheckBox ckNewsAuto2;
        private Button btnNewsAuto;
        private Button btnSubmitImport;
        private Button btnHTMLBBcode;
        private Button btnHTMLCode;
        private ComboBox cbNewsCate;
        private Button btnKTRegister;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Keyword;
        private DataGridViewTextBoxColumn Website;
        private DataGridViewTextBoxColumn SERPCount;
        private DataGridViewTextBoxColumn Rank;
        private DataGridViewTextBoxColumn TopOld;
        private DataGridViewTextBoxColumn Lang;
        private DataGridViewTextBoxColumn Ext;
        private DataGridViewTextBoxColumn Column20;
        private PictureBox btnSubmitSave;
        private DataGridViewTextBoxColumn SubmitID;
        private DataGridViewTextBoxColumn SubmitURL;
        private DataGridViewTextBoxColumn SubmitAttributeID;
        private Button btnHTMLPostHand;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewLinkColumn Column18;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewCheckBoxColumn Column21;
        private RichTextBox txtPingUrl;
        private GroupBox groupBox39;
        private DataGridView dtvPingProxy;
        private Button btnPingWebView;
        private Label label6;
        private TextBox txtPingWebUrl;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private Button btnImportProxy;
        private GClass2 webProxy;
        private NumericUpDown numPingView;
        private Label label7;
        private Label label28;
        private Button btnPingViewAuto;
        private Timer timer_6;
        private CheckBox ckTopMobile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel lbSupport;
        private ComboBox cbKTBrowser;
        private Button btnRegexFilterEmail;
        private Button btnRegexFilterYahoo;
        private OpenFileDialog openFileDialog_0;
        private Label label18;
        private Label label30;
        private PictureBox btnSubmitGetSource;
        private PictureBox RegexResultSave;
        private PictureBox btnRegexUrlSave;
        private GClass2 webSubmit;
        private Button btnPingProxyRemove;
        private Button btnRegexFilterLink;
        private Button btnRegexGetSource;
        private PictureBox btnAnalyticsLinkSave;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel lbUpdate;
        private PictureBox btnSearchBacklinkSave;
        private PictureBox btnCheckBacklinkSave;
        private Label label43;
        private TextBox txtSocialGoogleID;
        private NumericUpDown numAutoClick;
        private Label label49;
        [CompilerGenerated]
        private static Func<Class5, int> func_0;
        [CompilerGenerated]
        private static Func<Class6, int> func_1;
        [CompilerGenerated]
        private static MethodInvoker methodInvoker_0;
        [CompilerGenerated]
        private static MethodInvoker methodInvoker_1;
        [CompilerGenerated]
        private static Func<XElement, Class64<string, string, string, string>> func_2;
        [CompilerGenerated]
        private static Func<XElement, Class64<string, string, string, string>> func_3;
        [CompilerGenerated]
        private static MethodInvoker methodInvoker_2;
        [CompilerGenerated]
        private static MethodInvoker methodInvoker_3;
        [CompilerGenerated]
        private static MethodInvoker methodInvoker_4;
        [CompilerGenerated]
        private static MethodInvoker methodInvoker_5;
        [CompilerGenerated]
        private static Func<GClass9, bool> func_4;
        [CompilerGenerated]
        private static Func<GClass9, bool> func_5;
        [CompilerGenerated]
        private static Func<GClass9, bool> func_6;
        [CompilerGenerated]
        private static Func<GClass9, bool> func_7;
        [CompilerGenerated]
        private static Func<GClass9, bool> func_8;
        [CompilerGenerated]
        private static Func<Class11, short> func_9;
        [CompilerGenerated]
        private static Func<Class11, short> func_10;
        [CompilerGenerated]
        private static Func<Class11, long> func_11;
        [CompilerGenerated]
        private static Func<Class12, short> func_12;
        [CompilerGenerated]
        private static Func<Class16, int> func_13;
        [CompilerGenerated]
        private static Func<Class16, int> func_14;
        [CompilerGenerated]
        private static Func<Class17, int> func_15;
        [CompilerGenerated]
        private static Func<Class17, int> func_16;

        public frmMain(InfoSEO info)
        {
            string[] strArray = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o" };
            strArray[9] = "p";
            strArray[10] = "a";
            strArray[11] = "s";
            strArray[12] = "d";
            strArray[13] = "f";
            strArray[14] = "g";
            strArray[15] = "h";
            strArray[0x10] = "j";
            strArray[0x11] = "k";
            strArray[0x12] = "l";
            strArray[0x13] = "z";
            strArray[20] = "x";
            strArray[0x15] = "c";
            strArray[0x16] = "v";
            strArray[0x17] = "b";
            strArray[0x18] = "n";
            strArray[0x19] = "m";
            strArray[0x1a] = "0";
            strArray[0x1b] = "1";
            strArray[0x1c] = "2";
            strArray[0x1d] = "3";
            strArray[30] = "4";
            strArray[0x1f] = "5";
            strArray[0x20] = "6";
            strArray[0x21] = "7";
            strArray[0x22] = "8";
            strArray[0x23] = "9";
            strArray[0x24] = "\x00e1";
            strArray[0x25] = "\x00e0";
            strArray[0x26] = "ả";
            strArray[0x27] = "\x00e3";
            strArray[40] = "ạ";
            strArray[0x29] = "\x00e2";
            strArray[0x2a] = "ấ";
            strArray[0x2b] = "ầ";
            strArray[0x2c] = "ẩ";
            strArray[0x2d] = "ẫ";
            strArray[0x2e] = "ậ";
            strArray[0x2f] = "ă";
            strArray[0x30] = "ắ";
            strArray[0x31] = "ằ";
            strArray[50] = "ẳ";
            strArray[0x33] = "ẵ";
            strArray[0x34] = "ặ";
            strArray[0x35] = "đ";
            strArray[0x36] = "\x00e9";
            strArray[0x37] = "\x00e8";
            strArray[0x38] = "ẻ";
            strArray[0x39] = "ẽ";
            strArray[0x3a] = "ẹ";
            strArray[0x3b] = "\x00ea";
            strArray[60] = "ế";
            strArray[0x3d] = "ề";
            strArray[0x3e] = "ể";
            strArray[0x3f] = "ễ";
            strArray[0x40] = "ệ";
            strArray[0x41] = "\x00ed";
            strArray[0x42] = "\x00ec";
            strArray[0x43] = "ỉ";
            strArray[0x44] = "ĩ";
            strArray[0x45] = "ị";
            strArray[70] = "\x00f3";
            strArray[0x47] = "\x00f2";
            strArray[0x48] = "ỏ";
            strArray[0x49] = "\x00f5";
            strArray[0x4a] = "ọ";
            strArray[0x4b] = "\x00f4";
            strArray[0x4c] = "ố";
            strArray[0x4d] = "ồ";
            strArray[0x4e] = "ổ";
            strArray[0x4f] = "ỗ";
            strArray[80] = "ộ";
            strArray[0x51] = "ơ";
            strArray[0x52] = "ớ";
            strArray[0x53] = "ờ";
            strArray[0x54] = "ở";
            strArray[0x55] = "ỡ";
            strArray[0x56] = "ợ";
            strArray[0x57] = "\x00fa";
            strArray[0x58] = "\x00f9";
            strArray[0x59] = "ủ";
            strArray[90] = "ũ";
            strArray[0x5b] = "ụ";
            strArray[0x5c] = "ư";
            strArray[0x5d] = "ứ";
            strArray[0x5e] = "ừ";
            strArray[0x5f] = "ử";
            strArray[0x60] = "ữ";
            strArray[0x61] = "ự";
            strArray[0x62] = "\x00fd";
            strArray[0x63] = "ỳ";
            strArray[100] = "ỷ";
            strArray[0x65] = "ỹ";
            strArray[0x66] = "ỵ";
            this.string_4 = strArray;
            this.int_20 = 10;
            this.InitializeComponent();
            this.infoSEO_0 = info;
        }

        private void btnAdwordAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtAdwordWeb.Text.Trim()) || (string.IsNullOrEmpty(this.txtAdwordKey.Text.Trim()) || (this.dtvAdwordCate.CurrentRow == null)))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Adwords (AdwordID,CategoryID, [Key], Website, Ext, Lang) VALUES('", Guid.NewGuid(), "','", this.dtvAdwordCate.CurrentRow.Cells[0].Value.ToString(), "','", this.txtAdwordKey.Text.Trim(), "','", this.txtAdwordWeb.Text.Trim(), "','" };
                    objArray[9] = this.txtAdwordExt.Text.Trim();
                    objArray[10] = "','";
                    objArray[11] = this.txtAdwordLang.Text.Trim();
                    objArray[12] = "')";
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_71();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAdwordCateAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { 
                string_0 = "ADWORD",
                string_1 = this.txtAdwordCate.Text.Trim()
            }.ShowDialog();
            this.method_70();
        }

        private void btnAdwordCateSearch_Click(object sender, EventArgs e)
        {
            this.method_70();
        }

        private void btnAdwordCheck_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_73)) { IsBackground = true }.Start();
        }

        private void btnAdwordDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Adwords WHERE AdwordID='" + this.dtvAdword.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_71();
                this.txtAdwordKey.Text = string.Empty;
                this.txtAdwordWeb.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAdwordEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strArray = new string[] { "UPDATE Adwords SET [Key]='", this.txtAdwordKey.Text.Trim(), "' , Website='", this.txtAdwordWeb.Text.Trim(), "', Ext='", this.txtAdwordExt.Text.Trim(), "', Lang='", this.txtAdwordLang.Text.Trim(), "' WHERE AdwordID='" };
                strArray[9] = this.dtvAdword.CurrentRow.Cells[0].Value.ToString();
                strArray[10] = "'";
                string str = string.Concat(strArray);
                this.gclass4_0.method_42(str);
                this.method_71();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAdwordSearch_Click(object sender, EventArgs e)
        {
            this.bool_3 = true;
            this.method_71();
            this.bool_3 = false;
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtWebsiteUrl.Text.Trim()))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    this.picLoader.Show();
                    new Thread(new ThreadStart(this.method_16)) { IsBackground = true }.Start();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAnalyticsCompare_Click(object sender, EventArgs e)
        {
            try
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_54)) { IsBackground = true }.Start();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAnalyticsLinkSave_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_108)) { IsBackground = true }.Start();
        }

        private void btnArticleAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtArticleLink.Text.Trim()) || (this.dtvArticleCate.CurrentRow == null))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Articles (ArticleID, CategoryID, Url) VALUES('", Guid.NewGuid(), "','", this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString(), "','", this.txtArticleLink.Text.Trim(), "')" };
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_46();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnArticleCateAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { 
                string_0 = "ARTICLE",
                string_1 = this.txtArticleCate.Text.Trim()
            }.ShowDialog();
            this.method_45();
        }

        private void btnArticleCateSearch_Click(object sender, EventArgs e)
        {
            this.method_45();
        }

        private void btnArticleCheck_Click(object sender, EventArgs e)
        {
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.gclass4_0.string_0 = "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";
                this.picLoader.Show();
                this.list_9 = new List<Class15>();
                string str = "SELECT * FROM Articles WHERE CategoryID='" + this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY ArticleID DESC";
                if (this.ckFollow.Checked)
                {
                    str = "SELECT * FROM Articles WHERE CategoryID='" + this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString() + "' AND Follow=True ORDER BY ArticleID DESC";
                }
                foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
                {
                    Class15 item = new Class15();
                    item.method_1(row["ArticleID"].ToString());
                    item.method_5(row["Url"].ToString());
                    if (!this.bool_4 || string.IsNullOrEmpty(this.dtvArticle.CurrentRow.Cells[0].Value.ToString()))
                    {
                        this.list_9.Add(item);
                        continue;
                    }
                    if (row["ArticleID"].ToString().Equals(this.dtvArticle.CurrentRow.Cells[0].Value.ToString()))
                    {
                        this.list_9.Add(item);
                    }
                }
                int count = this.list_9.Count;
                if (count > 10)
                {
                    count = 10;
                }
                this.int_12 = 0;
                this.int_13 = count;
                for (int i = 0; i < count; i++)
                {
                    new Thread(new ThreadStart(this.method_55)) { IsBackground = true }.Start();
                    Thread.Sleep(50);
                }
                new Thread(new ThreadStart(this.method_56)) { IsBackground = true }.Start();
            }
        }

        private void btnArticleCheckOne_Click(object sender, EventArgs e)
        {
            this.bool_4 = true;
            this.btnArticleCheck.PerformClick();
        }

        private void btnArticleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Articles WHERE ArticleID='" + this.dtvArticle.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_46();
                this.txtArticleLink.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnArticleEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("UPDATE Articles SET Url='" + this.txtArticleLink.Text.Trim() + "' WHERE ArticleID='" + this.dtvArticle.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_46();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnArticleFollow_Click(object sender, EventArgs e)
        {
            this.ckFollow.Checked = true;
            this.method_46();
            this.timer_1.Interval = ((int) this.numAuto.Value) * 0xea60;
            if (this.timer_1.Enabled)
            {
                this.timer_1.Enabled = false;
                this.timer_1.Stop();
                this.btnArticleFollow.Text = "Theo d\x00f5i";
            }
            else
            {
                this.timer_1.Enabled = true;
                this.timer_1.Start();
                this.btnArticleFollow.Text = "Dừng Lại";
            }
        }

        private void btnArticleOpenAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = this.gclass4_0.method_40("SELECT * FROM Articles WHERE CategoryID='" + this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY ArticleID DESC");
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Process.Start(row["Url"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn Website!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnArticleOpenChange_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = this.gclass4_0.method_40("SELECT * FROM Articles WHERE CategoryID='" + this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY ArticleID DESC");
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (!row["Current"].ToString().Equals(row["Before"].ToString()))
                        {
                            Process.Start(row["Url"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn Website!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnArticleRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in (IEnumerable) this.dtvArticle.Rows)
                {
                    this.gclass4_0.method_42("UPDATE Articles SET [Before]=[Current] WHERE ArticleID='" + row.Cells[0].Value.ToString() + "'");
                }
                this.method_46();
                MessageBox.Show("L\x00e0m mới dữ liệ th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
            }
        }

        private void btnArticleSearch_Click(object sender, EventArgs e)
        {
            this.bool_3 = true;
            this.method_46();
            this.bool_3 = false;
        }

        private void btnAutoClick_Click(object sender, EventArgs e)
        {
            if (!this.bool_5)
            {
                MessageBox.Show("H\x00e3y đợi Website tải xuống ho\x00e0n tất!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_75)) { IsBackground = true }.Start();
            }
        }

        private void btnBacklinkAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtBacklinkUrl.Text.Trim()) || (this.dtvBacklinkCate.CurrentRow == null))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Backlinks (BacklinkID, CategoryID, Url, Weblink) VALUES('", Guid.NewGuid(), "','", this.dtvBacklinkCate.CurrentRow.Cells[0].Value.ToString(), "','", this.txtBacklinkUrl.Text.Trim(), "','", this.txtBacklinkWeblink.Text.Trim(), "')" };
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_42();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnBacklinkCateAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { 
                string_0 = "BACKLINK",
                string_1 = this.txtBacklinkCate.Text.Trim()
            }.ShowDialog();
            this.method_41();
        }

        private void btnBacklinkCateSearch_Click(object sender, EventArgs e)
        {
            this.method_41();
        }

        private void btnBacklinkCheck_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            this.list_7 = new List<Class14>();
            foreach (DataRow row in this.gclass4_0.method_40("SELECT * FROM Backlinks WHERE CategoryID='" + this.dtvBacklinkCate.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY BacklinkID DESC").Rows)
            {
                Class14 item = new Class14();
                item.method_5(row["Url"].ToString());
                item.method_7(row["Weblink"].ToString());
                item.method_1(row["BacklinkID"].ToString());
                this.list_7.Add(item);
            }
            int count = this.list_7.Count;
            if (count > 10)
            {
                count = 10;
            }
            this.int_6 = 0;
            this.int_7 = count;
            for (int i = 0; i < count; i++)
            {
                new Thread(new ThreadStart(this.method_44)) { IsBackground = true }.Start();
                Thread.Sleep(50);
            }
            new Thread(new ThreadStart(this.method_43)) { IsBackground = true }.Start();
        }

        private void btnBacklinkDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Backlinks WHERE BacklinkID='" + this.dtvBacklink.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_42();
                this.txtBacklinkUrl.Text = string.Empty;
                this.txtBacklinkWeblink.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnBacklinkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("UPDATE Backlinks SET Url='" + this.txtBacklinkUrl.Text.Trim() + "', Weblink='" + this.txtBacklinkWeblink.Text.Trim() + "' WHERE BacklinkID='" + this.dtvBacklink.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_42();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnBacklinkSearch_Click(object sender, EventArgs e)
        {
            this.bool_3 = true;
            this.method_42();
            this.bool_3 = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtKeyword.Text.Trim()) || string.IsNullOrEmpty(this.txtDomain.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_1)) { IsBackground = true }.Start();
            }
        }

        private void btnCheckBacklinkFilter_Click(object sender, EventArgs e)
        {
            this.dtvCheckBacklink.Rows.Clear();
            if (func_16 == null)
            {
                func_16 = new Func<Class17, int>(frmMain.smethod_22);
            }
            this.list_11 = this.list_11.OrderByDescending<Class17, int>(func_16).ToList<Class17>();
            foreach (Class17 class2 in this.list_11)
            {
                if (class2.method_2().EndsWith(this.txtCheckBacklinkExt.Text.Trim()))
                {
                    object[] values = new object[] { class2.method_2(), class2.method_6(), class2.method_0(), class2.method_4() };
                    this.dtvCheckBacklink.Rows.Add(values);
                }
            }
            this.picLoader.Hide();
        }

        private void btnCheckBacklinkSave_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_110)) { IsBackground = true }.Start();
        }

        private void btnCheckBLOK_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            this.dtvCheckBacklink.Rows.Clear();
            new Thread(new ThreadStart(this.method_69)) { IsBackground = true }.Start();
        }

        private void btnCheckError_Click(object sender, EventArgs e)
        {
            if (this.list_8.Count > 0)
            {
                int count = this.list_8.Count;
                if (count > 10)
                {
                    count = 10;
                }
                this.int_10 = 0;
                this.int_11 = count;
                this.picLoader.Show();
                int num2 = 0;
                while (true)
                {
                    if (num2 >= count)
                    {
                        new Thread(new ThreadStart(this.method_51)) { IsBackground = true }.Start();
                        break;
                    }
                    new Thread(new ThreadStart(this.method_50)) { IsBackground = true }.Start();
                    num2++;
                }
            }
        }

        private void btnCheckGoogleIndex_Click(object sender, EventArgs e)
        {
            string urlString = "http://www.google.com.vn/search?hl=vi&q=" + HttpUtility.UrlEncode(this.txtCheckIndexKey.Text.Trim()) + " site:" + HttpUtility.UrlEncode(this.txtCheckIndexUrl.Text.Trim());
            frmBrowser browser = new frmBrowser();
            browser.webBrowser.Navigate(urlString);
            browser.ShowDialog();
        }

        private void btnCheckIndex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtWebsiteCheck.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_10)) { IsBackground = true }.Start();
            }
        }

        private void btnCheckPlus_Click(object sender, EventArgs e)
        {
            if (list_0 == null)
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.dtvCheckResult.Rows.Clear();
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_12)) { IsBackground = true }.Start();
            }
        }

        private void btnCheckPR_Click(object sender, EventArgs e)
        {
            if (list_0 == null)
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.dtvCheckResult.Rows.Clear();
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_38)) { IsBackground = true }.Start();
            }
        }

        private void btnCheckProxy_Click(object sender, EventArgs e)
        {
            try
            {
                List<Class13> parameter = new List<Class13>();
                foreach (DataGridViewRow row in (IEnumerable) this.dtvPingProxy.Rows)
                {
                    string str = row.Cells[0].Value.ToString();
                    char[] separator = new char[] { ':' };
                    List<string> list2 = str.Split(separator).ToList<string>();
                    if (list2.Count == 2)
                    {
                        Class13 item = new Class13();
                        item.method_1(list2[0]);
                        item.method_3(Convert.ToInt32(list2[1]));
                        parameter.Add(item);
                    }
                }
                this.picLoader.Show();
                new Thread(new ParameterizedThreadStart(this.method_81)) { IsBackground = true }.Start(parameter);
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCheckResultSave_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_102)) { IsBackground = true }.Start();
        }

        private void btnCheckSERP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtKeyResearch.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_74)) { IsBackground = true }.Start();
            }
        }

        private void btnCheckWeb_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtWebReport.Text.Trim()))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    frmBrowser browser = new frmBrowser();
                    browser.webBrowser.Navigate(this.cbWebReport.SelectedValue.ToString().Replace("$domain$", this.txtWebReport.Text.Trim()));
                    browser.ShowDialog();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitsWebsite_Click(object sender, EventArgs e)
        {
            if (!this.timer_3.Enabled)
            {
                InfoSEO info = new InfoSEO();
                if (this.tabView.TabCount > 0)
                {
                    this.tabView.SelectedTab.Controls[0].Dispose();
                    this.tabView.TabPages.Remove(this.tabView.SelectedTab);
                    this.method_99();
                }
                if ((this.int_19 == -1) && (this.tabView.TabCount == 0))
                {
                    string str = "";
                    int num = 0;
                    while (true)
                    {
                        if ((num >= this.int_20) || (num >= this.list_15.Count))
                        {
                            if (str.EndsWith(","))
                            {
                                str = str.Substring(0, str.Length - 1);
                            }
                            info.Email = this.infoSEO_0.Email;
                            info.ListUser = str;
                            if (!this.iSEOSoapClient_0.UpdateCoin(info))
                            {
                                MessageBox.Show("Rất tiếc đ\x00e3 c\x00f3 lỗi xảy ra, Xin h\x00e3y thử lại!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                this.lbViewCoin.Text = (Convert.ToInt32(this.lbViewCoin.Text) + 10).ToString();
                                this.infoSEO_0.iCoin += 10;
                                MessageBox.Show("Bạn đ\x00e3 được cộng 10 iCoin!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.int_19 = 10;
                                this.lbViewTime.Text = this.int_19.ToString();
                                if (this.list_15.Count < this.int_20)
                                {
                                    this.list_15 = this.method_98();
                                    return;
                                }
                            }
                            break;
                        }
                        str = str + this.list_15[num].string_0 + ",";
                        this.list_15.RemoveAt(0);
                        num++;
                    }
                }
            }
        }

        private void btnGetProxy_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_91)) { IsBackground = true }.Start();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
            base.Hide();
        }

        private void btnHTMLAddAccount_Click(object sender, EventArgs e)
        {
            new frmAccount().ShowDialog();
            this.method_82();
            if (this.cbHTMLAccount.SelectedValue != null)
            {
                this.method_84();
            }
        }

        private void btnHTMLAddAnchor_Click(object sender, EventArgs e)
        {
            new frmAnchor().ShowDialog();
            this.method_85();
        }

        private void btnHTMLAddContent_Click(object sender, EventArgs e)
        {
            new frmContent().ShowDialog();
            this.method_86();
            this.method_87();
        }

        private void btnHTMLAutoInsertContent_Click(object sender, EventArgs e)
        {
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                int count;
                string str = "SELECT [Content] FROM Contents WHERE [CategoryID]='" + this.cbHTMLContent.SelectedValue + "'";
                List<string> list = new List<string>();
                foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
                {
                    list.Add(row["Content"].ToString());
                }
                list = this.gclass4_0.method_23<string>(list);
                if (((int) this.numericHTMLRandomContent.Value) > list.Count)
                {
                    count = list.Count;
                }
                string str2 = "";
                foreach (string str3 in list)
                {
                    str2 = str2 + str3;
                    count--;
                    if (count == 0)
                    {
                        break;
                    }
                }
                string str4 = this.txtHTMLTitle.Text.Trim();
                string str5 = this.txtHTMLDesc.Text.Trim();
                string str6 = this.txtHTMLKeyword.Text.Trim();
                str2 = str2.Replace("$title$", this.gclass4_0.method_21(str4)).Replace("$description$", this.gclass4_0.method_21(str5)).Replace("$keyword$", this.gclass4_0.method_21(str6));
                object[] objArray = new object[] { this.gclass4_0.method_21(str2) };
                this.method_76("SetContents", objArray);
            }
        }

        private void btnHTMLBBcode_Click(object sender, EventArgs e)
        {
            this.method_76("BBcode", new object[0]);
        }

        private void btnHTMLBold_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            string str2 = HttpUtility.HtmlDecode(this.method_76("GetContents", new object[0]).ToString());
            foreach (string str3 in Regex.Split(this.txtHTMLKeyword.Text.Trim(), ","))
            {
                str2 = this.gclass4_0.method_31(str2, str3);
            }
            this.method_76("SetContents", new object[] { str2 });
            this.picLoader.Hide();
        }

        private void btnHTMLCode_Click(object sender, EventArgs e)
        {
            this.method_76("HTMLCode", new object[0]);
        }

        private void btnHTMLInsertAnchor_Click(object sender, EventArgs e)
        {
            string str = this.method_76("GetContents", new object[0]).ToString();
            if (!string.IsNullOrEmpty(str))
            {
                str = HttpUtility.HtmlDecode(str);
                string str2 = "SELECT [Key], [ListUrl] FROM Anchor WHERE [CategoryID] = '" + this.cbHTMLAnchor.SelectedValue + "' ORDER BY [LengthKey]";
                DataTable table = this.gclass4_0.method_40(str2);
                foreach (DataRow row in table.Rows)
                {
                    if (!row["Key"].ToString().StartsWith("http"))
                    {
                        str = this.gclass4_0.method_32(str, row["Key"].ToString(), row["ListUrl"].ToString(), 1);
                    }
                }
                foreach (DataRow row2 in table.Rows)
                {
                    if (row2["Key"].ToString().StartsWith("http"))
                    {
                        str = this.gclass4_0.method_32(str, row2["Key"].ToString(), row2["ListUrl"].ToString(), 1);
                    }
                }
                this.method_76("SetContents", new object[] { str });
            }
        }

        private void btnHTMLInsertContent_Click(object sender, EventArgs e)
        {
            string str = "SELECT [Content] FROM Contents WHERE [ContentID]='" + this.cbHTMLTitle.SelectedValue + "'";
            string str2 = "";
            foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
            {
                str2 = row["Content"].ToString();
            }
            string str3 = this.txtHTMLTitle.Text.Trim();
            string str4 = this.txtHTMLDesc.Text.Trim();
            string str5 = this.txtHTMLKeyword.Text.Trim();
            str2 = str2.Replace("$title$", this.gclass4_0.method_21(str3)).Replace("$description$", this.gclass4_0.method_21(str4)).Replace("$keyword$", this.gclass4_0.method_21(str5));
            object[] objArray = new object[] { this.gclass4_0.method_21(str2) };
            this.method_76("InsertHTML", objArray);
        }

        private void btnHTMLPost_Click(object sender, EventArgs e)
        {
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    this.picLoader.Show();
                    new Thread(new ThreadStart(this.method_83)) { IsBackground = true }.Start();
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnHTMLPostHand_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.cbHTMLAccount.Tag.ToString().Equals("Blogger"))
                {
                    MessageBox.Show("Chỉ d\x00e0nh cho Blogger!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    this.tbMain.SelectTab("tbSubmit");
                    string[] strArray = this.listHTMLCategory.Tag.ToString().Split(new char[] { ';' });
                    this.txtSubmitAddress.Text = "http://draft.blogger.com/blogger.g?blogID=" + strArray[1] + "#editor/src=sidebar";
                    this.btnSubmitView.PerformClick();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn th\x00f4ng tin đầy đủ!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnHTMLRemoveHref_Click(object sender, EventArgs e)
        {
            string str = this.method_76("GetContents", new object[0]).ToString();
            object[] objArray = new object[] { this.gclass4_0.method_35(str) };
            this.method_76("SetContents", objArray);
        }

        private void btnHTMLSaveImage_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            try
            {
                string str = this.method_76("GetContents", new object[0]).ToString().ToLower();
                List<string> list = this.gclass4_0.method_20("<img(?<Content>.*?)>", str);
                SaveFileDialog dialog = new SaveFileDialog {
                    Title = "Save Image Files",
                    FileName = "Đặt t\x00ean h\x00ecnh ảnh",
                    Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png"
                };
                if ((dialog.ShowDialog() == DialogResult.OK) && (dialog.FileName != ""))
                {
                    string fileName = dialog.FileName;
                    int num = 0;
                    foreach (string str3 in list)
                    {
                        string str4 = this.gclass4_0.method_15("src=[\"|'](?<Content>.*?)[\"|']", str3);
                        if (str4.StartsWith("http"))
                        {
                            Bitmap bitmap = this.method_101(str4);
                            if (num > 0)
                            {
                                dialog.FileName = Path.GetFileNameWithoutExtension(fileName) + "-" + num.ToString() + Path.GetExtension(fileName);
                            }
                            switch (dialog.FilterIndex)
                            {
                                case 1:
                                    bitmap.Save(dialog.FileName, ImageFormat.Jpeg);
                                    break;

                                case 2:
                                    bitmap.Save(dialog.FileName, ImageFormat.Bmp);
                                    break;

                                case 3:
                                    bitmap.Save(dialog.FileName, ImageFormat.Gif);
                                    break;

                                case 4:
                                    bitmap.Save(dialog.FileName, ImageFormat.Png);
                                    break;

                                default:
                                    break;
                            }
                            num++;
                        }
                    }
                    MessageBox.Show("Tải file th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.picLoader.Hide();
        }

        private void btnImportProxy_Click(object sender, EventArgs e)
        {
            this.dtvPingProxy.Rows.Clear();
            new frmLink().ShowDialog();
            foreach (string str in list_0)
            {
                if (!string.IsNullOrEmpty(str.Trim()))
                {
                    object[] values = new object[] { str.Trim() };
                    this.dtvPingProxy.Rows.Add(values);
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new frmInfo().ShowDialog();
        }

        private void btnKeyAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtKeyword.Text.Trim()) || string.IsNullOrEmpty(this.txtDomain.Text.Trim()))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Keywords(KeywordID, CategoryID, [Key],Website,[Top],TopOld,Lang,Ext,Compare, SERP) VALUES('", Guid.NewGuid(), "','", this.cbKeyCate.SelectedValue, "','", this.txtKeyword.Text.Trim(), "','", this.txtDomain.Text.Trim(), "',0,0,'" };
                    objArray[9] = this.txtLang.Text.Trim();
                    objArray[10] = "','";
                    objArray[11] = this.txtExt.Text.Trim();
                    objArray[12] = "','";
                    objArray[13] = this.txtWebCompare.Text.Trim();
                    objArray[14] = "',0)";
                    this.gclass4_0.method_42(string.Concat(objArray));
                    this.method_26();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnKeyCateAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { string_0 = "KEY" }.ShowDialog();
            this.method_40();
        }

        private void btnKeyCheck_Click(object sender, EventArgs e)
        {
            this.btnCheck.PerformClick();
        }

        private void btnKeyCheckAll_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_48)) { IsBackground = true }.Start();
        }

        private void btnKeyDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Keywords WHERE KeywordID='" + this.dtvKeyLogs.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_26();
                MessageBox.Show("Xo\x00e1 từ kho\x00e1 th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kho\x00e1!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnKeyFilter_Click(object sender, EventArgs e)
        {
            Predicate<Class11> match = null;
            try
            {
                List<Class11> list;
                lock (this.list_3)
                {
                    if (match == null)
                    {
                        match = new Predicate<Class11>(this.method_118);
                    }
                    func_9 ??= new Func<Class11, short>(frmMain.smethod_15);
                    list = this.list_3.FindAll(match).OrderByDescending<Class11, short>(func_9).ToList<Class11>();
                }
                Thread.Sleep(300);
                this.dtvSuggest.Rows.Clear();
                foreach (Class11 class2 in list)
                {
                    object[] values = new object[] { class2.method_0(), class2.method_4(), class2.method_2(), class2.method_6() };
                    int num = this.dtvSuggest.Rows.Add(values);
                    this.dtvSuggest.Rows[num].Tag = class2;
                }
            }
            catch
            {
            }
        }

        private void btnKeyListSave_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_97)) { IsBackground = true }.Start();
        }

        private void btnKeySave_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("UPDATE Keywords SET [Key]='" + this.txtKeyword.Text.Trim() + "', Website='" + this.txtDomain.Text.Trim() + "', Compare='" + this.txtWebCompare.Text.Trim() + "' WHERE KeywordID='" + this.dtvKeyLogs.CurrentRow.Cells[0].Value.ToString() + "'");
                MessageBox.Show("Cập nhật th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.method_26();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnKTCheckDomain_Click(object sender, EventArgs e)
        {
            try
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_96)) { IsBackground = true }.Start();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnKTCheckSERP_Click(object sender, EventArgs e)
        {
            try
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_94)) { IsBackground = true }.Start();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnKTFilter_Click(object sender, EventArgs e)
        {
            Predicate<GClass13> match = null;
            try
            {
                if (match == null)
                {
                    match = new Predicate<GClass13>(this.method_138);
                }
                List<GClass13> list = this.list_14.FindAll(match).ToList<GClass13>();
                this.dtvKTList.Rows.Clear();
                foreach (GClass13 class2 in list)
                {
                    object[] values = new object[] { class2.string_0, class2.int_0, class2.long_0, class2.long_1, class2.decimal_0, class2.decimal_1, class2.decimal_2 };
                    this.dtvKTList.Rows.Add(values);
                }
            }
            catch
            {
            }
        }

        private void btnKTLogin_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            HtmlDocument document = this.webBrowser_0.Document;
            if (document.Body.OuterHtml.IndexOf("Đăng nhập") < 0)
            {
                MessageBox.Show("Bạn đ\x00e3 đăng nhập, H\x00e3y nhập từ kho\x00e1 để kiếm tra!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            HtmlElement elementById = document.GetElementById("Email");
            if (elementById != null)
            {
                elementById.SetAttribute("value", this.txtKTEmail.Text);
            }
            elementById = document.GetElementById("Passwd");
            if (elementById != null)
            {
                elementById.SetAttribute("value", this.txtKTPass.Text);
            }
            elementById = document.GetElementById("PersistentCookie");
            if (elementById != null)
            {
                elementById.SetAttribute("checked", "checked");
            }
            elementById = document.GetElementById("signIn");
            if (elementById != null)
            {
                elementById.InvokeMember("click");
            }
            this.webBrowser_0.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowser_0_DocumentCompleted_1);
            if (this.gclass4_0.method_40("SELECT * FROM Users WHERE Code='ADWORD'").Rows.Count > 0)
            {
                this.gclass4_0.method_42("UPDATE Users SET UserName = '" + this.txtKTEmail.Text.Trim() + "', [Password] = '" + this.txtKTPass.Text.Trim() + "' WHERE Code='ADWORD'");
            }
            else
            {
                this.gclass4_0.method_42(string.Concat(new object[] { "INSERT INTO Users(UserID, [UserName], [Password], [Code]) VALUES('", Guid.NewGuid(), "','", this.txtKTEmail.Text.Trim(), "', '", this.txtKTPass.Text.Trim(), "', 'ADWORD')" }));
            }
        }

        private void btnKTRegister_Click(object sender, EventArgs e)
        {
            Process.Start("https://adwords.google.com.vn/o/Targeting/Explorer");
        }

        private void btnKTSave_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_90)) { IsBackground = true }.Start();
        }

        private void btnKTSend_Click(object sender, EventArgs e)
        {
            HtmlDocument document = this.webBrowser_0.Document;
            if (document.Body.OuterHtml.IndexOf("Đăng nhập") > 0)
            {
                MessageBox.Show("Đăng nhập Adword để sử dụng!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string outerHtml = document.Body.OuterHtml;
                this.picLoader.Show();
                foreach (HtmlElement element in document.GetElementsByTagName("textarea"))
                {
                    element.InnerText = this.txtKTKey.Text;
                }
                foreach (HtmlElement element2 in document.GetElementsByTagName("a"))
                {
                    if (element2.OuterHtml.IndexOf("T\x00f9y chọn v\x00e0 bộ lọc n\x00e2ng cao") > 0)
                    {
                        element2.InvokeMember("click");
                    }
                }
                foreach (HtmlElement element3 in document.GetElementsByTagName("select"))
                {
                    if ((element3.OuterHtml.IndexOf("aw-ti-advancedOptions-picker") > 0) && (element3.OuterHtml.IndexOf("multiple") < 0))
                    {
                        element3.SetAttribute("value", this.txtKTPosition.Text.Trim());
                    }
                    else if ((element3.OuterHtml.IndexOf("aw-ti-advancedOptions-picker") > 0) && (element3.OuterHtml.IndexOf("multiple") > 0))
                    {
                        element3.SetAttribute("value", this.txtKTLang.Text.Trim());
                    }
                    if (element3.OuterHtml.IndexOf("aw-native-select-box") > 0)
                    {
                        element3.SetAttribute("value", this.cbKTBrowser.SelectedValue.ToString());
                    }
                }
                if (!this.bool_7)
                {
                    foreach (HtmlElement element4 in document.GetElementsByTagName("span"))
                    {
                        if (element4.OuterHtml.IndexOf("\x00dd tưởng từ kh\x00f3a") > 0)
                        {
                            element4.InvokeMember("click");
                            this.bool_7 = true;
                        }
                    }
                }
                foreach (HtmlElement element5 in document.GetElementsByTagName("button"))
                {
                    if (element5.OuterHtml.IndexOf("gwt-Button") > 0)
                    {
                        element5.InvokeMember("click");
                        this.timer_2.Enabled = true;
                    }
                }
            }
        }

        private void btnmKTCheckDomain_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtKTDomain.Text = this.gclass4_0.method_2(this.dtvKTList.CurrentRow.Cells[0].Value.ToString());
                this.btnKTCheckDomain.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnmKTInsight_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrowser browser = new frmBrowser();
                browser.webBrowser.Navigate("http://www.google.com/insights/search/#q=" + HttpUtility.UrlEncode(this.dtvKTList.CurrentRow.Cells[0].Value.ToString()) + "&cmpt=q&hl=" + this.txtLangSuggest.Text);
                browser.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnmKTSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrowser browser = new frmBrowser();
                browser.webBrowser.Navigate("http://www.google." + this.txtExtSuggest.Text.Trim() + "/search?hl=" + this.txtLangSuggest.Text.Trim() + "&q=" + HttpUtility.UrlEncode(this.dtvKTList.CurrentRow.Cells[0].Value.ToString()) + "&adtest=on");
                browser.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnmKTSERP_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtKeyResearch.Text = this.dtvKTList.CurrentRow.Cells[0].Value.ToString();
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_74)) { IsBackground = true }.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnNewsAuto_Click(object sender, EventArgs e)
        {
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    if (this.dtvNews.SelectedRows.Count < 0)
                    {
                        MessageBox.Show("H\x00e3y lựa chọn b\x00e0i viết để đăng tin!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        this.picLoader.Show();
                        new Thread(new ThreadStart(this.method_103)) { IsBackground = true }.Start();
                    }
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnNewsCateAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { 
                string_0 = "NEWS",
                string_1 = this.txtNewsCate.Text.Trim()
            }.ShowDialog();
            this.method_77();
        }

        private void btnNewsCateSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.picLoader.Show();
                new Thread(new ParameterizedThreadStart(this.method_79)) { IsBackground = true }.Start(false);
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnOpenLink_Click(object sender, EventArgs e)
        {
            new frmLink().ShowDialog();
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrowser browser = new frmBrowser();
                string urlString = "https://developers.google.com/speed/pagespeed/insights#url=" + this.txtWebsiteUrl.Text.Trim() + "&mobile=false&rule=____critical__path";
                browser.webBrowser.Navigate(urlString);
                browser.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPingUrl.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (!string.IsNullOrEmpty(this.txtPingUrl.Text.Trim()) && !string.IsNullOrEmpty(this.txtPingTitle.Text.Trim()))
            {
                this.list_5 = new List<string>();
                this.list_5.Add("http://feedburner.google.com/fb/a/ping");
                this.list_5.Add("http://rpc.pingomatic.com/RPC2");
                this.list_5.Add("http://blogsearch.google.com.vn/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.com/ping/RPC2");
                this.list_5.Add("http://rpc.twingly.com");
                this.list_5.Add("http://rpc.weblogs.com/RPC2");
                this.list_5.Add("http://blo.gs/ping.php");
                this.list_5.Add("http://geourl.org/ping");
                this.list_5.Add("http://blogsearch.google.co.za/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.com.au/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.com.br/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.com.do/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.hr/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.ie/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.nl/ping/RPC2");
                this.list_5.Add("http://blogsearch.google.pl/ping/RPC2");
                this.list_5.Add("http://www.pingmyblog.com");
                this.list_6 = this.txtPingUrl.Text.Trim().Split(new char[] { '\n' }).ToList<string>();
                this.picLoader.Show();
                int count = this.list_5.Count;
                if (count > 5)
                {
                    count = 5;
                }
                this.int_4 = count;
                this.int_5 = 0;
                for (int i = 0; i < count; i++)
                {
                    new Thread(new ThreadStart(this.method_37)) { IsBackground = true }.Start();
                }
                new Thread(new ThreadStart(this.method_36)) { IsBackground = true }.Start();
            }
        }

        private void btnPingProxyRemove_Click(object sender, EventArgs e)
        {
            string str = this.txtPingWebUrl.Text.Trim();
            if (string.IsNullOrEmpty(str) || (this.dtvPingProxy.SelectedRows.Count == 0))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                GClass1 class2 = new GClass1();
                class2.method_3(string.Empty);
                class2.method_7(string.Empty);
                class2.method_1(string.Empty);
                class2.method_5(string.Empty);
                this.webSubmit.method_1(class2);
                this.webProxy.method_1(class2);
                this.webProxy.Navigate(str);
            }
        }

        private void btnPingSitemap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtLinkSitemap.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_13)) { IsBackground = true }.Start();
            }
        }

        private void btnPingViewAuto_Click(object sender, EventArgs e)
        {
            this.timer_6.Interval = ((int) this.numPingView.Value) * 0x3e8;
            if (!this.btnPingViewAuto.Text.Equals("Dừng Lại"))
            {
                this.btnPingWebView.PerformClick();
                this.btnPingViewAuto.Text = "Dừng Lại";
            }
            else
            {
                this.timer_6.Enabled = false;
                this.timer_6.Stop();
                this.btnPingViewAuto.Text = "Bắt Đầu";
            }
        }

        private void btnPingWebView_Click(object sender, EventArgs e)
        {
            string str = this.txtPingWebUrl.Text.Trim();
            if (string.IsNullOrEmpty(str) || (this.dtvPingProxy.SelectedRows.Count == 0))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                GClass1 class2 = new GClass1();
                class2.method_1("iSEO");
                class2.method_5(string.Empty);
                class2.method_7(string.Empty);
                class2.method_3(this.dtvPingProxy.CurrentRow.Cells[0].Value.ToString());
                this.webSubmit.method_1(class2);
                this.webProxy.method_1(class2);
                this.webProxy.Navigate(str);
            }
        }

        private void btnRegexFilterEmail_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog_0.ShowDialog();
                List<string> source = new List<string>();
                if (!this.openFileDialog_0.FileName.Equals(string.Empty))
                {
                    using (StreamReader reader = new StreamReader(this.openFileDialog_0.FileName, Encoding.Default))
                    {
                        while (!reader.EndOfStream)
                        {
                            string str = reader.ReadLine().ToLower();
                            if (!string.IsNullOrEmpty(str) && ((str.IndexOf("@") >= 0) && (str.Substring(0, str.IndexOf("@")).Length > 3)))
                            {
                                source.Add(str);
                            }
                        }
                    }
                    source.Sort();
                    StreamWriter writer = new StreamWriter(this.openFileDialog_0.FileName + "_EMAIL_FILLTER.txt");
                    foreach (string str2 in source.Distinct<string>().ToList<string>())
                    {
                        writer.WriteLine(str2);
                    }
                    writer.Close();
                    this.method_99();
                    MessageBox.Show("Lọc Email tr\x00f9ng lặp th\x00e0nh c\x00f4ng!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR!" + exception.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnRegexFilterLink_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog_0.ShowDialog();
                List<string> source = new List<string>();
                if (!this.openFileDialog_0.FileName.Equals(string.Empty))
                {
                    using (StreamReader reader = new StreamReader(this.openFileDialog_0.FileName, Encoding.Default))
                    {
                        while (!reader.EndOfStream)
                        {
                            source.Add(reader.ReadLine());
                        }
                    }
                    StreamWriter writer = new StreamWriter(this.openFileDialog_0.FileName + "_LINK_FILLTER.txt");
                    foreach (string str in source.Distinct<string>().ToList<string>())
                    {
                        writer.WriteLine(str);
                    }
                    writer.Close();
                    this.method_99();
                    MessageBox.Show("Lọc Link tr\x00f9ng lặp th\x00e0nh c\x00f4ng!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR!" + exception.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnRegexFilterYahoo_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog_0.ShowDialog();
                if (!this.openFileDialog_0.FileName.Equals(string.Empty))
                {
                    StreamReader reader = new StreamReader(this.openFileDialog_0.FileName);
                    StreamWriter writer = new StreamWriter(this.openFileDialog_0.FileName + "_NICK.txt");
                    while (true)
                    {
                        if (reader.EndOfStream)
                        {
                            reader.Close();
                            writer.Close();
                            this.method_99();
                            MessageBox.Show("Lọc Nick Yahoo th\x00e0nh c\x00f4ng!");
                            break;
                        }
                        string str = reader.ReadLine().ToLower();
                        if (str.IndexOf("@yahoo") >= 0)
                        {
                            writer.WriteLine(str.Substring(0, str.IndexOf("@")));
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR!" + exception.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnRegexGetContentByRegex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRegexRegex.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.picLoader.Show();
                this.string_5 = "";
                string text = this.cbRegexType.Text;
                new Thread(new ParameterizedThreadStart(this.method_89)) { IsBackground = true }.Start("Email".Equals(text));
            }
        }

        private void btnRegexGetLink_Click(object sender, EventArgs e)
        {
            string text = this.txtRegexURL.Text;
            int num = (int) this.numericRegexFrom.Value;
            int num2 = (int) this.numericRegexTo.Value;
            if (string.IsNullOrEmpty(text) || (num > num2))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string str2 = "";
                for (int i = num; i <= num2; i++)
                {
                    str2 = str2 + text.Replace("$$", i.ToString()) + "\n";
                }
                this.rtbRegexURL.Text = str2;
            }
        }

        private void btnRegexGetSource_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_107)) { IsBackground = true }.Start();
        }

        private void btnRegexReplace_Click(object sender, EventArgs e)
        {
            string str = this.txtReplaceContent.Text.Trim();
            if (!string.IsNullOrEmpty(str) && (str.IndexOf("$$") >= 0))
            {
                str = str.Replace("$$", "$Content$");
                string str2 = "";
                foreach (string str3 in Regex.Split(this.rtbRegexResult.Text, "\n"))
                {
                    if (!string.IsNullOrEmpty(str3.Trim()))
                    {
                        str2 = str2 + str.Replace("$Content$", str3) + "\n";
                    }
                }
                this.rtbRegexResult.Text = str2;
            }
        }

        private void btnRegexUrlSave_Click(object sender, EventArgs e)
        {
            this.method_28(this.rtbRegexURL.Text);
        }

        private void btnRivalCheck_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_53)) { IsBackground = true }.Start();
        }

        private void btnSaveAnalytics_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_30)) { IsBackground = true }.Start();
        }

        private void btnSaveCheck_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_27)) { IsBackground = true }.Start();
        }

        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            this.method_29(this.webMain.DocumentText);
        }

        private void btnSaveSuggest_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_32)) { IsBackground = true }.Start();
        }

        private void btnSearchBacklink_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_62)) { IsBackground = true }.Start();
            if (!this.timer_4.Enabled || (this.timer_4.Interval > 0x5265c00))
            {
                this.timer_4.Interval = 0xea60;
                this.timer_4.Enabled = true;
            }
        }

        private void btnSearchBacklinkSave_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_109)) { IsBackground = true }.Start();
        }

        private void btnSearchExport_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_64)) { IsBackground = true }.Start();
        }

        private void btnSitemap_Click(object sender, EventArgs e)
        {
            new frmSitemap().Show();
        }

        private void btnSocialAuto_Click(object sender, EventArgs e)
        {
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.bool_1 = true;
                this.btnSocialSend.PerformClick();
            }
        }

        private void btnSocialClose_Click(object sender, EventArgs e)
        {
            if (this.tabSocial.TabCount > 0)
            {
                this.tabSocial.SelectedTab.Controls[0].Dispose();
                this.tabSocial.TabPages.Remove(this.tabSocial.SelectedTab);
                this.method_99();
            }
        }

        private void btnSocialSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtSocialUrl.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.tabSocial.TabPages.Clear();
                foreach (string str2 in this.txtSocialUrl.Text.Trim().Split(new char[] { '\n' }).ToList<string>())
                {
                    if (!string.IsNullOrEmpty(str2))
                    {
                        foreach (DataRowView view in this.listSocial.SelectedItems)
                        {
                            string urlString = view[0].ToString().Replace("$url$", HttpUtility.UrlEncode(str2));
                            if ((urlString.IndexOf("plus.google.com") > 0) && !string.IsNullOrEmpty(this.txtSocialGoogleID.Text.Trim()))
                            {
                                urlString = "https://plus.google.com/u/0/b/" + this.txtSocialGoogleID.Text.Trim() + "/share?url=" + str2;
                            }
                            WebBrowser browser = new WebBrowser();
                            browser.Navigate(urlString);
                            if (this.bool_1)
                            {
                                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.method_39);
                            }
                            browser.Dock = DockStyle.Fill;
                            browser.ScriptErrorsSuppressed = true;
                            this.tabSocial.TabPages.Add(view[1].ToString());
                            this.tabSocial.SelectTab((int) (this.tabSocial.TabCount - 1));
                            this.tabSocial.SelectedTab.Controls.Add(browser);
                        }
                    }
                }
                this.bool_1 = false;
            }
        }

        private void btnSubmitAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtSubmitAddress.Text.Trim()) || (this.cbSubmitCate.SelectedValue == null))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Submits (SubmitID, CategoryID, AttributeID, Url) VALUES('", Guid.NewGuid(), "','", this.cbSubmitCate.SelectedValue, "','", this.cbAttributeCate.SelectedValue, "','", this.txtSubmitAddress.Text.Trim(), "')" };
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_60();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSubmitAttribute_Click(object sender, EventArgs e)
        {
            ((this.cbAttributeCate.SelectedValue == null) ? new frmAttribute("") : new frmAttribute(this.cbAttributeCate.SelectedValue.ToString())).ShowDialog();
            this.method_58();
        }

        private void btnSubmitAuto_Click(object sender, EventArgs e)
        {
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.timer_5.Interval = ((int) this.numSubmitTime.Value) * 0x3e8;
                if (this.btnSubmitAuto.Text.Equals("Dừng Lại"))
                {
                    this.bool_8 = false;
                    this.timer_5.Enabled = false;
                    this.timer_5.Stop();
                    this.btnSubmitAuto.Text = "Bắt Đầu";
                }
                else
                {
                    this.bool_8 = true;
                    this.btnSubmitView.PerformClick();
                    this.timer_5.Enabled = true;
                    this.timer_5.Start();
                    this.btnSubmitAuto.Text = "Dừng Lại";
                }
            }
        }

        private void btnSubmitDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Submits WHERE SubmitID='" + this.dtvSubmit.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_60();
                this.txtSubmitAddress.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            try
            {
                object[] objArray = new object[] { "UPDATE Submits SET Url='", this.txtSubmitAddress.Text.Trim(), "', AttributeID='", this.cbAttributeCate.SelectedValue, "' WHERE SubmitID='", this.dtvSubmit.CurrentRow.Cells[0].Value.ToString(), "'" };
                string str = string.Concat(objArray);
                this.gclass4_0.method_42(str);
                this.method_60();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSubmitGetSource_Click(object sender, EventArgs e)
        {
            string outerHtml = this.webSubmit.Document.Body.OuterHtml;
            string str2 = string.Empty;
            foreach (GClass9 class2 in this.gclass4_0.method_10(outerHtml.ToLower(), this.txtSubmitAddress.Text.Trim(), string.Empty))
            {
                str2 = str2 + class2.method_4() + "\n";
            }
            outerHtml = "[ M\x00e3 nguồn HTML ] \n\n" + outerHtml;
            outerHtml = ("[ Danh s\x00e1ch Link trong Website ] \n\n" + str2) + "\n\n\n\n" + outerHtml;
            this.method_28(outerHtml);
        }

        private void btnSubmitImport_Click(object sender, EventArgs e)
        {
            new frmLink().ShowDialog();
            try
            {
                foreach (string str in list_0)
                {
                    if (!string.IsNullOrEmpty(str.Trim()))
                    {
                        object[] objArray = new object[] { "INSERT INTO Submits (SubmitID, CategoryID, AttributeID, Url) VALUES('", Guid.NewGuid(), "','", this.cbSubmitCate.SelectedValue, "','", this.cbAttributeCate.SelectedValue, "','", str, "')" };
                        string str2 = string.Concat(objArray);
                        this.gclass4_0.method_42(str2);
                    }
                }
                this.method_60();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSubmitNext_Click(object sender, EventArgs e)
        {
            int index = this.dtvSubmit.CurrentRow.Index;
            if (index < (this.dtvSubmit.Rows.Count - 1))
            {
                index++;
                this.dtvSubmit.Rows[index].Selected = true;
                this.dtvSubmit.Rows[index].Cells[1].Selected = true;
                this.dtvSubmit.FirstDisplayedScrollingRowIndex = index;
                this.txtSubmitAddress.Text = this.dtvSubmit.CurrentRow.Cells[1].Value.ToString();
                this.cbAttributeCate.SelectedValue = this.dtvSubmit.CurrentRow.Cells[2].Value.ToString();
                this.btnSubmitView.PerformClick();
            }
        }

        private void btnSubmitOK_Click(object sender, EventArgs e)
        {
            if (!this.bool_5)
            {
                MessageBox.Show("H\x00e3y đợi Website tải xuống ho\x00e0n tất!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                HtmlDocument document = this.webSubmit.Document;
                string str = document.Url.ToString();
                if (str.IndexOf("accounts.google.com") > 0)
                {
                    foreach (HtmlElement element in document.GetElementsByTagName("input"))
                    {
                        if (element.OuterHtml.IndexOf("type=submit") > 0)
                        {
                            element.InvokeMember("click");
                            this.bool_8 = false;
                            this.bool_6 = false;
                            break;
                        }
                    }
                }
                else if (str.IndexOf("draft.blogger.com") <= 0)
                {
                    this.method_67();
                }
                else
                {
                    string str2 = this.txtHTMLTitle.Text.Trim();
                    string str3 = this.txtHTMLDesc.Text.Trim();
                    string str4 = this.txtHTMLKeyword.Text.Trim();
                    string str5 = this.method_76("GetContents", new object[0]).ToString().Replace("$title$", this.gclass4_0.method_21(str2)).Replace("$description$", this.gclass4_0.method_21(str3)).Replace("$keyword$", this.gclass4_0.method_21(str4));
                    str2 = this.gclass4_0.method_21(str2);
                    if (this.ckNewsAuto1.Checked && !string.IsNullOrEmpty(str4))
                    {
                        str2 = str2 + " | " + str4;
                    }
                    foreach (HtmlElement element2 in document.GetElementsByTagName("input"))
                    {
                        if (element2.OuterHtml.IndexOf("titleField textField") > 0)
                        {
                            element2.InnerText = str2;
                        }
                    }
                    string str6 = string.Empty;
                    foreach (DataRowView view in this.listHTMLCategory.SelectedItems)
                    {
                        str6 = str6 + view[0].ToString() + ",";
                    }
                    foreach (HtmlElement element3 in document.GetElementsByTagName("textarea"))
                    {
                        if ((element3.OuterHtml.IndexOf("Nhập danh s\x00e1ch c\x00e1c nh\x00e3n được ph\x00e2n c\x00e1ch bằng dấu phẩy") > 0) || (element3.OuterHtml.IndexOf("Enter a list of labels separated by comma") > 0))
                        {
                            element3.SetAttribute("value", str6);
                        }
                    }
                    HtmlElementCollection elementsByTagName = document.GetElementsByTagName("button");
                    foreach (HtmlElement element4 in elementsByTagName)
                    {
                        if (element4.OuterHtml.IndexOf("blogg-collapse-left") > 0)
                        {
                            element4.InvokeMember("click");
                        }
                    }
                    document.GetElementById("postingHtmlBox").SetAttribute("value", str5);
                    foreach (HtmlElement element5 in elementsByTagName)
                    {
                        if (element5.OuterHtml.IndexOf("2222 blogg-primary") > 0)
                        {
                            element5.InvokeMember("click");
                            break;
                        }
                    }
                }
            }
        }

        private void btnSubmitSave_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            new Thread(new ThreadStart(this.method_106)) { IsBackground = true }.Start();
        }

        private void btnSubmitSearch_Click(object sender, EventArgs e)
        {
            this.bool_3 = true;
            this.method_60();
            this.bool_3 = false;
        }

        private void btnSubmitView_Click(object sender, EventArgs e)
        {
            this.bool_6 = true;
            this.webSubmit.Navigate(this.txtSubmitAddress.Text.Trim());
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            if (this.cbDepthKey.Text.Equals("2") && !this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(this.txtKeyResearch.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_34)) { IsBackground = true }.Start();
            }
        }

        private void btnUpdateProxy_Click(object sender, EventArgs e)
        {
            WebProxy proxy = null;
            List<string> list = this.txtPingProxy.Text.Trim().Split(new char[] { ':' }).ToList<string>();
            if (list.Count == 2)
            {
                proxy = new WebProxy(list[0], Convert.ToInt32(list[1]));
            }
            this.gclass4_0.webProxy_0 = proxy;
            if (proxy != null)
            {
                MessageBox.Show("Thay đổi Proxy to\x00e0n cục th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Xo\x00e1 Proxy to\x00e0n cục th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnViewGetSite_Click(object sender, EventArgs e)
        {
            this.picLoader.Show();
            int index = 0;
            if (this.tabView.TabCount > 0)
            {
                MessageBox.Show("Tắt hết website để tiếp tục!", "Information!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                for (int i = 0; (i < this.int_20) && (i < this.list_15.Count); i++)
                {
                    string urlString = this.list_15[i].string_1;
                    WebBrowser browser = new WebBrowser();
                    browser.Navigate(urlString);
                    browser.ScriptErrorsSuppressed = true;
                    browser.Dock = DockStyle.Fill;
                    this.tabView.TabPages.Add(new Uri(urlString).Host);
                    this.tabView.SelectTab(index);
                    this.tabView.SelectedTab.Controls.Add(browser);
                    index++;
                }
                this.int_19 = 10;
                this.timer_3.Enabled = true;
                this.picLoader.Hide();
            }
        }

        private void btnViewUpdate_Click(object sender, EventArgs e)
        {
            if (!this.infoSEO_0.Website.Equals(this.txtViewWebsite.Text.Trim()))
            {
                this.infoSEO_0.Click = 0;
                this.lbViewClick.Text = "0";
            }
            this.infoSEO_0.Website = this.txtViewWebsite.Text.Trim();
            this.infoSEO_0.ClickStatus = !this.rdViewEnable.Checked ? 0 : 1;
            if (this.iSEOSoapClient_0.UpdateInfo(this.infoSEO_0))
            {
                MessageBox.Show("Cập nhật th\x00f4ng tin th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("C\x00f3 lỗi, Xin h\x00e3y thử lại!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void cbGoogleTool_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.cbGoogleTool.SelectedValue.ToString()))
                {
                    Process.Start(this.cbGoogleTool.SelectedValue.ToString());
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void cbHTMLAccount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.method_84();
        }

        private void cbHTMLContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_87();
        }

        private void cbKeyCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbKeyCate.Tag = this.cbKeyCate.SelectedValue;
        }

        private void cbKeyCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.method_26();
        }

        private void cbNewsCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.cbNewsCate.SelectedValue.ToString()))
                {
                    this.picLoader.Show();
                    new Thread(new ThreadStart(this.method_104)) { IsBackground = true }.Start();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void cbSEOOther_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.cbSEOOther.SelectedValue.ToString()))
                {
                    Process.Start(this.cbSEOOther.SelectedValue.ToString());
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void cbSubmitCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.method_60();
        }

        private void ckAnchorImage_CheckedChanged(object sender, EventArgs e)
        {
            this.method_17();
        }

        private void ckFollow_CheckedChanged(object sender, EventArgs e)
        {
            this.method_46();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dtvAdword_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtAdwordKey.Text = this.dtvAdword.CurrentRow.Cells[1].Value.ToString();
                this.txtAdwordWeb.Text = this.dtvAdword.CurrentRow.Cells[2].Value.ToString();
                this.txtAdwordExt.Text = this.dtvAdword.CurrentRow.Cells[6].Value.ToString();
                this.txtAdwordLang.Text = this.dtvAdword.CurrentRow.Cells[7].Value.ToString();
            }
            catch
            {
            }
        }

        private void dtvAdword_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvAdword.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvAdword[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvAdword_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAdword.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAdwordCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.method_71();
            }
            catch
            {
            }
        }

        private void dtvAdwordCate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAdwordCate.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnalyticsHeading_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnalyticsHeading.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnalyticsImage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvAnalyticsImage.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvAnalyticsImage[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvAnalyticsImage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnalyticsImage.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnalyticsLink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvAnalyticsLink.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvAnalyticsLink[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvAnalyticsLink_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnalyticsLink.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnalyticsWord1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnalyticsWord1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnalyticsWord2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnalyticsWord2.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnalyticsWord3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnalyticsWord3.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnalyticsWord4_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnalyticsWord4.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtArticleLink.Text = this.dtvArticle.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void dtvArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvArticle.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvArticle[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
                if (this.dtvArticle.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    bool flag;
                    this.dtvArticle[e.ColumnIndex, e.RowIndex].Value = !(flag = Convert.ToBoolean(this.dtvArticle[e.ColumnIndex, e.RowIndex].Value.ToString()));
                    flag = !flag;
                    this.gclass4_0.method_42("UPDATE Articles SET Follow=" + flag.ToString() + " WHERE ArticleID='" + this.dtvArticle.CurrentRow.Cells[0].Value.ToString() + "'");
                }
            }
            catch
            {
            }
        }

        private void dtvArticle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvArticle.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvArticleCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.method_46();
            }
            catch
            {
            }
        }

        private void dtvArticleCate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvArticleCate.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvBacklink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtBacklinkUrl.Text = this.dtvBacklink.CurrentRow.Cells[3].Value.ToString();
                this.txtBacklinkWeblink.Text = this.dtvBacklink.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void dtvBacklink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvBacklink.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvBacklink[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvBacklink_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvBacklink.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvBacklinkCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.method_42();
            }
            catch
            {
            }
        }

        private void dtvBacklinkCate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvBacklinkCate.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvCheckBacklink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvCheckBacklink.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvCheckBacklink[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvCheckBacklink_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvCheckBacklink.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvCheckResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvCheckResult.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvCheckResult[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvCheckResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_111)) { IsBackground = true }.Start();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dtvCheckResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvCheckResult.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvKeyLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtKeyword.Text = this.dtvKeyLogs.CurrentRow.Cells[1].Value.ToString();
                this.txtLang.Text = this.dtvKeyLogs.CurrentRow.Cells[6].Value.ToString();
                this.txtExt.Text = this.dtvKeyLogs.CurrentRow.Cells[7].Value.ToString();
                this.txtDomain.Text = this.dtvKeyLogs.CurrentRow.Cells[2].Value.ToString();
                this.txtWebCompare.Text = this.dtvKeyLogs.CurrentRow.Cells[8].Value.ToString();
            }
            catch
            {
            }
        }

        private void dtvKeyLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnCheck.PerformClick();
        }

        private void dtvKeyLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvKeyLogs.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvKTList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvKTList.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvNews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvNews.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    string urlString = this.dtvNews[e.ColumnIndex, e.RowIndex].Value.ToString();
                    frmBrowser browser = new frmBrowser();
                    browser.webBrowser.Navigate(urlString);
                    browser.ShowDialog();
                }
                if (this.dtvNews.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    bool flag = Convert.ToBoolean(this.dtvNews[e.ColumnIndex, e.RowIndex].Value.ToString());
                    this.gclass4_0.method_42("UPDATE NewsLogs SET [Status]=" + !flag.ToString() + " WHERE NewsLogID='" + this.dtvNews.CurrentRow.Cells[0].Value.ToString() + "'");
                    this.dtvNews[e.ColumnIndex, e.RowIndex].Value = !flag;
                }
            }
            catch
            {
            }
        }

        private void dtvNews_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                MessageBox.Show("Chức năng d\x00e0nh cho iSEO Premium! - Hotline: 0982 489 833", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    this.picLoader.Show();
                    new Thread(new ThreadStart(this.method_78)) { IsBackground = true }.Start();
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void dtvNews_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvNews.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvNewsCate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtNewsCate.Text = this.dtvNewsCate.CurrentRow.Cells[1].Value.ToString();
                this.picLoader.Show();
                new Thread(new ParameterizedThreadStart(this.method_79)) { IsBackground = true }.Start(true);
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dtvNewsCate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvNewsCate.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvPingProxy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnPingWebView.PerformClick();
        }

        private void dtvPingProxy_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvPingProxy.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvResultCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvResultCheck.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvResultCheck[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvRivalHigh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.tbMain.SelectTab("tbKeyword");
                this.txtKeyword.Text = this.dtvRivalHigh.CurrentRow.Cells[0].Value.ToString();
                this.txtDomain.Text = this.txtRivalDomain.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dtvRivalList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.tbMain.SelectTab("tbKeyword");
                this.txtKeyword.Text = this.dtvRivalList.CurrentRow.Cells[0].Value.ToString();
                this.txtDomain.Text = this.txtRivalDomain.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dtvRivalMonth1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.tbMain.SelectTab("tbKeyword");
                this.txtKeyword.Text = this.dtvRivalTop.CurrentRow.Cells[0].Value.ToString();
                this.txtDomain.Text = this.txtRivalDomain.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dtvRivalMonth1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvRivalMonth1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvRivalMonth2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.tbMain.SelectTab("tbKeyword");
                this.txtKeyword.Text = this.dtvRivalMonth2.CurrentRow.Cells[0].Value.ToString();
                this.txtDomain.Text = this.txtRivalDomain.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dtvRivalMonth2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvRivalMonth2.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvRivalTop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.tbMain.SelectTab("tbKeyword");
                this.txtKeyword.Text = this.dtvRivalTop.CurrentRow.Cells[0].Value.ToString();
                this.txtDomain.Text = this.txtRivalDomain.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dtvRivalTop_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvRivalTop.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvSearchBacklink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvSearchBacklink.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvSearchBacklink[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvSearchBacklink_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvSearchBacklink.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvSubmit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtSubmitAddress.Text = this.dtvSubmit.CurrentRow.Cells[1].Value.ToString();
                this.cbAttributeCate.SelectedValue = this.dtvSubmit.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
            }
        }

        private void dtvSubmit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtSubmitAddress.Text = this.dtvSubmit.CurrentRow.Cells[1].Value.ToString();
                this.btnSubmitView.PerformClick();
            }
            catch
            {
            }
        }

        private void dtvSubmit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvSubmit.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvSuggest_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvSuggest.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvTags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtKeyFilter.Text = this.dtvTags.CurrentRow.Cells[0].Value.ToString();
                this.btnKeyFilter.PerformClick();
            }
            catch
            {
            }
        }

        private void dtvTags_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvTags.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string str = "<RSAKeyValue><Modulus>wFEjE5yiTXL3r8n9QQvpXgSbuEYwGQXxFpBZrLQct8ENPUInhxr/ywSjMj3UfUWow75qvE7ccIZN+DroPNDcIrr596PO2ztOVRxuPaikTpC1H0xldvpR3p3sLpfH+e9NMXS40ACh11irux5JTx1qbNiriucrT2BASPuNR2dmC4s=</Modulus><Exponent>AQAB</Exponent><P>/vvf9WSuOYwCfhd24ymEDBPzu28spX0Jq6UxeYVEa1EBWIRgjUCs3TuSluYSlJ7uShAhUTyZwdvuDbbCpl9Rbw==</P><Q>wRVU6INfs/198fjA2TusUg/QtFq8VmqJpTAUmPsqDanJlecW1g4CwHKzX1+KAWgkjBke3LVPHW/p3t0PNtzhpQ==</Q><DP>0kmlxXrYGQu4DoeJfAUEKvXVgBJLDtxVOmMNr3vSFnODGZ5rBnN9XSNBXQO39Swxt5Ef+SByaifYZyT/2TgpLw==</DP><DQ>a4/TnjfZb66Oo+a8oAezJn/y9xX5B3cQOPrA7rw0oCnux9hVi2eAtu7u5/mUKtZ2TamM3M0QRsjakzG40QpZlQ==</DQ><InverseQ>pAOfuf0RikJ1vIyTIfGBVTP9vxl6DNavbqd/0g7UCz38bH/qeEmhdZhCSlUFswG95do6snWexpobyLsmoEeYpg==</InverseQ><D>gX7g0Jbazq3ITC0Fg6QiqnUN6cIRJvhSQzBFwb2xzKWIZaRC+31ZmflwbicmCog6QDvaoRu04Wv92lTIBhNY9jgdPPGHHNzt2YqK8RAH3CyOpZEAiVczearZ7w23hBfTGkf6kt20nX8Spa2g97ikVHp2Axy/ot7YObysitHSpXk=</D></RSAKeyValue>";
            this.infoSEO_0.Password = this.gclass18_0.method_2(this.infoSEO_0.Password, 0x400, str);
            this.infoSEO_0.Permission = this.gclass18_0.method_2(this.infoSEO_0.Permission, 0x400, str);
            string str2 = "%$#*ghh0-0-9=--idf460e8tu2io3u89y7sd gksh0-0-9=--idf460e8t_)+!(~*($%#$((djkn[][]-098@klldfslf";
            this.string_2 = str2 + this.infoSEO_0.Email + this.infoSEO_0.Password + "PREMIUM";
            string message = this.infoSEO_0.Message;
            if (string.IsNullOrEmpty(message) || (message.IndexOf(this.lbUpdate.Text) > 0))
            {
                this.lbUpdate.Text = "iSEO Update: " + this.lbUpdate.Text;
            }
            else if (message.IndexOf(this.lbUpdate.Text) < 0)
            {
                this.lbUpdate.Text = message;
            }
        }

        [DllImport("KERNEL32.DLL", CallingConvention=CallingConvention.StdCall, SetLastError=true)]
        internal static extern IntPtr GetCurrentProcess();
        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            DataGridViewCellStyle style9 = new DataGridViewCellStyle();
            DataGridViewCellStyle style10 = new DataGridViewCellStyle();
            DataGridViewCellStyle style11 = new DataGridViewCellStyle();
            DataGridViewCellStyle style12 = new DataGridViewCellStyle();
            DataGridViewCellStyle style13 = new DataGridViewCellStyle();
            DataGridViewCellStyle style14 = new DataGridViewCellStyle();
            DataGridViewCellStyle style15 = new DataGridViewCellStyle();
            DataGridViewCellStyle style16 = new DataGridViewCellStyle();
            DataGridViewCellStyle style17 = new DataGridViewCellStyle();
            DataGridViewCellStyle style18 = new DataGridViewCellStyle();
            DataGridViewCellStyle style19 = new DataGridViewCellStyle();
            DataGridViewCellStyle style20 = new DataGridViewCellStyle();
            DataGridViewCellStyle style21 = new DataGridViewCellStyle();
            DataGridViewCellStyle style22 = new DataGridViewCellStyle();
            DataGridViewCellStyle style23 = new DataGridViewCellStyle();
            DataGridViewCellStyle style24 = new DataGridViewCellStyle();
            DataGridViewCellStyle style25 = new DataGridViewCellStyle();
            DataGridViewCellStyle style26 = new DataGridViewCellStyle();
            DataGridViewCellStyle style27 = new DataGridViewCellStyle();
            DataGridViewCellStyle style28 = new DataGridViewCellStyle();
            DataGridViewCellStyle style29 = new DataGridViewCellStyle();
            DataGridViewCellStyle style30 = new DataGridViewCellStyle();
            DataGridViewCellStyle style31 = new DataGridViewCellStyle();
            DataGridViewCellStyle style32 = new DataGridViewCellStyle();
            DataGridViewCellStyle style33 = new DataGridViewCellStyle();
            DataGridViewCellStyle style34 = new DataGridViewCellStyle();
            DataGridViewCellStyle style35 = new DataGridViewCellStyle();
            DataGridViewCellStyle style36 = new DataGridViewCellStyle();
            DataGridViewCellStyle style37 = new DataGridViewCellStyle();
            DataGridViewCellStyle style38 = new DataGridViewCellStyle();
            DataGridViewCellStyle style39 = new DataGridViewCellStyle();
            DataGridViewCellStyle style40 = new DataGridViewCellStyle();
            DataGridViewCellStyle style41 = new DataGridViewCellStyle();
            DataGridViewCellStyle style42 = new DataGridViewCellStyle();
            DataGridViewCellStyle style43 = new DataGridViewCellStyle();
            DataGridViewCellStyle style44 = new DataGridViewCellStyle();
            DataGridViewCellStyle style45 = new DataGridViewCellStyle();
            DataGridViewCellStyle style46 = new DataGridViewCellStyle();
            DataGridViewCellStyle style47 = new DataGridViewCellStyle();
            DataGridViewCellStyle style48 = new DataGridViewCellStyle();
            DataGridViewCellStyle style49 = new DataGridViewCellStyle();
            DataGridViewCellStyle style50 = new DataGridViewCellStyle();
            DataGridViewCellStyle style51 = new DataGridViewCellStyle();
            DataGridViewCellStyle style52 = new DataGridViewCellStyle();
            DataGridViewCellStyle style53 = new DataGridViewCellStyle();
            DataGridViewCellStyle style54 = new DataGridViewCellStyle();
            DataGridViewCellStyle style55 = new DataGridViewCellStyle();
            DataGridViewCellStyle style56 = new DataGridViewCellStyle();
            DataGridViewCellStyle style57 = new DataGridViewCellStyle();
            DataGridViewCellStyle style58 = new DataGridViewCellStyle();
            DataGridViewCellStyle style59 = new DataGridViewCellStyle();
            DataGridViewCellStyle style60 = new DataGridViewCellStyle();
            DataGridViewCellStyle style61 = new DataGridViewCellStyle();
            DataGridViewCellStyle style62 = new DataGridViewCellStyle();
            DataGridViewCellStyle style63 = new DataGridViewCellStyle();
            DataGridViewCellStyle style64 = new DataGridViewCellStyle();
            DataGridViewCellStyle style65 = new DataGridViewCellStyle();
            DataGridViewCellStyle style66 = new DataGridViewCellStyle();
            DataGridViewCellStyle style67 = new DataGridViewCellStyle();
            DataGridViewCellStyle style68 = new DataGridViewCellStyle();
            DataGridViewCellStyle style69 = new DataGridViewCellStyle();
            DataGridViewCellStyle style70 = new DataGridViewCellStyle();
            DataGridViewCellStyle style71 = new DataGridViewCellStyle();
            DataGridViewCellStyle style72 = new DataGridViewCellStyle();
            DataGridViewCellStyle style73 = new DataGridViewCellStyle();
            DataGridViewCellStyle style74 = new DataGridViewCellStyle();
            DataGridViewCellStyle style75 = new DataGridViewCellStyle();
            DataGridViewCellStyle style76 = new DataGridViewCellStyle();
            DataGridViewCellStyle style77 = new DataGridViewCellStyle();
            DataGridViewCellStyle style78 = new DataGridViewCellStyle();
            DataGridViewCellStyle style79 = new DataGridViewCellStyle();
            DataGridViewCellStyle style80 = new DataGridViewCellStyle();
            DataGridViewCellStyle style81 = new DataGridViewCellStyle();
            DataGridViewCellStyle style82 = new DataGridViewCellStyle();
            DataGridViewCellStyle style83 = new DataGridViewCellStyle();
            DataGridViewCellStyle style84 = new DataGridViewCellStyle();
            DataGridViewCellStyle style85 = new DataGridViewCellStyle();
            DataGridViewCellStyle style86 = new DataGridViewCellStyle();
            DataGridViewCellStyle style87 = new DataGridViewCellStyle();
            DataGridViewCellStyle style88 = new DataGridViewCellStyle();
            DataGridViewCellStyle style89 = new DataGridViewCellStyle();
            DataGridViewCellStyle style90 = new DataGridViewCellStyle();
            DataGridViewCellStyle style91 = new DataGridViewCellStyle();
            DataGridViewCellStyle style92 = new DataGridViewCellStyle();
            DataGridViewCellStyle style93 = new DataGridViewCellStyle();
            DataGridViewCellStyle style94 = new DataGridViewCellStyle();
            DataGridViewCellStyle style95 = new DataGridViewCellStyle();
            DataGridViewCellStyle style96 = new DataGridViewCellStyle();
            DataGridViewCellStyle style97 = new DataGridViewCellStyle();
            DataGridViewCellStyle style98 = new DataGridViewCellStyle();
            DataGridViewCellStyle style99 = new DataGridViewCellStyle();
            DataGridViewCellStyle style100 = new DataGridViewCellStyle();
            DataGridViewCellStyle style101 = new DataGridViewCellStyle();
            DataGridViewCellStyle style102 = new DataGridViewCellStyle();
            DataGridViewCellStyle style103 = new DataGridViewCellStyle();
            DataGridViewCellStyle style104 = new DataGridViewCellStyle();
            DataGridViewCellStyle style105 = new DataGridViewCellStyle();
            DataGridViewCellStyle style106 = new DataGridViewCellStyle();
            DataGridViewCellStyle style107 = new DataGridViewCellStyle();
            DataGridViewCellStyle style108 = new DataGridViewCellStyle();
            DataGridViewCellStyle style109 = new DataGridViewCellStyle();
            DataGridViewCellStyle style110 = new DataGridViewCellStyle();
            DataGridViewCellStyle style111 = new DataGridViewCellStyle();
            DataGridViewCellStyle style112 = new DataGridViewCellStyle();
            DataGridViewCellStyle style113 = new DataGridViewCellStyle();
            DataGridViewCellStyle style114 = new DataGridViewCellStyle();
            DataGridViewCellStyle style115 = new DataGridViewCellStyle();
            DataGridViewCellStyle style116 = new DataGridViewCellStyle();
            DataGridViewCellStyle style117 = new DataGridViewCellStyle();
            DataGridViewCellStyle style118 = new DataGridViewCellStyle();
            DataGridViewCellStyle style119 = new DataGridViewCellStyle();
            DataGridViewCellStyle style120 = new DataGridViewCellStyle();
            DataGridViewCellStyle style121 = new DataGridViewCellStyle();
            DataGridViewCellStyle style122 = new DataGridViewCellStyle();
            DataGridViewCellStyle style123 = new DataGridViewCellStyle();
            DataGridViewCellStyle style124 = new DataGridViewCellStyle();
            DataGridViewCellStyle style125 = new DataGridViewCellStyle();
            DataGridViewCellStyle style126 = new DataGridViewCellStyle();
            DataGridViewCellStyle style127 = new DataGridViewCellStyle();
            DataGridViewCellStyle style128 = new DataGridViewCellStyle();
            DataGridViewCellStyle style129 = new DataGridViewCellStyle();
            DataGridViewCellStyle style130 = new DataGridViewCellStyle();
            DataGridViewCellStyle style131 = new DataGridViewCellStyle();
            DataGridViewCellStyle style132 = new DataGridViewCellStyle();
            DataGridViewCellStyle style133 = new DataGridViewCellStyle();
            DataGridViewCellStyle style134 = new DataGridViewCellStyle();
            DataGridViewCellStyle style135 = new DataGridViewCellStyle();
            DataGridViewCellStyle style136 = new DataGridViewCellStyle();
            DataGridViewCellStyle style137 = new DataGridViewCellStyle();
            DataGridViewCellStyle style138 = new DataGridViewCellStyle();
            DataGridViewCellStyle style139 = new DataGridViewCellStyle();
            DataGridViewCellStyle style140 = new DataGridViewCellStyle();
            DataGridViewCellStyle style141 = new DataGridViewCellStyle();
            DataGridViewCellStyle style142 = new DataGridViewCellStyle();
            DataGridViewCellStyle style143 = new DataGridViewCellStyle();
            DataGridViewCellStyle style144 = new DataGridViewCellStyle();
            DataGridViewCellStyle style145 = new DataGridViewCellStyle();
            DataGridViewCellStyle style146 = new DataGridViewCellStyle();
            DataGridViewCellStyle style147 = new DataGridViewCellStyle();
            DataGridViewCellStyle style148 = new DataGridViewCellStyle();
            DataGridViewCellStyle style149 = new DataGridViewCellStyle();
            DataGridViewCellStyle style150 = new DataGridViewCellStyle();
            DataGridViewCellStyle style151 = new DataGridViewCellStyle();
            DataGridViewCellStyle style152 = new DataGridViewCellStyle();
            DataGridViewCellStyle style153 = new DataGridViewCellStyle();
            DataGridViewCellStyle style154 = new DataGridViewCellStyle();
            DataGridViewCellStyle style155 = new DataGridViewCellStyle();
            DataGridViewCellStyle style156 = new DataGridViewCellStyle();
            DataGridViewCellStyle style157 = new DataGridViewCellStyle();
            DataGridViewCellStyle style158 = new DataGridViewCellStyle();
            DataGridViewCellStyle style159 = new DataGridViewCellStyle();
            DataGridViewCellStyle style160 = new DataGridViewCellStyle();
            DataGridViewCellStyle style161 = new DataGridViewCellStyle();
            DataGridViewCellStyle style162 = new DataGridViewCellStyle();
            DataGridViewCellStyle style163 = new DataGridViewCellStyle();
            DataGridViewCellStyle style164 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmMain));
            this.toolStripStatusLabel2 = new ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new ToolStripStatusLabel();
            this.toolStripLabel1 = new ToolStripLabel();
            this.tbSeoTool = new TabPage();
            this.groupBox17 = new GroupBox();
            this.label32 = new Label();
            this.txtLinkSitemap = new TextBox();
            this.btnPingSitemap = new Button();
            this.groupBox27 = new GroupBox();
            this.btnCheckGoogleIndex = new Button();
            this.label65 = new Label();
            this.label63 = new Label();
            this.txtCheckIndexUrl = new TextBox();
            this.txtCheckIndexKey = new TextBox();
            this.groupBox4 = new GroupBox();
            this.btnCheckWeb = new Button();
            this.label10 = new Label();
            this.txtWebReport = new TextBox();
            this.cbWebReport = new ComboBox();
            this.groupBox21 = new GroupBox();
            this.cbGoogleTool = new ComboBox();
            this.cbSEOOther = new ComboBox();
            this.groupBox20 = new GroupBox();
            this.btnCheckResultSave = new PictureBox();
            this.dtvCheckResult = new DataGridView();
            this.GiaTri = new DataGridViewTextBoxColumn();
            this.CheckUrl = new DataGridViewLinkColumn();
            this.btnCheckPR = new Button();
            this.label50 = new Label();
            this.btnCheckPlus = new Button();
            this.label5 = new Label();
            this.btnOpenLink = new Button();
            this.groupBox22 = new GroupBox();
            this.btnSitemap = new Button();
            this.label42 = new Label();
            this.groupBox3 = new GroupBox();
            this.dtvResultCheck = new DataGridView();
            this.SEOTools = new DataGridViewTextBoxColumn();
            this.Link = new DataGridViewLinkColumn();
            this.btnSaveCheck = new PictureBox();
            this.label8 = new Label();
            this.txtWebsiteCheck = new TextBox();
            this.btnCheckIndex = new Button();
            this.tbPingURL = new TabPage();
            this.groupBox39 = new GroupBox();
            this.btnCheckProxy = new Button();
            this.dtvPingProxy = new DataGridView();
            this.dataGridViewTextBoxColumn36 = new DataGridViewTextBoxColumn();
            this.btnImportProxy = new Button();
            this.btnGetProxy = new Button();
            this.groupBox16 = new GroupBox();
            this.numPingView = new NumericUpDown();
            this.label7 = new Label();
            this.label28 = new Label();
            this.btnPingViewAuto = new Button();
            this.webProxy = new GClass2();
            this.btnPingProxyRemove = new Button();
            this.btnPingWebView = new Button();
            this.label6 = new Label();
            this.txtPingWebUrl = new TextBox();
            this.groupBox2 = new GroupBox();
            this.txtPingUrl = new RichTextBox();
            this.btnUpdateProxy = new Button();
            this.txtPingProxy = new TextBox();
            this.label12 = new Label();
            this.txtPingTitle = new TextBox();
            this.label31 = new Label();
            this.btnPing = new Button();
            this.tbKeyword = new TabPage();
            this.btnKeyListSave = new PictureBox();
            this.btnSavePosition = new PictureBox();
            this.btnKeyCheckAll = new Button();
            this.cbKeyCate = new ComboBox();
            this.dtvKeyLogs = new DataGridView();
            this.ID = new DataGridViewTextBoxColumn();
            this.Keyword = new DataGridViewTextBoxColumn();
            this.Website = new DataGridViewTextBoxColumn();
            this.SERPCount = new DataGridViewTextBoxColumn();
            this.Rank = new DataGridViewTextBoxColumn();
            this.TopOld = new DataGridViewTextBoxColumn();
            this.Lang = new DataGridViewTextBoxColumn();
            this.Ext = new DataGridViewTextBoxColumn();
            this.Column20 = new DataGridViewTextBoxColumn();
            this.mnuKey = new ContextMenuStrip(this.icontainer_0);
            this.btnKeyCheck = new ToolStripMenuItem();
            this.btnKeyDelete = new ToolStripMenuItem();
            this.webMain = new WebBrowser();
            this.groupBox1 = new GroupBox();
            this.ckTopMobile = new CheckBox();
            this.txtExt = new TextBox();
            this.label1 = new Label();
            this.btnCheck = new Button();
            this.btnKeySave = new Button();
            this.btnKeyAdd = new Button();
            this.txtKeyword = new TextBox();
            this.txtWebCompare = new TextBox();
            this.txtDomain = new TextBox();
            this.label20 = new Label();
            this.label3 = new Label();
            this.txtLang = new TextBox();
            this.label24 = new Label();
            this.label2 = new Label();
            this.label19 = new Label();
            this.btnKeyCateAdd = new PictureBox();
            this.tbMain = new TabControl();
            this.tbKeyResearch = new TabPage();
            this.groupBox19 = new GroupBox();
            this.webKeyRelated = new WebBrowser();
            this.groupBox15 = new GroupBox();
            this.lbTagsTotal = new Label();
            this.dtvTags = new DataGridView();
            this.Key2 = new DataGridViewTextBoxColumn();
            this.Loop2 = new DataGridViewTextBoxColumn();
            this.groupBox14 = new GroupBox();
            this.dtvSuggest = new GClass23();
            this.Key = new DataGridViewTextBoxColumn();
            this.Top = new DataGridViewTextBoxColumn();
            this.Result = new DataGridViewTextBoxColumn();
            this.Loop = new DataGridViewTextBoxColumn();
            this.mnuSuggest = new ContextMenuStrip(this.icontainer_0);
            this.mbtnSERP = new ToolStripMenuItem();
            this.mbtnSearch = new ToolStripMenuItem();
            this.mbtnTopGoogle = new ToolStripMenuItem();
            this.mbtnResearch = new ToolStripMenuItem();
            this.mbtnInsights = new ToolStripMenuItem();
            this.btnSaveSuggest = new PictureBox();
            this.lbSuggestTotal = new Label();
            this.btnKeyFilter = new Button();
            this.label27 = new Label();
            this.label29 = new Label();
            this.txtKeyFilter = new TextBox();
            this.groupBox13 = new GroupBox();
            this.btnCheckSERP = new Button();
            this.cbDepthKey = new ComboBox();
            this.label9 = new Label();
            this.txtExtSuggest = new TextBox();
            this.label22 = new Label();
            this.btnSuggest = new Button();
            this.label4 = new Label();
            this.txtKeyResearch = new TextBox();
            this.label26 = new Label();
            this.txtLangSuggest = new TextBox();
            this.tbKeywordTool = new TabPage();
            this.groupBox37 = new GroupBox();
            this.btnKTCheckSERP = new Button();
            this.label90 = new Label();
            this.btnKTSave = new PictureBox();
            this.btnKTCheckDomain = new Button();
            this.label92 = new Label();
            this.label91 = new Label();
            this.txtKTExt = new TextBox();
            this.btnKTFilter = new Button();
            this.txtKTDomain = new TextBox();
            this.label89 = new Label();
            this.txtKTKeyFilter = new TextBox();
            this.dtvKTList = new DataGridView();
            this.TuKhoa = new DataGridViewTextBoxColumn();
            this.CanhTranh = new DataGridViewTextBoxColumn();
            this.TimKiemToanCau = new DataGridViewTextBoxColumn();
            this.TimKiemCucBo = new DataGridViewTextBoxColumn();
            this.SERP = new DataGridViewTextBoxColumn();
            this.KEI1 = new DataGridViewTextBoxColumn();
            this.KEI2 = new DataGridViewTextBoxColumn();
            this.mnuSuggest_1 = new ContextMenuStrip(this.icontainer_0);
            this.btnmKTSearch = new ToolStripMenuItem();
            this.btnmKTSERP = new ToolStripMenuItem();
            this.btnmKTCheckDomain = new ToolStripMenuItem();
            this.btnmKTInsight = new ToolStripMenuItem();
            this.groupBox36 = new GroupBox();
            this.cbKTBrowser = new ComboBox();
            this.btnKTRegister = new Button();
            this.btnKTLogin = new Button();
            this.btnKTSend = new Button();
            this.label85 = new Label();
            this.label84 = new Label();
            this.label88 = new Label();
            this.label87 = new Label();
            this.label86 = new Label();
            this.txtKTPass = new TextBox();
            this.txtKTEmail = new TextBox();
            this.txtKTLang = new TextBox();
            this.txtKTPosition = new TextBox();
            this.txtKTKey = new TextBox();
            this.tbWebAnalytics = new TabPage();
            this.groupBox10 = new GroupBox();
            this.radioURL2 = new RadioButton();
            this.radioURL1 = new RadioButton();
            this.panel1 = new Panel();
            this.btnAnalyticsLinkSave = new PictureBox();
            this.dtvAnalytics = new DataGridView();
            this.MoTa = new DataGridViewTextBoxColumn();
            this.GaiTri = new DataGridViewTextBoxColumn();
            this.TuKhoaOnpage = new DataGridViewTextBoxColumn();
            this.SoLanXuatHien = new DataGridViewTextBoxColumn();
            this.btnSaveAnalytics = new PictureBox();
            this.ckAnchorError = new CheckBox();
            this.ckAnchorTitle = new CheckBox();
            this.ckAnchorNofollow = new CheckBox();
            this.ckAnchorExternal = new CheckBox();
            this.ckAnchorImage = new CheckBox();
            this.btnCheckError = new Button();
            this.label48 = new Label();
            this.txtAnalyticsHTML = new RichTextBox();
            this.dtvAnalyticsWord4 = new DataGridView();
            this.dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            this.dtvAnalyticsWord3 = new DataGridView();
            this.dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            this.dtvAnalyticsWord2 = new DataGridView();
            this.dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            this.dtvAnalyticsWord1 = new DataGridView();
            this.KeyKey1 = new DataGridViewTextBoxColumn();
            this.KeyDensity1 = new DataGridViewTextBoxColumn();
            this.KeyLoop1 = new DataGridViewTextBoxColumn();
            this.dtvAnalyticsImage = new DataGridView();
            this.dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            this.ImageAlt = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new DataGridViewLinkColumn();
            this.lbAnalyticsImage = new Label();
            this.dtvAnalyticsHeading = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.label47 = new Label();
            this.label46 = new Label();
            this.label45 = new Label();
            this.label44 = new Label();
            this.lbAnalyticsHeading = new Label();
            this.dtvAnalyticsLink = new DataGridView();
            this.dataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
            this.AnalyticsName = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new DataGridViewTextBoxColumn();
            this.AnalyticsUrl = new DataGridViewLinkColumn();
            this.AnalyticsTitle = new DataGridViewTextBoxColumn();
            this.AnalyticsRel = new DataGridViewTextBoxColumn();
            this.Analytics404 = new DataGridViewTextBoxColumn();
            this.AnalyticsType = new DataGridViewTextBoxColumn();
            this.AnalyticsImg = new DataGridViewTextBoxColumn();
            this.lbAnalyticsAnchor = new Label();
            this.label21 = new Label();
            this.label23 = new Label();
            this.txtKeywordAnalytics = new TextBox();
            this.txtWebsiteUrl2 = new TextBox();
            this.txtWebsiteUrl = new TextBox();
            this.btnOptimize = new Button();
            this.btnAnalyticsCompare = new Button();
            this.btnAnalytics = new Button();
            this.tbCheckBacklink = new TabPage();
            this.groupBox26 = new GroupBox();
            this.btnCheckBacklinkSave = new PictureBox();
            this.btnCheckBacklinkFilter = new Button();
            this.label16 = new Label();
            this.label64 = new Label();
            this.dtvCheckBacklink = new DataGridView();
            this.dataGridViewTextBoxColumn31 = new DataGridViewTextBoxColumn();
            this.Column9 = new DataGridViewTextBoxColumn();
            this.Column11 = new DataGridViewLinkColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.btnCheckBLOK = new Button();
            this.txtCheckBacklinkExt = new TextBox();
            this.txtCheckBLUrl = new TextBox();
            this.tbSearchBL = new TabPage();
            this.groupBox18 = new GroupBox();
            this.btnSearchBacklinkSave = new PictureBox();
            this.label77 = new Label();
            this.btnSearchExport = new Button();
            this.label59 = new Label();
            this.label58 = new Label();
            this.txtSearchBLKey = new TextBox();
            this.txtSearchBLExt = new TextBox();
            this.txtSearchBLGExt = new TextBox();
            this.cbSearchBLFilter = new ComboBox();
            this.label60 = new Label();
            this.btnSearchBacklink = new Button();
            this.label55 = new Label();
            this.label57 = new Label();
            this.txtSearchBLLang = new TextBox();
            this.dtvSearchBacklink = new DataGridView();
            this.SearchWebsite = new DataGridViewLinkColumn();
            this.SearchExt = new DataGridViewTextBoxColumn();
            this.SearchPR = new DataGridViewTextBoxColumn();
            this.SearchLoop = new DataGridViewTextBoxColumn();
            this.tbSocial = new TabPage();
            this.groupBox5 = new GroupBox();
            this.label43 = new Label();
            this.txtSocialGoogleID = new TextBox();
            this.label14 = new Label();
            this.txtSocialUrl = new RichTextBox();
            this.btnSocialAuto = new Button();
            this.btnSocialClose = new PictureBox();
            this.tabSocial = new TabControl();
            this.btnSocialSend = new Button();
            this.listSocial = new ListBox();
            this.label17 = new Label();
            this.label13 = new Label();
            this.tbAdword = new TabPage();
            this.groupBox28 = new GroupBox();
            this.label74 = new Label();
            this.label73 = new Label();
            this.txtAdwordWeb = new TextBox();
            this.txtAdwordExt = new TextBox();
            this.label71 = new Label();
            this.label72 = new Label();
            this.label68 = new Label();
            this.txtAdwordLang = new TextBox();
            this.label70 = new Label();
            this.txtAdwordKey = new TextBox();
            this.btnAdwordSearch = new PictureBox();
            this.btnAdwordCheck = new Button();
            this.btnAdwordDelete = new PictureBox();
            this.btnAdwordEdit = new PictureBox();
            this.btnAdwordAdd = new PictureBox();
            this.dtvAdword = new DataGridView();
            this.dataGridViewTextBoxColumn30 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn3 = new DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn33 = new DataGridViewTextBoxColumn();
            this.Column12 = new DataGridViewTextBoxColumn();
            this.Column16 = new DataGridViewTextBoxColumn();
            this.Column13 = new DataGridViewTextBoxColumn();
            this.Column14 = new DataGridViewTextBoxColumn();
            this.mnuArticle = new ContextMenuStrip(this.icontainer_0);
            this.btnArticleCheckOne = new ToolStripMenuItem();
            this.btnArticleOpenChange = new ToolStripMenuItem();
            this.btnArticleOpenAll = new ToolStripMenuItem();
            this.btnArticleRemove = new ToolStripMenuItem();
            this.groupBox29 = new GroupBox();
            this.btnAdwordCateSearch = new PictureBox();
            this.btnAdwordCateAdd = new PictureBox();
            this.dtvAdwordCate = new DataGridView();
            this.dataGridViewTextBoxColumn34 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new DataGridViewTextBoxColumn();
            this.txtAdwordCate = new TextBox();
            this.tbView = new TabPage();
            this.groupBox38 = new GroupBox();
            this.rdViewDisable = new RadioButton();
            this.rdViewEnable = new RadioButton();
            this.btnExitsWebsite = new Button();
            this.label94 = new Label();
            this.lbViewTime = new Label();
            this.lbViewClick = new Label();
            this.lbViewCoin = new Label();
            this.txtViewWebsite = new TextBox();
            this.btnViewGetSite = new Button();
            this.btnViewUpdate = new Button();
            this.tabView = new TabControl();
            this.label61 = new Label();
            this.label41 = new Label();
            this.label93 = new Label();
            this.tbRival = new TabPage();
            this.groupBox9 = new GroupBox();
            this.txtRivalDomain = new TextBox();
            this.btnRivalCheck = new Button();
            this.dtvRivalMonth2 = new DataGridView();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.dtvRivalMonth1 = new DataGridView();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dtvRivalList = new DataGridView();
            this.dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.dtvRivalHigh = new DataGridView();
            this.dataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
            this.dtvRivalTop = new DataGridView();
            this.dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            this.label36 = new Label();
            this.label37 = new Label();
            this.label33 = new Label();
            this.label38 = new Label();
            this.label25 = new Label();
            this.Domain = new Label();
            this.tbBacklink = new TabPage();
            this.groupBox11 = new GroupBox();
            this.btnBacklinkSearch = new PictureBox();
            this.btnBacklinkDelete = new PictureBox();
            this.btnBacklinkEdit = new PictureBox();
            this.label35 = new Label();
            this.label34 = new Label();
            this.btnBacklinkAdd = new PictureBox();
            this.dtvBacklink = new DataGridView();
            this.BacklinkID = new DataGridViewTextBoxColumn();
            this.BacklinkName = new DataGridViewTextBoxColumn();
            this.BacklinkTitle = new DataGridViewTextBoxColumn();
            this.BacklinkUrl = new DataGridViewLinkColumn();
            this.BacklinkWebsite = new DataGridViewLinkColumn();
            this.BacklinkPR = new DataGridViewTextBoxColumn();
            this.BacklinkRel = new DataGridViewTextBoxColumn();
            this.BacklinkDensity = new DataGridViewTextBoxColumn();
            this.BacklinkIndex = new DataGridViewTextBoxColumn();
            this.btnBacklinkCheck = new Button();
            this.txtBacklinkUrl = new TextBox();
            this.txtBacklinkWeblink = new TextBox();
            this.groupBox8 = new GroupBox();
            this.btnBacklinkCateSearch = new PictureBox();
            this.btnBacklinkCateAdd = new PictureBox();
            this.dtvBacklinkCate = new DataGridView();
            this.CateID = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            this.txtBacklinkCate = new TextBox();
            this.tbNews = new TabPage();
            this.groupBox25 = new GroupBox();
            this.ckNewsAuto4 = new CheckBox();
            this.ckNewsAuto3 = new CheckBox();
            this.ckNewsAuto1 = new CheckBox();
            this.ckNewsAuto2 = new CheckBox();
            this.btnNewsAuto = new Button();
            this.groupBox24 = new GroupBox();
            this.dtvNews = new DataGridView();
            this.Column15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new DataGridViewTextBoxColumn();
            this.Column19 = new DataGridViewTextBoxColumn();
            this.Column18 = new DataGridViewLinkColumn();
            this.Column10 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.Column17 = new DataGridViewTextBoxColumn();
            this.Column21 = new DataGridViewCheckBoxColumn();
            this.groupBox30 = new GroupBox();
            this.cbNewsCate = new ComboBox();
            this.btnNewsCateSearch = new PictureBox();
            this.btnNewsCateAdd = new PictureBox();
            this.dtvNewsCate = new DataGridView();
            this.dataGridViewTextBoxColumn45 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new DataGridViewTextBoxColumn();
            this.txtNewsCate = new TextBox();
            this.tbHTML = new TabPage();
            this.btnHTMLCode = new Button();
            this.btnHTMLBBcode = new Button();
            this.btnHTMLBold = new Button();
            this.txtHTMLDesc = new RichTextBox();
            this.groupBox34 = new GroupBox();
            this.numericHTMLRandomContent = new NumericUpDown();
            this.label80 = new Label();
            this.label78 = new Label();
            this.btnHTMLAddContent = new PictureBox();
            this.cbHTMLTitle = new ComboBox();
            this.cbHTMLContent = new ComboBox();
            this.btnHTMLAutoInsertContent = new Button();
            this.btnHTMLInsertContent = new Button();
            this.groupBox33 = new GroupBox();
            this.cbHTMLAnchor = new ComboBox();
            this.label53 = new Label();
            this.btnHTMLAddAnchor = new PictureBox();
            this.btnHTMLInsertAnchor = new Button();
            this.groupBox32 = new GroupBox();
            this.txtHTMLTags = new TextBox();
            this.listHTMLCategory = new ListBox();
            this.btnHTMLPostHand = new Button();
            this.btnHTMLPost = new Button();
            this.cbHTMLAccount = new ComboBox();
            this.btnHTMLAddAccount = new PictureBox();
            this.label81 = new Label();
            this.label82 = new Label();
            this.label79 = new Label();
            this.label67 = new Label();
            this.txtHTMLKeyword = new TextBox();
            this.txtHTMLTitle = new TextBox();
            this.label83 = new Label();
            this.label66 = new Label();
            this.webEditor = new WebBrowser();
            this.btnHTMLSaveImage = new Button();
            this.btnHTMLRemoveHref = new Button();
            this.tbSubmit = new TabPage();
            this.groupBox6 = new GroupBox();
            this.btnSubmitGetSource = new PictureBox();
            this.webSubmit = new GClass2();
            this.btnSubmitSave = new PictureBox();
            this.btnSubmitImport = new Button();
            this.numSubmitTime = new NumericUpDown();
            this.label54 = new Label();
            this.label51 = new Label();
            this.btnSubmitAuto = new Button();
            this.btnSubmitView = new Button();
            this.btnSubmitNext = new Button();
            this.btnSubmitOK = new Button();
            this.txtSubmitAdd = new PictureBox();
            this.txtSubmitAddress = new TextBox();
            this.btnSubmitSearch = new PictureBox();
            this.btnSubmitDelete = new PictureBox();
            this.btnSubmitEdit = new PictureBox();
            this.btnAutoClick = new Button();
            this.btnSubmitAdd = new PictureBox();
            this.dtvSubmit = new DataGridView();
            this.SubmitID = new DataGridViewTextBoxColumn();
            this.SubmitURL = new DataGridViewTextBoxColumn();
            this.SubmitAttributeID = new DataGridViewTextBoxColumn();
            this.cbAuto = new ComboBox();
            this.cbSubmitCate = new ComboBox();
            this.cbAttributeCate = new ComboBox();
            this.label11 = new Label();
            this.label30 = new Label();
            this.label18 = new Label();
            this.label15 = new Label();
            this.lbnhom = new Label();
            this.btnSubmitAttribute = new PictureBox();
            this.tbArticle = new TabPage();
            this.groupBox12 = new GroupBox();
            this.btnArticleSearch = new PictureBox();
            this.btnArticleRefresh = new Button();
            this.numAuto = new NumericUpDown();
            this.label39 = new Label();
            this.label52 = new Label();
            this.ckFollow = new CheckBox();
            this.btnArticleFollow = new Button();
            this.btnArticleCheck = new Button();
            this.btnArticleDelete = new PictureBox();
            this.btnArticleEdit = new PictureBox();
            this.label40 = new Label();
            this.btnArticleAdd = new PictureBox();
            this.dtvArticle = new DataGridView();
            this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.ArticleLink = new DataGridViewLinkColumn();
            this.Column6 = new DataGridViewImageColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.ArticleAuthor = new DataGridViewCheckBoxColumn();
            this.txtArticleLink = new TextBox();
            this.groupBox23 = new GroupBox();
            this.btnArticleCateSearch = new PictureBox();
            this.btnArticleCateAdd = new PictureBox();
            this.dtvArticleCate = new DataGridView();
            this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            this.txtArticleCate = new TextBox();
            this.tbRegex = new TabPage();
            this.groupBox35 = new GroupBox();
            this.RegexResultSave = new PictureBox();
            this.btnRegexFilterLink = new Button();
            this.btnRegexFilterEmail = new Button();
            this.numericRegexDelay = new NumericUpDown();
            this.btnRegexFilterYahoo = new Button();
            this.btnRegexReplace = new Button();
            this.rtbRegexResult = new RichTextBox();
            this.txtReplaceContent = new TextBox();
            this.btnRegexGetContentByRegex = new Button();
            this.txtRegexRegex = new TextBox();
            this.label75 = new Label();
            this.cbRegexType = new ComboBox();
            this.groupBox31 = new GroupBox();
            this.btnRegexUrlSave = new PictureBox();
            this.rtbRegexURL = new RichTextBox();
            this.groupBox7 = new GroupBox();
            this.btnRegexGetSource = new Button();
            this.btnRegexGetLink = new Button();
            this.numericRegexTo = new NumericUpDown();
            this.numericRegexFrom = new NumericUpDown();
            this.txtRegexURL = new TextBox();
            this.label76 = new Label();
            this.label69 = new Label();
            this.toolStripLabel2 = new ToolStripLabel();
            this.btnClose = new ToolStripButton();
            this.timer_0 = new Timer(this.icontainer_0);
            this.timer_1 = new Timer(this.icontainer_0);
            this.notifyIcon_0 = new NotifyIcon(this.icontainer_0);
            this.mnuHide = new ContextMenuStrip(this.icontainer_0);
            this.btnNotiShow = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.btnNotiExit = new ToolStripMenuItem();
            this.timer_2 = new Timer(this.icontainer_0);
            this.picLoader = new PictureBox();
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.btnHide = new ToolStripButton();
            this.btnInfo = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.lbSupport = new ToolStripLabel();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.lbUpdate = new ToolStripLabel();
            this.timer_3 = new Timer(this.icontainer_0);
            this.timer_4 = new Timer(this.icontainer_0);
            this.timer_5 = new Timer(this.icontainer_0);
            this.timer_6 = new Timer(this.icontainer_0);
            this.openFileDialog_0 = new OpenFileDialog();
            this.label49 = new Label();
            this.numAutoClick = new NumericUpDown();
            this.tbSeoTool.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((ISupportInitialize) this.btnCheckResultSave).BeginInit();
            ((ISupportInitialize) this.dtvCheckResult).BeginInit();
            this.groupBox22.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dtvResultCheck).BeginInit();
            ((ISupportInitialize) this.btnSaveCheck).BeginInit();
            this.tbPingURL.SuspendLayout();
            this.groupBox39.SuspendLayout();
            ((ISupportInitialize) this.dtvPingProxy).BeginInit();
            this.groupBox16.SuspendLayout();
            this.numPingView.BeginInit();
            this.groupBox2.SuspendLayout();
            this.tbKeyword.SuspendLayout();
            ((ISupportInitialize) this.btnKeyListSave).BeginInit();
            ((ISupportInitialize) this.btnSavePosition).BeginInit();
            ((ISupportInitialize) this.dtvKeyLogs).BeginInit();
            this.mnuKey.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize) this.btnKeyCateAdd).BeginInit();
            this.tbMain.SuspendLayout();
            this.tbKeyResearch.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((ISupportInitialize) this.dtvTags).BeginInit();
            this.groupBox14.SuspendLayout();
            ((ISupportInitialize) this.dtvSuggest).BeginInit();
            this.mnuSuggest.SuspendLayout();
            ((ISupportInitialize) this.btnSaveSuggest).BeginInit();
            this.groupBox13.SuspendLayout();
            this.tbKeywordTool.SuspendLayout();
            this.groupBox37.SuspendLayout();
            ((ISupportInitialize) this.btnKTSave).BeginInit();
            ((ISupportInitialize) this.dtvKTList).BeginInit();
            this.mnuSuggest_1.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.tbWebAnalytics.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize) this.btnAnalyticsLinkSave).BeginInit();
            ((ISupportInitialize) this.dtvAnalytics).BeginInit();
            ((ISupportInitialize) this.btnSaveAnalytics).BeginInit();
            ((ISupportInitialize) this.dtvAnalyticsWord4).BeginInit();
            ((ISupportInitialize) this.dtvAnalyticsWord3).BeginInit();
            ((ISupportInitialize) this.dtvAnalyticsWord2).BeginInit();
            ((ISupportInitialize) this.dtvAnalyticsWord1).BeginInit();
            ((ISupportInitialize) this.dtvAnalyticsImage).BeginInit();
            ((ISupportInitialize) this.dtvAnalyticsHeading).BeginInit();
            ((ISupportInitialize) this.dtvAnalyticsLink).BeginInit();
            this.tbCheckBacklink.SuspendLayout();
            this.groupBox26.SuspendLayout();
            ((ISupportInitialize) this.btnCheckBacklinkSave).BeginInit();
            ((ISupportInitialize) this.dtvCheckBacklink).BeginInit();
            this.tbSearchBL.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((ISupportInitialize) this.btnSearchBacklinkSave).BeginInit();
            ((ISupportInitialize) this.dtvSearchBacklink).BeginInit();
            this.tbSocial.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((ISupportInitialize) this.btnSocialClose).BeginInit();
            this.tbAdword.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((ISupportInitialize) this.btnAdwordSearch).BeginInit();
            ((ISupportInitialize) this.btnAdwordDelete).BeginInit();
            ((ISupportInitialize) this.btnAdwordEdit).BeginInit();
            ((ISupportInitialize) this.btnAdwordAdd).BeginInit();
            ((ISupportInitialize) this.dtvAdword).BeginInit();
            this.mnuArticle.SuspendLayout();
            this.groupBox29.SuspendLayout();
            ((ISupportInitialize) this.btnAdwordCateSearch).BeginInit();
            ((ISupportInitialize) this.btnAdwordCateAdd).BeginInit();
            ((ISupportInitialize) this.dtvAdwordCate).BeginInit();
            this.tbView.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.tbRival.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((ISupportInitialize) this.dtvRivalMonth2).BeginInit();
            ((ISupportInitialize) this.dtvRivalMonth1).BeginInit();
            ((ISupportInitialize) this.dtvRivalList).BeginInit();
            ((ISupportInitialize) this.dtvRivalHigh).BeginInit();
            ((ISupportInitialize) this.dtvRivalTop).BeginInit();
            this.tbBacklink.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((ISupportInitialize) this.btnBacklinkSearch).BeginInit();
            ((ISupportInitialize) this.btnBacklinkDelete).BeginInit();
            ((ISupportInitialize) this.btnBacklinkEdit).BeginInit();
            ((ISupportInitialize) this.btnBacklinkAdd).BeginInit();
            ((ISupportInitialize) this.dtvBacklink).BeginInit();
            this.groupBox8.SuspendLayout();
            ((ISupportInitialize) this.btnBacklinkCateSearch).BeginInit();
            ((ISupportInitialize) this.btnBacklinkCateAdd).BeginInit();
            ((ISupportInitialize) this.dtvBacklinkCate).BeginInit();
            this.tbNews.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((ISupportInitialize) this.dtvNews).BeginInit();
            this.groupBox30.SuspendLayout();
            ((ISupportInitialize) this.btnNewsCateSearch).BeginInit();
            ((ISupportInitialize) this.btnNewsCateAdd).BeginInit();
            ((ISupportInitialize) this.dtvNewsCate).BeginInit();
            this.tbHTML.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.numericHTMLRandomContent.BeginInit();
            ((ISupportInitialize) this.btnHTMLAddContent).BeginInit();
            this.groupBox33.SuspendLayout();
            ((ISupportInitialize) this.btnHTMLAddAnchor).BeginInit();
            this.groupBox32.SuspendLayout();
            ((ISupportInitialize) this.btnHTMLAddAccount).BeginInit();
            this.tbSubmit.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((ISupportInitialize) this.btnSubmitGetSource).BeginInit();
            ((ISupportInitialize) this.btnSubmitSave).BeginInit();
            this.numSubmitTime.BeginInit();
            ((ISupportInitialize) this.txtSubmitAdd).BeginInit();
            ((ISupportInitialize) this.btnSubmitSearch).BeginInit();
            ((ISupportInitialize) this.btnSubmitDelete).BeginInit();
            ((ISupportInitialize) this.btnSubmitEdit).BeginInit();
            ((ISupportInitialize) this.btnSubmitAdd).BeginInit();
            ((ISupportInitialize) this.dtvSubmit).BeginInit();
            ((ISupportInitialize) this.btnSubmitAttribute).BeginInit();
            this.tbArticle.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((ISupportInitialize) this.btnArticleSearch).BeginInit();
            this.numAuto.BeginInit();
            ((ISupportInitialize) this.btnArticleDelete).BeginInit();
            ((ISupportInitialize) this.btnArticleEdit).BeginInit();
            ((ISupportInitialize) this.btnArticleAdd).BeginInit();
            ((ISupportInitialize) this.dtvArticle).BeginInit();
            this.groupBox23.SuspendLayout();
            ((ISupportInitialize) this.btnArticleCateSearch).BeginInit();
            ((ISupportInitialize) this.btnArticleCateAdd).BeginInit();
            ((ISupportInitialize) this.dtvArticleCate).BeginInit();
            this.tbRegex.SuspendLayout();
            this.groupBox35.SuspendLayout();
            ((ISupportInitialize) this.RegexResultSave).BeginInit();
            this.numericRegexDelay.BeginInit();
            this.groupBox31.SuspendLayout();
            ((ISupportInitialize) this.btnRegexUrlSave).BeginInit();
            this.groupBox7.SuspendLayout();
            this.numericRegexTo.BeginInit();
            this.numericRegexFrom.BeginInit();
            this.mnuHide.SuspendLayout();
            ((ISupportInitialize) this.picLoader).BeginInit();
            this.toolBar.SuspendLayout();
            this.numAutoClick.BeginInit();
            base.SuspendLayout();
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new Size(0x17, 0x17);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new Size(0x17, 0x17);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new Size(0x17, 0x17);
            this.tbSeoTool.BackColor = SystemColors.Control;
            this.tbSeoTool.Controls.Add(this.groupBox17);
            this.tbSeoTool.Controls.Add(this.groupBox27);
            this.tbSeoTool.Controls.Add(this.groupBox4);
            this.tbSeoTool.Controls.Add(this.groupBox21);
            this.tbSeoTool.Controls.Add(this.groupBox20);
            this.tbSeoTool.Controls.Add(this.groupBox22);
            this.tbSeoTool.Controls.Add(this.groupBox3);
            this.tbSeoTool.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.tbSeoTool.Location = new Point(4, 0x3d);
            this.tbSeoTool.Name = "tbSeoTool";
            this.tbSeoTool.Size = new Size(0x444, 670);
            this.tbSeoTool.TabIndex = 2;
            this.tbSeoTool.Text = "SEO Tools";
            this.tbSeoTool.Enter += new EventHandler(this.tbSeoTool_Enter);
            this.groupBox17.Controls.Add(this.label32);
            this.groupBox17.Controls.Add(this.txtLinkSitemap);
            this.groupBox17.Controls.Add(this.btnPingSitemap);
            this.groupBox17.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox17.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox17.Location = new Point(0x225, 0x259);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new Size(0x217, 0x41);
            this.groupBox17.TabIndex = 0x1b;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Ping Sitemap.xml với Google, Ask, Yahoo, Bing";
            this.label32.AutoSize = true;
            this.label32.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label32.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label32.Location = new Point(12, 0x1c);
            this.label32.Name = "label32";
            this.label32.Size = new Size(0x51, 0x10);
            this.label32.TabIndex = 10;
            this.label32.Text = "Sitemap Link";
            this.txtLinkSitemap.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtLinkSitemap.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtLinkSitemap.Location = new Point(0x63, 0x19);
            this.txtLinkSitemap.Name = "txtLinkSitemap";
            this.txtLinkSitemap.Size = new Size(0x158, 0x17);
            this.txtLinkSitemap.TabIndex = 0x11;
            this.btnPingSitemap.DialogResult = DialogResult.Cancel;
            this.btnPingSitemap.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPingSitemap.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnPingSitemap.Location = new Point(0x1c1, 0x15);
            this.btnPingSitemap.Name = "btnPingSitemap";
            this.btnPingSitemap.Size = new Size(0x51, 0x1f);
            this.btnPingSitemap.TabIndex = 0x12;
            this.btnPingSitemap.Text = "Ping";
            this.btnPingSitemap.UseVisualStyleBackColor = true;
            this.btnPingSitemap.Click += new EventHandler(this.btnPingSitemap_Click);
            this.groupBox27.Controls.Add(this.btnCheckGoogleIndex);
            this.groupBox27.Controls.Add(this.label65);
            this.groupBox27.Controls.Add(this.label63);
            this.groupBox27.Controls.Add(this.txtCheckIndexUrl);
            this.groupBox27.Controls.Add(this.txtCheckIndexKey);
            this.groupBox27.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox27.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox27.Location = new Point(8, 0x192);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new Size(0x217, 0x41);
            this.groupBox27.TabIndex = 0x1a;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Kiểm tra Index Google";
            this.btnCheckGoogleIndex.DialogResult = DialogResult.Cancel;
            this.btnCheckGoogleIndex.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckGoogleIndex.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckGoogleIndex.Location = new Point(0x1c7, 20);
            this.btnCheckGoogleIndex.Name = "btnCheckGoogleIndex";
            this.btnCheckGoogleIndex.Size = new Size(0x4b, 0x1f);
            this.btnCheckGoogleIndex.TabIndex = 6;
            this.btnCheckGoogleIndex.Text = "Kiểm Tra";
            this.btnCheckGoogleIndex.UseVisualStyleBackColor = true;
            this.btnCheckGoogleIndex.Click += new EventHandler(this.btnCheckGoogleIndex_Click);
            this.label65.AutoSize = true;
            this.label65.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label65.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label65.Location = new Point(0xdd, 0x1c);
            this.label65.Name = "label65";
            this.label65.Size = new Size(30, 0x10);
            this.label65.TabIndex = 11;
            this.label65.Text = "URL";
            this.label63.AutoSize = true;
            this.label63.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label63.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label63.Location = new Point(6, 0x1c);
            this.label63.Name = "label63";
            this.label63.Size = new Size(0x37, 0x10);
            this.label63.TabIndex = 11;
            this.label63.Text = "Từ kho\x00e1";
            this.txtCheckIndexUrl.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCheckIndexUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtCheckIndexUrl.Location = new Point(0x101, 0x18);
            this.txtCheckIndexUrl.Name = "txtCheckIndexUrl";
            this.txtCheckIndexUrl.Size = new Size(0xc0, 0x17);
            this.txtCheckIndexUrl.TabIndex = 5;
            this.txtCheckIndexUrl.KeyUp += new KeyEventHandler(this.txtCheckIndexKey_KeyUp);
            this.txtCheckIndexKey.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCheckIndexKey.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtCheckIndexKey.Location = new Point(0x42, 0x19);
            this.txtCheckIndexKey.Name = "txtCheckIndexKey";
            this.txtCheckIndexKey.Size = new Size(0x95, 0x17);
            this.txtCheckIndexKey.TabIndex = 4;
            this.txtCheckIndexKey.KeyUp += new KeyEventHandler(this.txtCheckIndexKey_KeyUp);
            this.groupBox4.Controls.Add(this.btnCheckWeb);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtWebReport);
            this.groupBox4.Controls.Add(this.cbWebReport);
            this.groupBox4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox4.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox4.Location = new Point(8, 0x1d9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(0x217, 0x41);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiểm tra Website: Lỗi HTML, CSS, Tốc độ, Doamin...";
            this.btnCheckWeb.DialogResult = DialogResult.Cancel;
            this.btnCheckWeb.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckWeb.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckWeb.Location = new Point(0x1c7, 20);
            this.btnCheckWeb.Name = "btnCheckWeb";
            this.btnCheckWeb.Size = new Size(0x4b, 0x1f);
            this.btnCheckWeb.TabIndex = 9;
            this.btnCheckWeb.Text = "Kiểm Tra";
            this.btnCheckWeb.UseVisualStyleBackColor = true;
            this.btnCheckWeb.Click += new EventHandler(this.btnCheckWeb_Click);
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label10.Location = new Point(6, 0x1c);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x36, 0x10);
            this.label10.TabIndex = 11;
            this.label10.Text = "Website";
            this.txtWebReport.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtWebReport.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtWebReport.Location = new Point(0x42, 0x19);
            this.txtWebReport.Name = "txtWebReport";
            this.txtWebReport.Size = new Size(0x95, 0x17);
            this.txtWebReport.TabIndex = 7;
            this.txtWebReport.KeyUp += new KeyEventHandler(this.txtWebReport_KeyUp);
            this.cbWebReport.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbWebReport.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbWebReport.FlatStyle = FlatStyle.Popup;
            this.cbWebReport.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbWebReport.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbWebReport.FormattingEnabled = true;
            this.cbWebReport.ItemHeight = 0x10;
            this.cbWebReport.Location = new Point(0xdd, 0x18);
            this.cbWebReport.Name = "cbWebReport";
            this.cbWebReport.Size = new Size(0xe4, 0x18);
            this.cbWebReport.TabIndex = 8;
            this.groupBox21.Controls.Add(this.cbGoogleTool);
            this.groupBox21.Controls.Add(this.cbSEOOther);
            this.groupBox21.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox21.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox21.Location = new Point(8, 0x263);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new Size(0x217, 0x37);
            this.groupBox21.TabIndex = 0x18;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "C\x00f4ng cụ SEO kh\x00e1c";
            this.cbGoogleTool.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbGoogleTool.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbGoogleTool.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbGoogleTool.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbGoogleTool.FormattingEnabled = true;
            this.cbGoogleTool.Location = new Point(0x108, 20);
            this.cbGoogleTool.MaxDropDownItems = 0x10;
            this.cbGoogleTool.Name = "cbGoogleTool";
            this.cbGoogleTool.Size = new Size(0x109, 0x18);
            this.cbGoogleTool.TabIndex = 12;
            this.cbGoogleTool.SelectionChangeCommitted += new EventHandler(this.cbGoogleTool_SelectionChangeCommitted);
            this.cbSEOOther.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbSEOOther.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSEOOther.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbSEOOther.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbSEOOther.FormattingEnabled = true;
            this.cbSEOOther.Location = new Point(6, 0x15);
            this.cbSEOOther.MaxDropDownItems = 0x10;
            this.cbSEOOther.Name = "cbSEOOther";
            this.cbSEOOther.Size = new Size(0xfc, 0x18);
            this.cbSEOOther.TabIndex = 11;
            this.cbSEOOther.SelectionChangeCommitted += new EventHandler(this.cbSEOOther_SelectionChangeCommitted);
            this.groupBox20.Controls.Add(this.btnCheckResultSave);
            this.groupBox20.Controls.Add(this.dtvCheckResult);
            this.groupBox20.Controls.Add(this.btnCheckPR);
            this.groupBox20.Controls.Add(this.label50);
            this.groupBox20.Controls.Add(this.btnCheckPlus);
            this.groupBox20.Controls.Add(this.label5);
            this.groupBox20.Controls.Add(this.btnOpenLink);
            this.groupBox20.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox20.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox20.Location = new Point(0x225, 3);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new Size(0x217, 0x249);
            this.groupBox20.TabIndex = 14;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Kiểm tra PageRank nhiều Website";
            this.btnCheckResultSave.BackColor = Color.Transparent;
            this.btnCheckResultSave.Cursor = Cursors.Hand;
            this.btnCheckResultSave.Image = Resources.smethod_7();
            this.btnCheckResultSave.Location = new Point(0x1fb, 0x18);
            this.btnCheckResultSave.Name = "btnCheckResultSave";
            this.btnCheckResultSave.Size = new Size(0x16, 0x16);
            this.btnCheckResultSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnCheckResultSave.TabIndex = 13;
            this.btnCheckResultSave.TabStop = false;
            this.btnCheckResultSave.Click += new EventHandler(this.btnCheckResultSave_Click);
            this.dtvCheckResult.AllowUserToAddRows = false;
            this.dtvCheckResult.AllowUserToDeleteRows = false;
            this.dtvCheckResult.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvCheckResult.AlternatingRowsDefaultCellStyle = style;
            this.dtvCheckResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvCheckResult.BackgroundColor = Color.White;
            this.dtvCheckResult.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvCheckResult.ColumnHeadersDefaultCellStyle = style2;
            this.dtvCheckResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.GiaTri, this.CheckUrl };
            this.dtvCheckResult.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvCheckResult.DefaultCellStyle = style3;
            this.dtvCheckResult.Location = new Point(7, 0x37);
            this.dtvCheckResult.MultiSelect = false;
            this.dtvCheckResult.Name = "dtvCheckResult";
            this.dtvCheckResult.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvCheckResult.RowHeadersDefaultCellStyle = style4;
            this.dtvCheckResult.RowHeadersWidth = 30;
            this.dtvCheckResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvCheckResult.Size = new Size(0x20a, 0x20c);
            this.dtvCheckResult.TabIndex = 0x10;
            this.dtvCheckResult.CellContentClick += new DataGridViewCellEventHandler(this.dtvCheckResult_CellContentClick);
            this.dtvCheckResult.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvCheckResult_CellDoubleClick);
            this.dtvCheckResult.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvCheckResult_RowPostPaint);
            style5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.GiaTri.DefaultCellStyle = style5;
            this.GiaTri.FillWeight = 50.76142f;
            this.GiaTri.HeaderText = "Gi\x00e1 trị";
            this.GiaTri.Name = "GiaTri";
            this.GiaTri.ReadOnly = true;
            this.CheckUrl.FillWeight = 149.2386f;
            this.CheckUrl.HeaderText = "Url";
            this.CheckUrl.Name = "CheckUrl";
            this.CheckUrl.ReadOnly = true;
            this.CheckUrl.Resizable = DataGridViewTriState.True;
            this.CheckUrl.SortMode = DataGridViewColumnSortMode.Automatic;
            this.btnCheckPR.DialogResult = DialogResult.Cancel;
            this.btnCheckPR.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckPR.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckPR.Location = new Point(0x103, 0x12);
            this.btnCheckPR.Name = "btnCheckPR";
            this.btnCheckPR.Size = new Size(120, 0x1f);
            this.btnCheckPR.TabIndex = 14;
            this.btnCheckPR.Text = "Check Multi PR";
            this.btnCheckPR.UseVisualStyleBackColor = true;
            this.btnCheckPR.Click += new EventHandler(this.btnCheckPR_Click);
            this.label50.AutoSize = true;
            this.label50.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label50.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label50.Location = new Point(0xc1, 0x1a);
            this.label50.Name = "label50";
            this.label50.Size = new Size(60, 0x10);
            this.label50.TabIndex = 10;
            this.label50.Text = "Lựa chọn";
            this.btnCheckPlus.DialogResult = DialogResult.Cancel;
            this.btnCheckPlus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckPlus.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckPlus.Location = new Point(0x181, 0x12);
            this.btnCheckPlus.Name = "btnCheckPlus";
            this.btnCheckPlus.Size = new Size(0x74, 0x1f);
            this.btnCheckPlus.TabIndex = 15;
            this.btnCheckPlus.Text = "Check Social";
            this.btnCheckPlus.UseVisualStyleBackColor = true;
            this.btnCheckPlus.Click += new EventHandler(this.btnCheckPlus_Click);
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label5.Location = new Point(6, 0x1a);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x5d, 0x10);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh s\x00e1ch Link";
            this.btnOpenLink.DialogResult = DialogResult.Cancel;
            this.btnOpenLink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnOpenLink.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnOpenLink.Location = new Point(0x69, 0x12);
            this.btnOpenLink.Name = "btnOpenLink";
            this.btnOpenLink.Size = new Size(0x52, 0x1f);
            this.btnOpenLink.TabIndex = 13;
            this.btnOpenLink.Text = "Th\x00eam Link";
            this.btnOpenLink.UseVisualStyleBackColor = true;
            this.btnOpenLink.Click += new EventHandler(this.btnOpenLink_Click);
            this.groupBox22.Controls.Add(this.btnSitemap);
            this.groupBox22.Controls.Add(this.label42);
            this.groupBox22.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox22.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox22.Location = new Point(8, 0x220);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new Size(0x217, 0x3d);
            this.groupBox22.TabIndex = 0x19;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Quản l\x00fd Sitemap.xml && RSS";
            this.btnSitemap.DialogResult = DialogResult.Cancel;
            this.btnSitemap.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSitemap.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSitemap.Location = new Point(0x131, 0x15);
            this.btnSitemap.Name = "btnSitemap";
            this.btnSitemap.Size = new Size(0xe0, 0x1f);
            this.btnSitemap.TabIndex = 10;
            this.btnSitemap.Text = "Quản l\x00fd Sitemap && RSS";
            this.btnSitemap.UseVisualStyleBackColor = true;
            this.btnSitemap.Click += new EventHandler(this.btnSitemap_Click);
            this.label42.AutoSize = true;
            this.label42.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label42.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label42.Location = new Point(12, 0x1c);
            this.label42.Name = "label42";
            this.label42.Size = new Size(0x11f, 0x10);
            this.label42.TabIndex = 11;
            this.label42.Text = "Tạo v\x00e0 quản l\x00fd Sitemap.xml v\x00e0 RSS tự động";
            this.groupBox3.Controls.Add(this.dtvResultCheck);
            this.groupBox3.Controls.Add(this.btnSaveCheck);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtWebsiteCheck);
            this.groupBox3.Controls.Add(this.btnCheckIndex);
            this.groupBox3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox3.Location = new Point(8, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x217, 0x187);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiểm tra PageRank, Backlinks, Pages Indexed, Alexa Rank...";
            this.dtvResultCheck.AllowUserToAddRows = false;
            this.dtvResultCheck.AllowUserToDeleteRows = false;
            this.dtvResultCheck.AllowUserToOrderColumns = true;
            style6.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvResultCheck.AlternatingRowsDefaultCellStyle = style6;
            this.dtvResultCheck.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvResultCheck.BackgroundColor = Color.White;
            this.dtvResultCheck.BorderStyle = BorderStyle.None;
            style7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style7.BackColor = SystemColors.Control;
            style7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style7.ForeColor = SystemColors.WindowText;
            style7.SelectionBackColor = SystemColors.Highlight;
            style7.SelectionForeColor = SystemColors.HighlightText;
            style7.WrapMode = DataGridViewTriState.True;
            this.dtvResultCheck.ColumnHeadersDefaultCellStyle = style7;
            this.dtvResultCheck.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.SEOTools, this.Link };
            this.dtvResultCheck.Columns.AddRange(dataGridViewColumns);
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.Window;
            style8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style8.ForeColor = Color.FromArgb(0, 0, 0x40);
            style8.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style8.SelectionForeColor = Color.White;
            style8.WrapMode = DataGridViewTriState.False;
            this.dtvResultCheck.DefaultCellStyle = style8;
            this.dtvResultCheck.Location = new Point(6, 0x36);
            this.dtvResultCheck.MultiSelect = false;
            this.dtvResultCheck.Name = "dtvResultCheck";
            this.dtvResultCheck.ReadOnly = true;
            style9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style9.BackColor = SystemColors.Control;
            style9.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style9.ForeColor = SystemColors.WindowText;
            style9.SelectionBackColor = SystemColors.HighlightText;
            style9.SelectionForeColor = SystemColors.HighlightText;
            style9.WrapMode = DataGridViewTriState.True;
            this.dtvResultCheck.RowHeadersDefaultCellStyle = style9;
            this.dtvResultCheck.RowHeadersWidth = 30;
            this.dtvResultCheck.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvResultCheck.Size = new Size(0x20b, 0x14b);
            this.dtvResultCheck.TabIndex = 3;
            this.dtvResultCheck.CellContentClick += new DataGridViewCellEventHandler(this.dtvResultCheck_CellContentClick);
            this.SEOTools.HeaderText = "Gi\x00e1 trị";
            this.SEOTools.Name = "SEOTools";
            this.SEOTools.ReadOnly = true;
            this.Link.HeaderText = "Chi tiết";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Resizable = DataGridViewTriState.True;
            this.Link.SortMode = DataGridViewColumnSortMode.Automatic;
            this.btnSaveCheck.BackColor = Color.Transparent;
            this.btnSaveCheck.Cursor = Cursors.Hand;
            this.btnSaveCheck.Image = Resources.smethod_7();
            this.btnSaveCheck.Location = new Point(0x1f6, 0x16);
            this.btnSaveCheck.Name = "btnSaveCheck";
            this.btnSaveCheck.Size = new Size(0x16, 0x16);
            this.btnSaveCheck.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnSaveCheck.TabIndex = 13;
            this.btnSaveCheck.TabStop = false;
            this.btnSaveCheck.Click += new EventHandler(this.btnSaveCheck_Click);
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label8.Location = new Point(12, 0x18);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x3e, 0x10);
            this.label8.TabIndex = 7;
            this.label8.Text = "T\x00ean miền";
            this.txtWebsiteCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtWebsiteCheck.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtWebsiteCheck.Location = new Point(80, 0x15);
            this.txtWebsiteCheck.Name = "txtWebsiteCheck";
            this.txtWebsiteCheck.Size = new Size(0x152, 0x17);
            this.txtWebsiteCheck.TabIndex = 1;
            this.txtWebsiteCheck.KeyUp += new KeyEventHandler(this.txtWebsiteCheck_KeyUp);
            this.btnCheckIndex.DialogResult = DialogResult.Cancel;
            this.btnCheckIndex.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckIndex.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckIndex.Location = new Point(0x1a8, 0x11);
            this.btnCheckIndex.Name = "btnCheckIndex";
            this.btnCheckIndex.Size = new Size(0x48, 0x1f);
            this.btnCheckIndex.TabIndex = 2;
            this.btnCheckIndex.Text = "Kiểm Tra";
            this.btnCheckIndex.UseVisualStyleBackColor = true;
            this.btnCheckIndex.Click += new EventHandler(this.btnCheckIndex_Click);
            this.tbPingURL.BackColor = SystemColors.Control;
            this.tbPingURL.Controls.Add(this.groupBox39);
            this.tbPingURL.Controls.Add(this.groupBox16);
            this.tbPingURL.Controls.Add(this.groupBox2);
            this.tbPingURL.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.tbPingURL.Location = new Point(4, 0x3d);
            this.tbPingURL.Name = "tbPingURL";
            this.tbPingURL.Padding = new Padding(3);
            this.tbPingURL.Size = new Size(0x444, 670);
            this.tbPingURL.TabIndex = 1;
            this.tbPingURL.Text = "Proxy Pro";
            this.groupBox39.Controls.Add(this.btnCheckProxy);
            this.groupBox39.Controls.Add(this.dtvPingProxy);
            this.groupBox39.Controls.Add(this.btnImportProxy);
            this.groupBox39.Controls.Add(this.btnGetProxy);
            this.groupBox39.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox39.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox39.Location = new Point(8, 0x67);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new Size(0xea, 0x22f);
            this.groupBox39.TabIndex = 0x1d;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Quản l\x00fd Proxy";
            this.btnCheckProxy.DialogResult = DialogResult.Cancel;
            this.btnCheckProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckProxy.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckProxy.Location = new Point(0x8d, 0x15);
            this.btnCheckProxy.Name = "btnCheckProxy";
            this.btnCheckProxy.Size = new Size(0x58, 0x1f);
            this.btnCheckProxy.TabIndex = 11;
            this.btnCheckProxy.Text = "Check Proxy";
            this.btnCheckProxy.UseVisualStyleBackColor = true;
            this.btnCheckProxy.Click += new EventHandler(this.btnCheckProxy_Click);
            this.dtvPingProxy.AllowUserToAddRows = false;
            this.dtvPingProxy.AllowUserToDeleteRows = false;
            this.dtvPingProxy.AllowUserToOrderColumns = true;
            style10.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvPingProxy.AlternatingRowsDefaultCellStyle = style10;
            this.dtvPingProxy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvPingProxy.BackgroundColor = Color.White;
            this.dtvPingProxy.BorderStyle = BorderStyle.None;
            style11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style11.BackColor = SystemColors.Control;
            style11.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style11.ForeColor = SystemColors.WindowText;
            style11.SelectionBackColor = SystemColors.Highlight;
            style11.SelectionForeColor = SystemColors.HighlightText;
            style11.WrapMode = DataGridViewTriState.True;
            this.dtvPingProxy.ColumnHeadersDefaultCellStyle = style11;
            this.dtvPingProxy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn36 };
            this.dtvPingProxy.Columns.AddRange(dataGridViewColumns);
            style12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style12.BackColor = SystemColors.Window;
            style12.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style12.ForeColor = Color.FromArgb(0, 0, 0x40);
            style12.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style12.SelectionForeColor = Color.White;
            style12.WrapMode = DataGridViewTriState.False;
            this.dtvPingProxy.DefaultCellStyle = style12;
            this.dtvPingProxy.Location = new Point(6, 0x3a);
            this.dtvPingProxy.MultiSelect = false;
            this.dtvPingProxy.Name = "dtvPingProxy";
            this.dtvPingProxy.ReadOnly = true;
            style13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style13.BackColor = SystemColors.Control;
            style13.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style13.ForeColor = SystemColors.WindowText;
            style13.SelectionBackColor = SystemColors.HighlightText;
            style13.SelectionForeColor = SystemColors.HighlightText;
            style13.WrapMode = DataGridViewTriState.True;
            this.dtvPingProxy.RowHeadersDefaultCellStyle = style13;
            this.dtvPingProxy.RowHeadersWidth = 30;
            this.dtvPingProxy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvPingProxy.Size = new Size(0xde, 0x1ef);
            this.dtvPingProxy.TabIndex = 4;
            this.dtvPingProxy.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvPingProxy_CellDoubleClick);
            this.dtvPingProxy.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvPingProxy_RowPostPaint);
            this.dataGridViewTextBoxColumn36.HeaderText = "Proxy";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.btnImportProxy.DialogResult = DialogResult.Cancel;
            this.btnImportProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnImportProxy.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnImportProxy.Location = new Point(5, 0x15);
            this.btnImportProxy.Name = "btnImportProxy";
            this.btnImportProxy.Size = new Size(0x39, 0x1f);
            this.btnImportProxy.TabIndex = 10;
            this.btnImportProxy.Text = "Import";
            this.btnImportProxy.UseVisualStyleBackColor = true;
            this.btnImportProxy.Click += new EventHandler(this.btnImportProxy_Click);
            this.btnGetProxy.DialogResult = DialogResult.Cancel;
            this.btnGetProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnGetProxy.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnGetProxy.Location = new Point(0x41, 0x15);
            this.btnGetProxy.Name = "btnGetProxy";
            this.btnGetProxy.Size = new Size(0x49, 0x1f);
            this.btnGetProxy.TabIndex = 10;
            this.btnGetProxy.Text = "Get Proxy";
            this.btnGetProxy.UseVisualStyleBackColor = true;
            this.btnGetProxy.Click += new EventHandler(this.btnGetProxy_Click);
            this.groupBox16.Controls.Add(this.numPingView);
            this.groupBox16.Controls.Add(this.label7);
            this.groupBox16.Controls.Add(this.label28);
            this.groupBox16.Controls.Add(this.btnPingViewAuto);
            this.groupBox16.Controls.Add(this.webProxy);
            this.groupBox16.Controls.Add(this.btnPingProxyRemove);
            this.groupBox16.Controls.Add(this.btnPingWebView);
            this.groupBox16.Controls.Add(this.label6);
            this.groupBox16.Controls.Add(this.txtPingWebUrl);
            this.groupBox16.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox16.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox16.Location = new Point(0xf6, 0x67);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new Size(840, 0x22f);
            this.groupBox16.TabIndex = 0x13;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Tr\x00ecnh duyệt Website";
            this.numPingView.Increment = new decimal(new int[] { 5 });
            this.numPingView.Location = new Point(660, 0x1b);
            this.numPingView.Maximum = new decimal(new int[] { 0xe10 });
            this.numPingView.Name = "numPingView";
            this.numPingView.Size = new Size(0x3b, 0x16);
            this.numPingView.TabIndex = 0x2e;
            this.numPingView.TextAlign = HorizontalAlignment.Center;
            this.numPingView.Value = new decimal(new int[] { 30 });
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label7.Location = new Point(0x2d5, 0x1c);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x1f, 0x10);
            this.label7.TabIndex = 0x31;
            this.label7.Text = "gi\x00e2y";
            this.label28.AutoSize = true;
            this.label28.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label28.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label28.Location = new Point(0x236, 30);
            this.label28.Name = "label28";
            this.label28.Size = new Size(0x58, 0x10);
            this.label28.TabIndex = 0x30;
            this.label28.Text = "Tự động View";
            this.btnPingViewAuto.DialogResult = DialogResult.Cancel;
            this.btnPingViewAuto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPingViewAuto.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnPingViewAuto.Location = new Point(0x2fa, 0x15);
            this.btnPingViewAuto.Name = "btnPingViewAuto";
            this.btnPingViewAuto.Size = new Size(0x48, 0x1f);
            this.btnPingViewAuto.TabIndex = 0x2f;
            this.btnPingViewAuto.Text = "Bắt Đầu";
            this.btnPingViewAuto.UseVisualStyleBackColor = true;
            this.btnPingViewAuto.Click += new EventHandler(this.btnPingViewAuto_Click);
            this.webProxy.Location = new Point(9, 0x3a);
            this.webProxy.MinimumSize = new Size(20, 20);
            this.webProxy.Name = "webProxy";
            this.webProxy.ScriptErrorsSuppressed = true;
            this.webProxy.Size = new Size(0x339, 0x1ef);
            this.webProxy.TabIndex = 0x1c;
            this.webProxy.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webProxy_DocumentCompleted);
            this.webProxy.Navigating += new WebBrowserNavigatingEventHandler(this.webProxy_Navigating);
            this.btnPingProxyRemove.DialogResult = DialogResult.Cancel;
            this.btnPingProxyRemove.FlatStyle = FlatStyle.System;
            this.btnPingProxyRemove.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPingProxyRemove.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnPingProxyRemove.Location = new Point(0x1db, 0x15);
            this.btnPingProxyRemove.Name = "btnPingProxyRemove";
            this.btnPingProxyRemove.Size = new Size(0x55, 0x1f);
            this.btnPingProxyRemove.TabIndex = 0x1a;
            this.btnPingProxyRemove.Text = "Xo\x00e1 Proxy";
            this.btnPingProxyRemove.UseVisualStyleBackColor = true;
            this.btnPingProxyRemove.Click += new EventHandler(this.btnPingProxyRemove_Click);
            this.btnPingWebView.DialogResult = DialogResult.Cancel;
            this.btnPingWebView.FlatStyle = FlatStyle.System;
            this.btnPingWebView.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPingWebView.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnPingWebView.Location = new Point(0x180, 0x15);
            this.btnPingWebView.Name = "btnPingWebView";
            this.btnPingWebView.Size = new Size(0x55, 0x1f);
            this.btnPingWebView.TabIndex = 0x1a;
            this.btnPingWebView.Text = "Duyệt Web";
            this.btnPingWebView.UseVisualStyleBackColor = true;
            this.btnPingWebView.Click += new EventHandler(this.btnPingWebView_Click);
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label6.Location = new Point(6, 0x1c);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x18, 0x10);
            this.label6.TabIndex = 0x1b;
            this.label6.Text = "Url";
            this.txtPingWebUrl.BorderStyle = BorderStyle.FixedSingle;
            this.txtPingWebUrl.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPingWebUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtPingWebUrl.Location = new Point(0x24, 0x1a);
            this.txtPingWebUrl.Name = "txtPingWebUrl";
            this.txtPingWebUrl.Size = new Size(0x156, 0x17);
            this.txtPingWebUrl.TabIndex = 0x19;
            this.txtPingWebUrl.Text = "http://www.ip2location.com";
            this.groupBox2.Controls.Add(this.txtPingUrl);
            this.groupBox2.Controls.Add(this.btnUpdateProxy);
            this.groupBox2.Controls.Add(this.txtPingProxy);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPingTitle);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.btnPing);
            this.groupBox2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox2.Location = new Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x436, 0x5b);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ping URL cho Google Index b\x00e0i viết nhanh nhất";
            this.txtPingUrl.BorderStyle = BorderStyle.None;
            this.txtPingUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtPingUrl.Location = new Point(6, 0x15);
            this.txtPingUrl.Name = "txtPingUrl";
            this.txtPingUrl.Size = new Size(0x217, 60);
            this.txtPingUrl.TabIndex = 2;
            this.txtPingUrl.Text = "";
            this.txtPingUrl.LinkClicked += new LinkClickedEventHandler(this.txtPingUrl_LinkClicked);
            this.btnUpdateProxy.DialogResult = DialogResult.Cancel;
            this.btnUpdateProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnUpdateProxy.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnUpdateProxy.Location = new Point(970, 0x36);
            this.btnUpdateProxy.Name = "btnUpdateProxy";
            this.btnUpdateProxy.Size = new Size(0x66, 0x1f);
            this.btnUpdateProxy.TabIndex = 5;
            this.btnUpdateProxy.Text = "Cập nhật Proxy";
            this.btnUpdateProxy.UseVisualStyleBackColor = true;
            this.btnUpdateProxy.Click += new EventHandler(this.btnUpdateProxy_Click);
            this.txtPingProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPingProxy.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtPingProxy.Location = new Point(0x25c, 0x3a);
            this.txtPingProxy.Name = "txtPingProxy";
            this.txtPingProxy.Size = new Size(0x167, 0x17);
            this.txtPingProxy.TabIndex = 3;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label12.Location = new Point(0x223, 0x3d);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x27, 0x10);
            this.label12.TabIndex = 0x16;
            this.label12.Text = "Proxy";
            this.txtPingTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPingTitle.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtPingTitle.Location = new Point(0x25c, 0x15);
            this.txtPingTitle.Name = "txtPingTitle";
            this.txtPingTitle.Size = new Size(0x167, 0x17);
            this.txtPingTitle.TabIndex = 1;
            this.label31.AutoSize = true;
            this.label31.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label31.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label31.Location = new Point(0x223, 0x18);
            this.label31.Name = "label31";
            this.label31.Size = new Size(0x33, 0x10);
            this.label31.TabIndex = 0x16;
            this.label31.Text = "Ti\x00eau đề";
            this.btnPing.DialogResult = DialogResult.Cancel;
            this.btnPing.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPing.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnPing.Location = new Point(0x3c9, 0x11);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new Size(0x67, 0x1f);
            this.btnPing.TabIndex = 4;
            this.btnPing.Text = "Ping Url Link";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new EventHandler(this.btnPing_Click);
            this.tbKeyword.BackColor = SystemColors.Control;
            this.tbKeyword.Controls.Add(this.btnKeyListSave);
            this.tbKeyword.Controls.Add(this.btnSavePosition);
            this.tbKeyword.Controls.Add(this.btnKeyCheckAll);
            this.tbKeyword.Controls.Add(this.cbKeyCate);
            this.tbKeyword.Controls.Add(this.dtvKeyLogs);
            this.tbKeyword.Controls.Add(this.webMain);
            this.tbKeyword.Controls.Add(this.groupBox1);
            this.tbKeyword.Controls.Add(this.label19);
            this.tbKeyword.Controls.Add(this.btnKeyCateAdd);
            this.tbKeyword.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.tbKeyword.Location = new Point(4, 0x3d);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Padding = new Padding(3);
            this.tbKeyword.Size = new Size(0x444, 670);
            this.tbKeyword.TabIndex = 0;
            this.tbKeyword.Text = "V\x00ed tr\x00ed Từ kho\x00e1";
            this.tbKeyword.Enter += new EventHandler(this.tbKeyword_Enter);
            this.btnKeyListSave.BackColor = Color.Transparent;
            this.btnKeyListSave.Cursor = Cursors.Hand;
            this.btnKeyListSave.Image = Resources.smethod_7();
            this.btnKeyListSave.Location = new Point(0x426, 0x63);
            this.btnKeyListSave.Name = "btnKeyListSave";
            this.btnKeyListSave.Size = new Size(0x16, 0x16);
            this.btnKeyListSave.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnKeyListSave.TabIndex = 15;
            this.btnKeyListSave.TabStop = false;
            this.btnKeyListSave.Click += new EventHandler(this.btnKeyListSave_Click);
            this.btnSavePosition.BackColor = Color.White;
            this.btnSavePosition.Cursor = Cursors.Hand;
            this.btnSavePosition.Image = Resources.smethod_7();
            this.btnSavePosition.Location = new Point(0x21b, 0x62);
            this.btnSavePosition.Name = "btnSavePosition";
            this.btnSavePosition.Size = new Size(0x16, 0x16);
            this.btnSavePosition.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnSavePosition.TabIndex = 15;
            this.btnSavePosition.TabStop = false;
            this.btnSavePosition.Click += new EventHandler(this.btnSavePosition_Click);
            this.btnKeyCheckAll.DialogResult = DialogResult.Cancel;
            this.btnKeyCheckAll.FlatStyle = FlatStyle.System;
            this.btnKeyCheckAll.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKeyCheckAll.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKeyCheckAll.Location = new Point(0x3df, 0x61);
            this.btnKeyCheckAll.Name = "btnKeyCheckAll";
            this.btnKeyCheckAll.Size = new Size(0x41, 0x1a);
            this.btnKeyCheckAll.TabIndex = 11;
            this.btnKeyCheckAll.Text = "Check All";
            this.btnKeyCheckAll.UseVisualStyleBackColor = true;
            this.btnKeyCheckAll.Click += new EventHandler(this.btnKeyCheckAll_Click);
            this.cbKeyCate.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbKeyCate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbKeyCate.FlatStyle = FlatStyle.Popup;
            this.cbKeyCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbKeyCate.FormattingEnabled = true;
            this.cbKeyCate.ItemHeight = 13;
            this.cbKeyCate.Location = new Point(0x271, 0x63);
            this.cbKeyCate.Name = "cbKeyCate";
            this.cbKeyCate.Size = new Size(0x14c, 0x15);
            this.cbKeyCate.TabIndex = 10;
            this.cbKeyCate.SelectedIndexChanged += new EventHandler(this.cbKeyCate_SelectedIndexChanged);
            this.cbKeyCate.SelectionChangeCommitted += new EventHandler(this.cbKeyCate_SelectionChangeCommitted);
            this.dtvKeyLogs.AllowUserToAddRows = false;
            this.dtvKeyLogs.AllowUserToDeleteRows = false;
            this.dtvKeyLogs.AllowUserToOrderColumns = true;
            style14.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvKeyLogs.AlternatingRowsDefaultCellStyle = style14;
            this.dtvKeyLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvKeyLogs.BackgroundColor = Color.White;
            this.dtvKeyLogs.BorderStyle = BorderStyle.None;
            style15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style15.BackColor = SystemColors.Control;
            style15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            style15.ForeColor = SystemColors.WindowText;
            style15.SelectionBackColor = SystemColors.Highlight;
            style15.SelectionForeColor = SystemColors.HighlightText;
            style15.WrapMode = DataGridViewTriState.True;
            this.dtvKeyLogs.ColumnHeadersDefaultCellStyle = style15;
            this.dtvKeyLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.ID, this.Keyword, this.Website, this.SERPCount, this.Rank, this.TopOld, this.Lang, this.Ext, this.Column20 };
            this.dtvKeyLogs.Columns.AddRange(dataGridViewColumns);
            this.dtvKeyLogs.ContextMenuStrip = this.mnuKey;
            style16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style16.BackColor = SystemColors.Window;
            style16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            style16.ForeColor = Color.FromArgb(0, 0, 0x40);
            style16.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style16.SelectionForeColor = Color.White;
            style16.WrapMode = DataGridViewTriState.False;
            this.dtvKeyLogs.DefaultCellStyle = style16;
            this.dtvKeyLogs.Location = new Point(0x24a, 0x81);
            this.dtvKeyLogs.MultiSelect = false;
            this.dtvKeyLogs.Name = "dtvKeyLogs";
            this.dtvKeyLogs.ReadOnly = true;
            style17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style17.BackColor = SystemColors.Control;
            style17.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            style17.ForeColor = SystemColors.WindowText;
            style17.SelectionBackColor = SystemColors.HighlightText;
            style17.SelectionForeColor = SystemColors.HighlightText;
            style17.WrapMode = DataGridViewTriState.True;
            this.dtvKeyLogs.RowHeadersDefaultCellStyle = style17;
            this.dtvKeyLogs.RowHeadersWidth = 30;
            this.dtvKeyLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvKeyLogs.Size = new Size(0x1f2, 0x215);
            this.dtvKeyLogs.TabIndex = 12;
            this.dtvKeyLogs.CellClick += new DataGridViewCellEventHandler(this.dtvKeyLogs_CellClick);
            this.dtvKeyLogs.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvKeyLogs_CellDoubleClick);
            this.dtvKeyLogs.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvKeyLogs_RowPostPaint);
            this.ID.FillWeight = 134.7451f;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.Keyword.FillWeight = 138.4815f;
            this.Keyword.HeaderText = "Từ kho\x00e1";
            this.Keyword.Name = "Keyword";
            this.Keyword.ReadOnly = true;
            this.Website.FillWeight = 138.4815f;
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            style18.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.SERPCount.DefaultCellStyle = style18;
            this.SERPCount.FillWeight = 87.41311f;
            this.SERPCount.HeaderText = "SERP";
            this.SERPCount.Name = "SERPCount";
            this.SERPCount.ReadOnly = true;
            style19.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Rank.DefaultCellStyle = style19;
            this.Rank.FillWeight = 31.3014f;
            this.Rank.HeaderText = "Top";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            style20.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.TopOld.DefaultCellStyle = style20;
            this.TopOld.FillWeight = 34.83213f;
            this.TopOld.HeaderText = "Top cũ";
            this.TopOld.Name = "TopOld";
            this.TopOld.ReadOnly = true;
            this.Lang.FillWeight = 134.7451f;
            this.Lang.HeaderText = "Lang";
            this.Lang.Name = "Lang";
            this.Lang.ReadOnly = true;
            this.Lang.Visible = false;
            this.Ext.HeaderText = "Ext";
            this.Ext.Name = "Ext";
            this.Ext.ReadOnly = true;
            this.Ext.Visible = false;
            this.Column20.HeaderText = "Compare";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnKeyCheck, this.btnKeyDelete };
            this.mnuKey.Items.AddRange(toolStripItems);
            this.mnuKey.Name = "mnuKey";
            this.mnuKey.Size = new Size(0x95, 0x30);
            this.btnKeyCheck.Image = Resources.smethod_21();
            this.btnKeyCheck.Name = "btnKeyCheck";
            this.btnKeyCheck.Size = new Size(0x94, 0x16);
            this.btnKeyCheck.Text = "Kiểm tra vị tr\x00ed";
            this.btnKeyCheck.Click += new EventHandler(this.btnKeyCheck_Click);
            this.btnKeyDelete.Image = Resources.smethod_21();
            this.btnKeyDelete.Name = "btnKeyDelete";
            this.btnKeyDelete.Size = new Size(0x94, 0x16);
            this.btnKeyDelete.Text = "Xo\x00e1";
            this.btnKeyDelete.Click += new EventHandler(this.btnKeyDelete_Click);
            this.webMain.Location = new Point(8, 0x61);
            this.webMain.MinimumSize = new Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.ScriptErrorsSuppressed = true;
            this.webMain.Size = new Size(0x23c, 0x235);
            this.webMain.TabIndex = 9;
            this.groupBox1.BackColor = SystemColors.Control;
            this.groupBox1.Controls.Add(this.ckTopMobile);
            this.groupBox1.Controls.Add(this.txtExt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.btnKeySave);
            this.groupBox1.Controls.Add(this.btnKeyAdd);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Controls.Add(this.txtWebCompare);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLang);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox1.Location = new Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x434, 0x55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vị tr\x00ed từ kh\x00f3a Google";
            this.ckTopMobile.AutoSize = true;
            this.ckTopMobile.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ckTopMobile.Location = new Point(0x297, 0x16);
            this.ckTopMobile.Name = "ckTopMobile";
            this.ckTopMobile.Size = new Size(0x55, 20);
            this.ckTopMobile.TabIndex = 20;
            this.ckTopMobile.Text = "Điện thoại";
            this.ckTopMobile.UseVisualStyleBackColor = true;
            this.txtExt.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtExt.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtExt.Location = new Point(0x1f6, 0x13);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new Size(0x35, 0x17);
            this.txtExt.TabIndex = 2;
            this.txtExt.Text = "com.vn";
            this.txtExt.TextAlign = HorizontalAlignment.Center;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label1.Location = new Point(6, 0x18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x37, 0x10);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ kh\x00f3a";
            this.btnCheck.DialogResult = DialogResult.Cancel;
            this.btnCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheck.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheck.Location = new Point(0x2f2, 14);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new Size(0x6a, 0x1f);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Kiểm Tra Vị Tr\x00ed";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new EventHandler(this.btnCheck_Click);
            this.btnKeySave.DialogResult = DialogResult.Cancel;
            this.btnKeySave.FlatStyle = FlatStyle.System;
            this.btnKeySave.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKeySave.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKeySave.Location = new Point(0x3cb, 14);
            this.btnKeySave.Name = "btnKeySave";
            this.btnKeySave.Size = new Size(0x63, 0x1f);
            this.btnKeySave.TabIndex = 6;
            this.btnKeySave.Text = "Lưu Từ Kho\x00e1";
            this.btnKeySave.UseVisualStyleBackColor = true;
            this.btnKeySave.Click += new EventHandler(this.btnKeySave_Click);
            this.btnKeyAdd.DialogResult = DialogResult.Cancel;
            this.btnKeyAdd.FlatStyle = FlatStyle.System;
            this.btnKeyAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKeyAdd.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKeyAdd.Location = new Point(0x362, 14);
            this.btnKeyAdd.Name = "btnKeyAdd";
            this.btnKeyAdd.Size = new Size(0x63, 0x1f);
            this.btnKeyAdd.TabIndex = 5;
            this.btnKeyAdd.Text = "Th\x00eam Từ Kho\x00e1";
            this.btnKeyAdd.UseVisualStyleBackColor = true;
            this.btnKeyAdd.Click += new EventHandler(this.btnKeyAdd_Click);
            this.txtKeyword.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKeyword.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKeyword.Location = new Point(0x43, 0x15);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new Size(0x16d, 0x17);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.KeyUp += new KeyEventHandler(this.txtDomain_KeyUp);
            this.txtWebCompare.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtWebCompare.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtWebCompare.Location = new Point(0x1ab, 0x33);
            this.txtWebCompare.Name = "txtWebCompare";
            this.txtWebCompare.Size = new Size(0x283, 0x17);
            this.txtWebCompare.TabIndex = 8;
            this.txtWebCompare.KeyUp += new KeyEventHandler(this.txtDomain_KeyUp);
            this.txtDomain.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDomain.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtDomain.Location = new Point(0x43, 50);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new Size(0xfb, 0x17);
            this.txtDomain.TabIndex = 7;
            this.txtDomain.KeyUp += new KeyEventHandler(this.txtDomain_KeyUp);
            this.label20.AutoSize = true;
            this.label20.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label20.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label20.Location = new Point(0x1b6, 0x17);
            this.label20.Name = "label20";
            this.label20.Size = new Size(0x3a, 0x10);
            this.label20.TabIndex = 1;
            this.label20.Text = "Quốc gia";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label3.Location = new Point(0x231, 0x16);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x3f, 0x10);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ng\x00f4n ngữ";
            this.txtLang.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtLang.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtLang.Location = new Point(630, 0x13);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new Size(0x1b, 0x17);
            this.txtLang.TabIndex = 3;
            this.txtLang.Text = "vi";
            this.txtLang.TextAlign = HorizontalAlignment.Center;
            this.label24.AutoSize = true;
            this.label24.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label24.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label24.Location = new Point(0x144, 0x36);
            this.label24.Name = "label24";
            this.label24.Size = new Size(0x61, 0x10);
            this.label24.TabIndex = 1;
            this.label24.Text = "Website đối thủ";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label2.Location = new Point(6, 0x35);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x36, 0x10);
            this.label2.TabIndex = 1;
            this.label2.Text = "Website";
            this.label19.AutoSize = true;
            this.label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label19.Location = new Point(0x247, 0x66);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x29, 0x10);
            this.label19.TabIndex = 1;
            this.label19.Text = "Nh\x00f3m";
            this.btnKeyCateAdd.BackColor = SystemColors.Control;
            this.btnKeyCateAdd.Cursor = Cursors.Hand;
            this.btnKeyCateAdd.Image = Resources.smethod_14();
            this.btnKeyCateAdd.Location = new Point(0x3c3, 0x63);
            this.btnKeyCateAdd.Name = "btnKeyCateAdd";
            this.btnKeyCateAdd.Size = new Size(0x16, 0x16);
            this.btnKeyCateAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnKeyCateAdd.TabIndex = 0x12;
            this.btnKeyCateAdd.TabStop = false;
            this.btnKeyCateAdd.Click += new EventHandler(this.btnKeyCateAdd_Click);
            this.tbMain.Appearance = TabAppearance.FlatButtons;
            this.tbMain.Controls.Add(this.tbKeyResearch);
            this.tbMain.Controls.Add(this.tbKeyword);
            this.tbMain.Controls.Add(this.tbKeywordTool);
            this.tbMain.Controls.Add(this.tbWebAnalytics);
            this.tbMain.Controls.Add(this.tbCheckBacklink);
            this.tbMain.Controls.Add(this.tbSeoTool);
            this.tbMain.Controls.Add(this.tbSearchBL);
            this.tbMain.Controls.Add(this.tbSocial);
            this.tbMain.Controls.Add(this.tbAdword);
            this.tbMain.Controls.Add(this.tbView);
            this.tbMain.Controls.Add(this.tbRival);
            this.tbMain.Controls.Add(this.tbPingURL);
            this.tbMain.Controls.Add(this.tbBacklink);
            this.tbMain.Controls.Add(this.tbNews);
            this.tbMain.Controls.Add(this.tbHTML);
            this.tbMain.Controls.Add(this.tbSubmit);
            this.tbMain.Controls.Add(this.tbArticle);
            this.tbMain.Controls.Add(this.tbRegex);
            this.tbMain.Dock = DockStyle.Fill;
            this.tbMain.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.tbMain.ImeMode = ImeMode.NoControl;
            this.tbMain.Location = new Point(0, 0x19);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.Padding = new Point(10, 6);
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new Size(0x44c, 0x2df);
            this.tbMain.TabIndex = 3;
            this.tbKeyResearch.Controls.Add(this.groupBox19);
            this.tbKeyResearch.Controls.Add(this.groupBox15);
            this.tbKeyResearch.Controls.Add(this.groupBox14);
            this.tbKeyResearch.Controls.Add(this.groupBox13);
            this.tbKeyResearch.Location = new Point(4, 0x3d);
            this.tbKeyResearch.Name = "tbKeyResearch";
            this.tbKeyResearch.Size = new Size(0x444, 670);
            this.tbKeyResearch.TabIndex = 10;
            this.tbKeyResearch.Text = "Gợi \x00fd Từ kho\x00e1";
            this.tbKeyResearch.UseVisualStyleBackColor = true;
            this.tbKeyResearch.Enter += new EventHandler(this.tbKeyResearch_Enter);
            this.groupBox19.Controls.Add(this.webKeyRelated);
            this.groupBox19.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox19.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox19.Location = new Point(0x325, 0x43);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new Size(0x117, 0x12f);
            this.groupBox19.TabIndex = 0x18;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Từ kho\x00e1 li\x00ean quan && YouTube";
            this.webKeyRelated.Location = new Point(6, 0x12);
            this.webKeyRelated.MinimumSize = new Size(20, 20);
            this.webKeyRelated.Name = "webKeyRelated";
            this.webKeyRelated.ScriptErrorsSuppressed = true;
            this.webKeyRelated.Size = new Size(0x10b, 0x117);
            this.webKeyRelated.TabIndex = 9;
            this.groupBox15.Controls.Add(this.lbTagsTotal);
            this.groupBox15.Controls.Add(this.dtvTags);
            this.groupBox15.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox15.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox15.Location = new Point(0x325, 0x178);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new Size(0x117, 0x121);
            this.groupBox15.TabIndex = 0x16;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Tags Cloud";
            this.lbTagsTotal.AutoSize = true;
            this.lbTagsTotal.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbTagsTotal.ForeColor = Color.Red;
            this.lbTagsTotal.Location = new Point(6, 0x12);
            this.lbTagsTotal.Name = "lbTagsTotal";
            this.lbTagsTotal.Size = new Size(0x3f, 0x10);
            this.lbTagsTotal.TabIndex = 0x17;
            this.lbTagsTotal.Text = "Kết quả!";
            this.lbTagsTotal.TextAlign = ContentAlignment.MiddleLeft;
            this.dtvTags.AllowUserToAddRows = false;
            this.dtvTags.AllowUserToDeleteRows = false;
            this.dtvTags.AllowUserToOrderColumns = true;
            style21.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvTags.AlternatingRowsDefaultCellStyle = style21;
            this.dtvTags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvTags.BackgroundColor = Color.White;
            this.dtvTags.BorderStyle = BorderStyle.None;
            style22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style22.BackColor = SystemColors.Control;
            style22.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style22.ForeColor = SystemColors.WindowText;
            style22.SelectionBackColor = SystemColors.Highlight;
            style22.SelectionForeColor = SystemColors.HighlightText;
            style22.WrapMode = DataGridViewTriState.True;
            this.dtvTags.ColumnHeadersDefaultCellStyle = style22;
            this.dtvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.Key2, this.Loop2 };
            this.dtvTags.Columns.AddRange(dataGridViewColumns);
            style23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style23.BackColor = SystemColors.Window;
            style23.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style23.ForeColor = Color.FromArgb(0, 0, 0x40);
            style23.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style23.SelectionForeColor = Color.White;
            style23.WrapMode = DataGridViewTriState.False;
            this.dtvTags.DefaultCellStyle = style23;
            this.dtvTags.Location = new Point(6, 0x25);
            this.dtvTags.MultiSelect = false;
            this.dtvTags.Name = "dtvTags";
            this.dtvTags.ReadOnly = true;
            style24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style24.BackColor = SystemColors.Control;
            style24.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style24.ForeColor = SystemColors.WindowText;
            style24.SelectionBackColor = SystemColors.HighlightText;
            style24.SelectionForeColor = SystemColors.HighlightText;
            style24.WrapMode = DataGridViewTriState.True;
            this.dtvTags.RowHeadersDefaultCellStyle = style24;
            this.dtvTags.RowHeadersWidth = 40;
            this.dtvTags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvTags.Size = new Size(0x10b, 0xf4);
            this.dtvTags.TabIndex = 10;
            this.dtvTags.CellClick += new DataGridViewCellEventHandler(this.dtvTags_CellClick);
            this.dtvTags.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvTags_RowPostPaint);
            this.Key2.FillWeight = 118.7817f;
            this.Key2.HeaderText = "Từ kh\x00f3a";
            this.Key2.Name = "Key2";
            this.Key2.ReadOnly = true;
            this.Loop2.FillWeight = 81.21828f;
            this.Loop2.HeaderText = "Chỉ số lặp";
            this.Loop2.Name = "Loop2";
            this.Loop2.ReadOnly = true;
            this.groupBox14.Controls.Add(this.dtvSuggest);
            this.groupBox14.Controls.Add(this.btnSaveSuggest);
            this.groupBox14.Controls.Add(this.lbSuggestTotal);
            this.groupBox14.Controls.Add(this.btnKeyFilter);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.label29);
            this.groupBox14.Controls.Add(this.txtKeyFilter);
            this.groupBox14.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox14.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox14.Location = new Point(4, 0x43);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new Size(0x31b, 0x256);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Từ kh\x00f3a";
            this.dtvSuggest.AllowUserToAddRows = false;
            this.dtvSuggest.AllowUserToDeleteRows = false;
            this.dtvSuggest.AllowUserToOrderColumns = true;
            style25.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvSuggest.AlternatingRowsDefaultCellStyle = style25;
            this.dtvSuggest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvSuggest.BackgroundColor = Color.White;
            this.dtvSuggest.BorderStyle = BorderStyle.None;
            style26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style26.BackColor = SystemColors.Control;
            style26.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style26.ForeColor = SystemColors.WindowText;
            style26.SelectionBackColor = SystemColors.Highlight;
            style26.SelectionForeColor = SystemColors.HighlightText;
            style26.WrapMode = DataGridViewTriState.True;
            this.dtvSuggest.ColumnHeadersDefaultCellStyle = style26;
            this.dtvSuggest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.Key, this.Top, this.Result, this.Loop };
            this.dtvSuggest.Columns.AddRange(dataGridViewColumns);
            this.dtvSuggest.ContextMenuStrip = this.mnuSuggest;
            style27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style27.BackColor = SystemColors.Window;
            style27.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style27.ForeColor = Color.FromArgb(0, 0, 0x40);
            style27.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style27.SelectionForeColor = SystemColors.HighlightText;
            style27.WrapMode = DataGridViewTriState.False;
            this.dtvSuggest.DefaultCellStyle = style27;
            this.dtvSuggest.Location = new Point(9, 0x4a);
            this.dtvSuggest.Name = "dtvSuggest";
            style28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style28.BackColor = SystemColors.Control;
            style28.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style28.ForeColor = SystemColors.WindowText;
            style28.SelectionBackColor = SystemColors.HighlightText;
            style28.SelectionForeColor = SystemColors.HighlightText;
            style28.WrapMode = DataGridViewTriState.True;
            this.dtvSuggest.RowHeadersDefaultCellStyle = style28;
            this.dtvSuggest.RowHeadersWidth = 40;
            this.dtvSuggest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvSuggest.Size = new Size(0x309, 0x206);
            this.dtvSuggest.TabIndex = 8;
            this.dtvSuggest.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvSuggest_RowPostPaint);
            this.Key.FillWeight = 221.5572f;
            this.Key.HeaderText = "Từ kh\x00f3a gợi \x00fd";
            this.Key.Name = "Key";
            style29.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Top.DefaultCellStyle = style29;
            this.Top.FillWeight = 49.44354f;
            this.Top.HeaderText = "Ưu ti\x00ean";
            this.Top.Name = "Top";
            style30.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Result.DefaultCellStyle = style30;
            this.Result.FillWeight = 68.08559f;
            this.Result.HeaderText = "Kết quả t\x00ecm kiếm";
            this.Result.Name = "Result";
            style31.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Loop.DefaultCellStyle = style31;
            this.Loop.FillWeight = 60.9137f;
            this.Loop.HeaderText = "Chỉ số lặp";
            this.Loop.Name = "Loop";
            toolStripItems = new ToolStripItem[] { this.mbtnSERP, this.mbtnSearch, this.mbtnTopGoogle, this.mbtnResearch, this.mbtnInsights };
            this.mnuSuggest.Items.AddRange(toolStripItems);
            this.mnuSuggest.Name = "mnuSuggest";
            this.mnuSuggest.Size = new Size(0x133, 0x72);
            this.mbtnSERP.Image = Resources.smethod_21();
            this.mbtnSERP.Name = "mbtnSERP";
            this.mbtnSERP.Size = new Size(0x132, 0x16);
            this.mbtnSERP.Text = "Mức độ cạnh tranh";
            this.mbtnSERP.Click += new EventHandler(this.mbtnSERP_Click);
            this.mbtnSearch.Image = Resources.smethod_21();
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new Size(0x132, 0x16);
            this.mbtnSearch.Text = "T\x00ecm kiếm từ kh\x00f3a (Google Search)";
            this.mbtnSearch.Click += new EventHandler(this.mbtnSearch_Click);
            this.mbtnTopGoogle.Image = Resources.smethod_21();
            this.mbtnTopGoogle.Name = "mbtnTopGoogle";
            this.mbtnTopGoogle.Size = new Size(0x132, 0x16);
            this.mbtnTopGoogle.Text = "Kiểm tra TOP Google";
            this.mbtnTopGoogle.Click += new EventHandler(this.mbtnTopGoogle_Click);
            this.mbtnResearch.Image = Resources.smethod_21();
            this.mbtnResearch.Name = "mbtnResearch";
            this.mbtnResearch.Size = new Size(0x132, 0x16);
            this.mbtnResearch.Text = "Ph\x00e2n t\x00edch từ kh\x00f3a (Google Keyword Research)";
            this.mbtnResearch.Click += new EventHandler(this.mbtnResearch_Click);
            this.mbtnInsights.Image = Resources.smethod_21();
            this.mbtnInsights.Name = "mbtnInsights";
            this.mbtnInsights.Size = new Size(0x132, 0x16);
            this.mbtnInsights.Text = "So s\x00e1nh khố lượng t\x00ecm kiếm (Google Insights)";
            this.mbtnInsights.Click += new EventHandler(this.mbtnInsights_Click);
            this.btnSaveSuggest.BackColor = Color.Transparent;
            this.btnSaveSuggest.Cursor = Cursors.Hand;
            this.btnSaveSuggest.Image = Resources.smethod_7();
            this.btnSaveSuggest.Location = new Point(0x2fc, 0x2d);
            this.btnSaveSuggest.Name = "btnSaveSuggest";
            this.btnSaveSuggest.Size = new Size(0x16, 0x17);
            this.btnSaveSuggest.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnSaveSuggest.TabIndex = 0x16;
            this.btnSaveSuggest.TabStop = false;
            this.btnSaveSuggest.Click += new EventHandler(this.btnSaveSuggest_Click);
            this.lbSuggestTotal.AutoSize = true;
            this.lbSuggestTotal.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbSuggestTotal.ForeColor = Color.Red;
            this.lbSuggestTotal.Location = new Point(6, 0x2f);
            this.lbSuggestTotal.Name = "lbSuggestTotal";
            this.lbSuggestTotal.Size = new Size(0x3f, 0x10);
            this.lbSuggestTotal.TabIndex = 0x16;
            this.lbSuggestTotal.Text = "Kết quả!";
            this.lbSuggestTotal.TextAlign = ContentAlignment.MiddleRight;
            this.btnKeyFilter.DialogResult = DialogResult.Cancel;
            this.btnKeyFilter.FlatStyle = FlatStyle.System;
            this.btnKeyFilter.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKeyFilter.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKeyFilter.Location = new Point(0x2b0, 11);
            this.btnKeyFilter.Name = "btnKeyFilter";
            this.btnKeyFilter.Size = new Size(0x65, 0x1f);
            this.btnKeyFilter.TabIndex = 7;
            this.btnKeyFilter.Text = "Lọc Kết Quả";
            this.btnKeyFilter.UseVisualStyleBackColor = true;
            this.btnKeyFilter.Click += new EventHandler(this.btnKeyFilter_Click);
            this.label27.AutoSize = true;
            this.label27.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label27.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label27.Location = new Point(0x240, 0x31);
            this.label27.Name = "label27";
            this.label27.RightToLeft = RightToLeft.Yes;
            this.label27.Size = new Size(0xb6, 0x10);
            this.label27.TabIndex = 1;
            this.label27.Text = "[Click phải chuột để lựa chọn!]";
            this.label29.AutoSize = true;
            this.label29.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label29.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label29.Location = new Point(6, 0x12);
            this.label29.Name = "label29";
            this.label29.Size = new Size(0x4b, 0x10);
            this.label29.TabIndex = 1;
            this.label29.Text = "Từ kh\x00f3a lọc";
            this.txtKeyFilter.BorderStyle = BorderStyle.FixedSingle;
            this.txtKeyFilter.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKeyFilter.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKeyFilter.Location = new Point(0x57, 15);
            this.txtKeyFilter.Name = "txtKeyFilter";
            this.txtKeyFilter.Size = new Size(0x253, 0x17);
            this.txtKeyFilter.TabIndex = 6;
            this.txtKeyFilter.KeyUp += new KeyEventHandler(this.txtKeyFilter_KeyUp);
            this.groupBox13.Controls.Add(this.btnCheckSERP);
            this.groupBox13.Controls.Add(this.cbDepthKey);
            this.groupBox13.Controls.Add(this.label9);
            this.groupBox13.Controls.Add(this.txtExtSuggest);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.btnSuggest);
            this.groupBox13.Controls.Add(this.label4);
            this.groupBox13.Controls.Add(this.txtKeyResearch);
            this.groupBox13.Controls.Add(this.label26);
            this.groupBox13.Controls.Add(this.txtLangSuggest);
            this.groupBox13.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox13.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox13.Location = new Point(4, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new Size(0x438, 0x3a);
            this.groupBox13.TabIndex = 6;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Ph\x00e2n t\x00edch từ kh\x00f3a";
            this.btnCheckSERP.DialogResult = DialogResult.Cancel;
            this.btnCheckSERP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckSERP.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckSERP.Location = new Point(0x3da, 0x11);
            this.btnCheckSERP.Name = "btnCheckSERP";
            this.btnCheckSERP.Size = new Size(0x58, 0x1f);
            this.btnCheckSERP.TabIndex = 5;
            this.btnCheckSERP.Text = "Cạnh Tranh";
            this.btnCheckSERP.UseVisualStyleBackColor = true;
            this.btnCheckSERP.Click += new EventHandler(this.btnCheckSERP_Click);
            this.cbDepthKey.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbDepthKey.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbDepthKey.FlatStyle = FlatStyle.Popup;
            this.cbDepthKey.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbDepthKey.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbDepthKey.FormattingEnabled = true;
            object[] items = new object[] { "1", "2" };
            this.cbDepthKey.Items.AddRange(items);
            this.cbDepthKey.Location = new Point(0x34f, 20);
            this.cbDepthKey.Name = "cbDepthKey";
            this.cbDepthKey.Size = new Size(0x39, 0x18);
            this.cbDepthKey.TabIndex = 3;
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label9.Location = new Point(0x319, 0x18);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x30, 0x10);
            this.label9.TabIndex = 0x18;
            this.label9.Text = "Độ s\x00e2u";
            this.txtExtSuggest.BorderStyle = BorderStyle.FixedSingle;
            this.txtExtSuggest.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtExtSuggest.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtExtSuggest.Location = new Point(0x286, 0x15);
            this.txtExtSuggest.Name = "txtExtSuggest";
            this.txtExtSuggest.Size = new Size(0x35, 0x17);
            this.txtExtSuggest.TabIndex = 1;
            this.txtExtSuggest.Text = "com.vn";
            this.txtExtSuggest.TextAlign = HorizontalAlignment.Center;
            this.label22.AutoSize = true;
            this.label22.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label22.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label22.Location = new Point(0x246, 0x18);
            this.label22.Name = "label22";
            this.label22.Size = new Size(0x3a, 0x10);
            this.label22.TabIndex = 0x16;
            this.label22.Text = "Quốc gia";
            this.btnSuggest.DialogResult = DialogResult.Cancel;
            this.btnSuggest.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSuggest.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSuggest.Location = new Point(910, 0x11);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new Size(70, 0x1f);
            this.btnSuggest.TabIndex = 4;
            this.btnSuggest.Text = "Gợi \x00fd Key";
            this.btnSuggest.UseVisualStyleBackColor = true;
            this.btnSuggest.Click += new EventHandler(this.btnSuggest_Click);
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label4.Location = new Point(6, 0x18);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x37, 0x10);
            this.label4.TabIndex = 1;
            this.label4.Text = "Từ kh\x00f3a";
            this.txtKeyResearch.BorderStyle = BorderStyle.FixedSingle;
            this.txtKeyResearch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKeyResearch.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKeyResearch.Location = new Point(0x57, 0x15);
            this.txtKeyResearch.Name = "txtKeyResearch";
            this.txtKeyResearch.Size = new Size(0x1e9, 0x17);
            this.txtKeyResearch.TabIndex = 0;
            this.txtKeyResearch.KeyUp += new KeyEventHandler(this.txtKeyResearch_KeyUp);
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label26.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label26.Location = new Point(0x2c1, 0x18);
            this.label26.Name = "label26";
            this.label26.Size = new Size(0x3f, 0x10);
            this.label26.TabIndex = 1;
            this.label26.Text = "Ng\x00f4n ngữ";
            this.txtLangSuggest.BorderStyle = BorderStyle.FixedSingle;
            this.txtLangSuggest.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtLangSuggest.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtLangSuggest.Location = new Point(0x301, 0x15);
            this.txtLangSuggest.Name = "txtLangSuggest";
            this.txtLangSuggest.Size = new Size(0x17, 0x17);
            this.txtLangSuggest.TabIndex = 2;
            this.txtLangSuggest.Text = "vi";
            this.txtLangSuggest.TextAlign = HorizontalAlignment.Center;
            this.tbKeywordTool.Controls.Add(this.groupBox37);
            this.tbKeywordTool.Controls.Add(this.groupBox36);
            this.tbKeywordTool.Location = new Point(4, 0x3d);
            this.tbKeywordTool.Name = "tbKeywordTool";
            this.tbKeywordTool.Size = new Size(0x444, 670);
            this.tbKeywordTool.TabIndex = 0x13;
            this.tbKeywordTool.Text = "Keyword Tools";
            this.tbKeywordTool.UseVisualStyleBackColor = true;
            this.tbKeywordTool.Enter += new EventHandler(this.tbKeywordTool_Enter);
            this.groupBox37.Controls.Add(this.btnKTCheckSERP);
            this.groupBox37.Controls.Add(this.label90);
            this.groupBox37.Controls.Add(this.btnKTSave);
            this.groupBox37.Controls.Add(this.btnKTCheckDomain);
            this.groupBox37.Controls.Add(this.label92);
            this.groupBox37.Controls.Add(this.label91);
            this.groupBox37.Controls.Add(this.txtKTExt);
            this.groupBox37.Controls.Add(this.btnKTFilter);
            this.groupBox37.Controls.Add(this.txtKTDomain);
            this.groupBox37.Controls.Add(this.label89);
            this.groupBox37.Controls.Add(this.txtKTKeyFilter);
            this.groupBox37.Controls.Add(this.dtvKTList);
            this.groupBox37.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox37.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox37.Location = new Point(4, 0x43);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new Size(0x438, 0x253);
            this.groupBox37.TabIndex = 30;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "Danh s\x00e1ch b\x00e0i viết (Double Click để chọn)";
            this.btnKTCheckSERP.DialogResult = DialogResult.Cancel;
            this.btnKTCheckSERP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKTCheckSERP.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKTCheckSERP.Location = new Point(0x3be, 0x13);
            this.btnKTCheckSERP.Name = "btnKTCheckSERP";
            this.btnKTCheckSERP.Size = new Size(0x58, 0x1f);
            this.btnKTCheckSERP.TabIndex = 10;
            this.btnKTCheckSERP.Text = "Check SERP";
            this.btnKTCheckSERP.UseVisualStyleBackColor = true;
            this.btnKTCheckSERP.Click += new EventHandler(this.btnKTCheckSERP_Click);
            this.label90.AutoSize = true;
            this.label90.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label90.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label90.Location = new Point(0x37c, 0x40);
            this.label90.Name = "label90";
            this.label90.RightToLeft = RightToLeft.Yes;
            this.label90.Size = new Size(0xb6, 0x10);
            this.label90.TabIndex = 0x1b;
            this.label90.Text = "[Click phải chuột để lựa chọn!]";
            this.btnKTSave.BackColor = Color.Transparent;
            this.btnKTSave.Cursor = Cursors.Hand;
            this.btnKTSave.Image = Resources.smethod_7();
            this.btnKTSave.Location = new Point(0x41c, 0x18);
            this.btnKTSave.Name = "btnKTSave";
            this.btnKTSave.Size = new Size(0x16, 0x17);
            this.btnKTSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnKTSave.TabIndex = 0x1a;
            this.btnKTSave.TabStop = false;
            this.btnKTSave.Click += new EventHandler(this.btnKTSave_Click);
            this.btnKTCheckDomain.DialogResult = DialogResult.Cancel;
            this.btnKTCheckDomain.FlatStyle = FlatStyle.System;
            this.btnKTCheckDomain.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKTCheckDomain.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKTCheckDomain.Location = new Point(0x311, 0x39);
            this.btnKTCheckDomain.Name = "btnKTCheckDomain";
            this.btnKTCheckDomain.Size = new Size(0x65, 0x1f);
            this.btnKTCheckDomain.TabIndex = 13;
            this.btnKTCheckDomain.Text = "Check Domain";
            this.btnKTCheckDomain.UseVisualStyleBackColor = true;
            this.btnKTCheckDomain.Click += new EventHandler(this.btnKTCheckDomain_Click);
            this.label92.AutoSize = true;
            this.label92.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label92.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label92.Location = new Point(0x1fc, 0x40);
            this.label92.Name = "label92";
            this.label92.Size = new Size(0x19, 0x10);
            this.label92.TabIndex = 0x18;
            this.label92.Text = "Ext";
            this.label91.AutoSize = true;
            this.label91.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label91.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label91.Location = new Point(6, 0x40);
            this.label91.Name = "label91";
            this.label91.Size = new Size(0x59, 0x10);
            this.label91.TabIndex = 0x18;
            this.label91.Text = "Check Domain";
            this.txtKTExt.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTExt.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTExt.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTExt.Location = new Point(0x21b, 0x3d);
            this.txtKTExt.Name = "txtKTExt";
            this.txtKTExt.Size = new Size(240, 0x17);
            this.txtKTExt.TabIndex = 12;
            this.txtKTExt.Text = "com,vn,org,com.vn,net.vn,net";
            this.txtKTExt.TextAlign = HorizontalAlignment.Center;
            this.btnKTFilter.DialogResult = DialogResult.Cancel;
            this.btnKTFilter.FlatStyle = FlatStyle.System;
            this.btnKTFilter.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKTFilter.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKTFilter.Location = new Point(0x353, 0x13);
            this.btnKTFilter.Name = "btnKTFilter";
            this.btnKTFilter.Size = new Size(0x65, 0x1f);
            this.btnKTFilter.TabIndex = 9;
            this.btnKTFilter.Text = "Lọc Kết Quả";
            this.btnKTFilter.UseVisualStyleBackColor = true;
            this.btnKTFilter.Click += new EventHandler(this.btnKTFilter_Click);
            this.txtKTDomain.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTDomain.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTDomain.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTDomain.Location = new Point(0x61, 0x3d);
            this.txtKTDomain.Name = "txtKTDomain";
            this.txtKTDomain.Size = new Size(0x195, 0x17);
            this.txtKTDomain.TabIndex = 11;
            this.txtKTDomain.KeyUp += new KeyEventHandler(this.txtKTDomain_KeyUp);
            this.label89.AutoSize = true;
            this.label89.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label89.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label89.Location = new Point(6, 0x1b);
            this.label89.Name = "label89";
            this.label89.Size = new Size(0x4b, 0x10);
            this.label89.TabIndex = 0x18;
            this.label89.Text = "Từ kh\x00f3a lọc";
            this.txtKTKeyFilter.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTKeyFilter.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTKeyFilter.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTKeyFilter.Location = new Point(0x61, 0x18);
            this.txtKTKeyFilter.Name = "txtKTKeyFilter";
            this.txtKTKeyFilter.Size = new Size(0x2ec, 0x17);
            this.txtKTKeyFilter.TabIndex = 8;
            this.txtKTKeyFilter.KeyUp += new KeyEventHandler(this.txtKTKeyFilter_KeyUp);
            this.dtvKTList.AllowUserToAddRows = false;
            this.dtvKTList.AllowUserToDeleteRows = false;
            this.dtvKTList.AllowUserToOrderColumns = true;
            style32.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvKTList.AlternatingRowsDefaultCellStyle = style32;
            this.dtvKTList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvKTList.BackgroundColor = Color.White;
            this.dtvKTList.BorderStyle = BorderStyle.None;
            style33.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style33.BackColor = SystemColors.Control;
            style33.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style33.ForeColor = SystemColors.WindowText;
            style33.SelectionBackColor = SystemColors.Highlight;
            style33.SelectionForeColor = SystemColors.HighlightText;
            style33.WrapMode = DataGridViewTriState.True;
            this.dtvKTList.ColumnHeadersDefaultCellStyle = style33;
            this.dtvKTList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.TuKhoa, this.CanhTranh, this.TimKiemToanCau, this.TimKiemCucBo, this.SERP, this.KEI1, this.KEI2 };
            this.dtvKTList.Columns.AddRange(dataGridViewColumns);
            this.dtvKTList.ContextMenuStrip = this.mnuSuggest_1;
            style34.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style34.BackColor = SystemColors.Window;
            style34.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style34.ForeColor = Color.FromArgb(0, 0, 0x40);
            style34.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style34.SelectionForeColor = Color.White;
            style34.WrapMode = DataGridViewTriState.False;
            this.dtvKTList.DefaultCellStyle = style34;
            this.dtvKTList.Location = new Point(9, 100);
            this.dtvKTList.MultiSelect = false;
            this.dtvKTList.Name = "dtvKTList";
            this.dtvKTList.ReadOnly = true;
            style35.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style35.BackColor = SystemColors.Control;
            style35.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style35.ForeColor = SystemColors.WindowText;
            style35.SelectionBackColor = SystemColors.HighlightText;
            style35.SelectionForeColor = SystemColors.HighlightText;
            style35.WrapMode = DataGridViewTriState.True;
            this.dtvKTList.RowHeadersDefaultCellStyle = style35;
            this.dtvKTList.RowHeadersWidth = 30;
            this.dtvKTList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvKTList.Size = new Size(0x429, 0x1e9);
            this.dtvKTList.TabIndex = 14;
            this.dtvKTList.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvKTList_RowPostPaint);
            this.TuKhoa.FillWeight = 174.6964f;
            this.TuKhoa.HeaderText = "Từ kho\x00e1";
            this.TuKhoa.Name = "TuKhoa";
            this.TuKhoa.ReadOnly = true;
            style36.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.CanhTranh.DefaultCellStyle = style36;
            this.CanhTranh.FillWeight = 63.35566f;
            this.CanhTranh.HeaderText = "Cạnh tranh";
            this.CanhTranh.Name = "CanhTranh";
            this.CanhTranh.ReadOnly = true;
            style37.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.TimKiemToanCau.DefaultCellStyle = style37;
            this.TimKiemToanCau.FillWeight = 107.8664f;
            this.TimKiemToanCau.HeaderText = "T\x00ecm kiếm to\x00e0n cầu";
            this.TimKiemToanCau.Name = "TimKiemToanCau";
            this.TimKiemToanCau.ReadOnly = true;
            style38.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.TimKiemCucBo.DefaultCellStyle = style38;
            this.TimKiemCucBo.FillWeight = 107.8664f;
            this.TimKiemCucBo.HeaderText = "T\x00ecm kiếm cục bộ";
            this.TimKiemCucBo.Name = "TimKiemCucBo";
            this.TimKiemCucBo.ReadOnly = true;
            style39.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.SERP.DefaultCellStyle = style39;
            this.SERP.FillWeight = 94.97785f;
            this.SERP.HeaderText = "SERP";
            this.SERP.Name = "SERP";
            this.SERP.ReadOnly = true;
            style40.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.KEI1.DefaultCellStyle = style40;
            this.KEI1.FillWeight = 49.16893f;
            this.KEI1.HeaderText = "KEI 1";
            this.KEI1.Name = "KEI1";
            this.KEI1.ReadOnly = true;
            style41.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.KEI2.DefaultCellStyle = style41;
            this.KEI2.FillWeight = 47.82027f;
            this.KEI2.HeaderText = "KEI 2";
            this.KEI2.Name = "KEI2";
            this.KEI2.ReadOnly = true;
            toolStripItems = new ToolStripItem[] { this.btnmKTSearch, this.btnmKTSERP, this.btnmKTCheckDomain, this.btnmKTInsight };
            this.mnuSuggest_1.Items.AddRange(toolStripItems);
            this.mnuSuggest_1.Name = "mnuSuggest";
            this.mnuSuggest_1.Size = new Size(300, 0x5c);
            this.btnmKTSearch.Image = Resources.smethod_21();
            this.btnmKTSearch.Name = "btnmKTSearch";
            this.btnmKTSearch.Size = new Size(0x12b, 0x16);
            this.btnmKTSearch.Text = "T\x00ecm kiếm từ kh\x00f3a (Google Search)";
            this.btnmKTSearch.Click += new EventHandler(this.btnmKTSearch_Click);
            this.btnmKTSERP.Image = Resources.smethod_21();
            this.btnmKTSERP.Name = "btnmKTSERP";
            this.btnmKTSERP.Size = new Size(0x12b, 0x16);
            this.btnmKTSERP.Text = "Mức độ cạnh tranh";
            this.btnmKTSERP.Click += new EventHandler(this.btnmKTSERP_Click);
            this.btnmKTCheckDomain.Image = Resources.smethod_21();
            this.btnmKTCheckDomain.Name = "btnmKTCheckDomain";
            this.btnmKTCheckDomain.Size = new Size(0x12b, 0x16);
            this.btnmKTCheckDomain.Text = "Check Domain";
            this.btnmKTCheckDomain.Click += new EventHandler(this.btnmKTCheckDomain_Click);
            this.btnmKTInsight.Image = Resources.smethod_21();
            this.btnmKTInsight.Name = "btnmKTInsight";
            this.btnmKTInsight.Size = new Size(0x12b, 0x16);
            this.btnmKTInsight.Text = "So s\x00e1nh khố lượng t\x00ecm kiếm (Google Insights)";
            this.btnmKTInsight.Click += new EventHandler(this.btnmKTInsight_Click);
            this.groupBox36.Controls.Add(this.cbKTBrowser);
            this.groupBox36.Controls.Add(this.btnKTRegister);
            this.groupBox36.Controls.Add(this.btnKTLogin);
            this.groupBox36.Controls.Add(this.btnKTSend);
            this.groupBox36.Controls.Add(this.label85);
            this.groupBox36.Controls.Add(this.label84);
            this.groupBox36.Controls.Add(this.label88);
            this.groupBox36.Controls.Add(this.label87);
            this.groupBox36.Controls.Add(this.label86);
            this.groupBox36.Controls.Add(this.txtKTPass);
            this.groupBox36.Controls.Add(this.txtKTEmail);
            this.groupBox36.Controls.Add(this.txtKTLang);
            this.groupBox36.Controls.Add(this.txtKTPosition);
            this.groupBox36.Controls.Add(this.txtKTKey);
            this.groupBox36.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox36.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox36.Location = new Point(4, 3);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new Size(0x438, 0x3a);
            this.groupBox36.TabIndex = 7;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Ph\x00e2n t\x00edch từ kh\x00f3a";
            this.cbKTBrowser.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbKTBrowser.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbKTBrowser.FlatStyle = FlatStyle.Popup;
            this.cbKTBrowser.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbKTBrowser.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbKTBrowser.FormattingEnabled = true;
            this.cbKTBrowser.Location = new Point(0xf1, 20);
            this.cbKTBrowser.Name = "cbKTBrowser";
            this.cbKTBrowser.Size = new Size(0x7b, 0x18);
            this.cbKTBrowser.TabIndex = 8;
            this.btnKTRegister.DialogResult = DialogResult.Cancel;
            this.btnKTRegister.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKTRegister.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKTRegister.Location = new Point(0x3ed, 0x11);
            this.btnKTRegister.Name = "btnKTRegister";
            this.btnKTRegister.Size = new Size(0x45, 0x1f);
            this.btnKTRegister.TabIndex = 7;
            this.btnKTRegister.Text = "Đăng K\x00fd";
            this.btnKTRegister.UseVisualStyleBackColor = true;
            this.btnKTRegister.Click += new EventHandler(this.btnKTRegister_Click);
            this.btnKTLogin.DialogResult = DialogResult.Cancel;
            this.btnKTLogin.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKTLogin.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKTLogin.Location = new Point(0x395, 0x11);
            this.btnKTLogin.Name = "btnKTLogin";
            this.btnKTLogin.Size = new Size(0x52, 0x1f);
            this.btnKTLogin.TabIndex = 7;
            this.btnKTLogin.Text = "Đăng nhập";
            this.btnKTLogin.UseVisualStyleBackColor = true;
            this.btnKTLogin.Click += new EventHandler(this.btnKTLogin_Click);
            this.btnKTSend.DialogResult = DialogResult.Cancel;
            this.btnKTSend.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnKTSend.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnKTSend.Location = new Point(0x225, 0x11);
            this.btnKTSend.Name = "btnKTSend";
            this.btnKTSend.Size = new Size(70, 0x1f);
            this.btnKTSend.TabIndex = 4;
            this.btnKTSend.Text = "T\x00ecm kiếm";
            this.btnKTSend.UseVisualStyleBackColor = true;
            this.btnKTSend.Click += new EventHandler(this.btnKTSend_Click);
            this.label85.AutoSize = true;
            this.label85.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label85.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label85.Location = new Point(0x306, 0x18);
            this.label85.Name = "label85";
            this.label85.Size = new Size(0x22, 0x10);
            this.label85.TabIndex = 1;
            this.label85.Text = "Pass";
            this.label84.AutoSize = true;
            this.label84.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label84.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label84.Location = new Point(0x271, 0x18);
            this.label84.Name = "label84";
            this.label84.Size = new Size(0x27, 0x10);
            this.label84.TabIndex = 1;
            this.label84.Text = "Email";
            this.label88.AutoSize = true;
            this.label88.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label88.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label88.Location = new Point(0x1bc, 0x18);
            this.label88.Name = "label88";
            this.label88.Size = new Size(0x3f, 0x10);
            this.label88.TabIndex = 1;
            this.label88.Text = "Ng\x00f4n ngữ";
            this.label87.AutoSize = true;
            this.label87.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label87.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label87.Location = new Point(370, 0x18);
            this.label87.Name = "label87";
            this.label87.Size = new Size(0x23, 0x10);
            this.label87.TabIndex = 1;
            this.label87.Text = "Vị tr\x00ed";
            this.label86.AutoSize = true;
            this.label86.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label86.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label86.Location = new Point(6, 0x18);
            this.label86.Name = "label86";
            this.label86.Size = new Size(0x37, 0x10);
            this.label86.TabIndex = 1;
            this.label86.Text = "Từ kh\x00f3a";
            this.txtKTPass.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTPass.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTPass.Location = new Point(0x32e, 20);
            this.txtKTPass.Name = "txtKTPass";
            this.txtKTPass.PasswordChar = '*';
            this.txtKTPass.Size = new Size(0x61, 0x17);
            this.txtKTPass.TabIndex = 6;
            this.txtKTPass.KeyUp += new KeyEventHandler(this.txtKTEmail_KeyUp);
            this.txtKTEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTEmail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTEmail.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTEmail.Location = new Point(670, 0x15);
            this.txtKTEmail.Name = "txtKTEmail";
            this.txtKTEmail.Size = new Size(0x62, 0x17);
            this.txtKTEmail.TabIndex = 5;
            this.txtKTEmail.KeyUp += new KeyEventHandler(this.txtKTEmail_KeyUp);
            this.txtKTLang.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTLang.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTLang.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTLang.Location = new Point(0x201, 20);
            this.txtKTLang.Name = "txtKTLang";
            this.txtKTLang.Size = new Size(30, 0x17);
            this.txtKTLang.TabIndex = 3;
            this.txtKTLang.Text = "vi";
            this.txtKTLang.TextAlign = HorizontalAlignment.Center;
            this.txtKTLang.KeyUp += new KeyEventHandler(this.txtKTKey_KeyUp);
            this.txtKTPosition.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTPosition.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTPosition.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTPosition.Location = new Point(0x19b, 20);
            this.txtKTPosition.Name = "txtKTPosition";
            this.txtKTPosition.Size = new Size(0x1b, 0x17);
            this.txtKTPosition.TabIndex = 2;
            this.txtKTPosition.Text = "VN";
            this.txtKTPosition.TextAlign = HorizontalAlignment.Center;
            this.txtKTPosition.KeyUp += new KeyEventHandler(this.txtKTKey_KeyUp);
            this.txtKTKey.BorderStyle = BorderStyle.FixedSingle;
            this.txtKTKey.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKTKey.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKTKey.Location = new Point(0x43, 0x15);
            this.txtKTKey.Name = "txtKTKey";
            this.txtKTKey.Size = new Size(0xa8, 0x17);
            this.txtKTKey.TabIndex = 1;
            this.txtKTKey.KeyUp += new KeyEventHandler(this.txtKTKey_KeyUp);
            this.tbWebAnalytics.Controls.Add(this.groupBox10);
            this.tbWebAnalytics.Location = new Point(4, 0x3d);
            this.tbWebAnalytics.Name = "tbWebAnalytics";
            this.tbWebAnalytics.Size = new Size(0x444, 670);
            this.tbWebAnalytics.TabIndex = 7;
            this.tbWebAnalytics.Text = "Tối ưu Onpage";
            this.tbWebAnalytics.UseVisualStyleBackColor = true;
            this.groupBox10.Controls.Add(this.radioURL2);
            this.groupBox10.Controls.Add(this.radioURL1);
            this.groupBox10.Controls.Add(this.panel1);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.txtKeywordAnalytics);
            this.groupBox10.Controls.Add(this.txtWebsiteUrl2);
            this.groupBox10.Controls.Add(this.txtWebsiteUrl);
            this.groupBox10.Controls.Add(this.btnOptimize);
            this.groupBox10.Controls.Add(this.btnAnalyticsCompare);
            this.groupBox10.Controls.Add(this.btnAnalytics);
            this.groupBox10.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox10.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox10.Location = new Point(8, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new Size(0x439, 0x28d);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ph\x00e2n t\x00edch Website";
            this.radioURL2.AutoSize = true;
            this.radioURL2.Location = new Point(0x246, 0x13);
            this.radioURL2.Name = "radioURL2";
            this.radioURL2.Size = new Size(0x39, 0x12);
            this.radioURL2.TabIndex = 4;
            this.radioURL2.Text = "URL 2";
            this.radioURL2.UseVisualStyleBackColor = true;
            this.radioURL2.CheckedChanged += new EventHandler(this.btnAnalytics_Click);
            this.radioURL1.AutoSize = true;
            this.radioURL1.Checked = true;
            this.radioURL1.Location = new Point(0x108, 0x13);
            this.radioURL1.Name = "radioURL1";
            this.radioURL1.Size = new Size(0x39, 0x12);
            this.radioURL1.TabIndex = 2;
            this.radioURL1.TabStop = true;
            this.radioURL1.Text = "URL 1";
            this.radioURL1.UseVisualStyleBackColor = true;
            this.radioURL1.CheckedChanged += new EventHandler(this.btnAnalytics_Click);
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnAnalyticsLinkSave);
            this.panel1.Controls.Add(this.dtvAnalytics);
            this.panel1.Controls.Add(this.btnSaveAnalytics);
            this.panel1.Controls.Add(this.ckAnchorError);
            this.panel1.Controls.Add(this.ckAnchorTitle);
            this.panel1.Controls.Add(this.ckAnchorNofollow);
            this.panel1.Controls.Add(this.ckAnchorExternal);
            this.panel1.Controls.Add(this.ckAnchorImage);
            this.panel1.Controls.Add(this.btnCheckError);
            this.panel1.Controls.Add(this.label48);
            this.panel1.Controls.Add(this.txtAnalyticsHTML);
            this.panel1.Controls.Add(this.dtvAnalyticsWord4);
            this.panel1.Controls.Add(this.dtvAnalyticsWord3);
            this.panel1.Controls.Add(this.dtvAnalyticsWord2);
            this.panel1.Controls.Add(this.dtvAnalyticsWord1);
            this.panel1.Controls.Add(this.dtvAnalyticsImage);
            this.panel1.Controls.Add(this.lbAnalyticsImage);
            this.panel1.Controls.Add(this.dtvAnalyticsHeading);
            this.panel1.Controls.Add(this.label47);
            this.panel1.Controls.Add(this.label46);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.lbAnalyticsHeading);
            this.panel1.Controls.Add(this.dtvAnalyticsLink);
            this.panel1.Controls.Add(this.lbAnalyticsAnchor);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new Point(6, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x42e, 0x255);
            this.panel1.TabIndex = 15;
            this.btnAnalyticsLinkSave.BackColor = Color.Transparent;
            this.btnAnalyticsLinkSave.Cursor = Cursors.Hand;
            this.btnAnalyticsLinkSave.Image = Resources.smethod_7();
            this.btnAnalyticsLinkSave.Location = new Point(15, 0x1e1);
            this.btnAnalyticsLinkSave.Name = "btnAnalyticsLinkSave";
            this.btnAnalyticsLinkSave.Size = new Size(0x16, 0x16);
            this.btnAnalyticsLinkSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnAnalyticsLinkSave.TabIndex = 0x1c;
            this.btnAnalyticsLinkSave.TabStop = false;
            this.btnAnalyticsLinkSave.Click += new EventHandler(this.btnAnalyticsLinkSave_Click);
            this.dtvAnalytics.AllowUserToAddRows = false;
            this.dtvAnalytics.AllowUserToDeleteRows = false;
            this.dtvAnalytics.AllowUserToOrderColumns = true;
            style42.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalytics.AlternatingRowsDefaultCellStyle = style42;
            this.dtvAnalytics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalytics.BackgroundColor = Color.White;
            this.dtvAnalytics.BorderStyle = BorderStyle.None;
            style43.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style43.BackColor = SystemColors.Control;
            style43.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style43.ForeColor = SystemColors.WindowText;
            style43.SelectionBackColor = SystemColors.Highlight;
            style43.SelectionForeColor = SystemColors.HighlightText;
            style43.WrapMode = DataGridViewTriState.True;
            this.dtvAnalytics.ColumnHeadersDefaultCellStyle = style43;
            this.dtvAnalytics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.MoTa, this.GaiTri, this.TuKhoaOnpage, this.SoLanXuatHien };
            this.dtvAnalytics.Columns.AddRange(dataGridViewColumns);
            style44.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style44.BackColor = SystemColors.Window;
            style44.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style44.ForeColor = Color.FromArgb(0, 0, 0x40);
            style44.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style44.SelectionForeColor = Color.White;
            style44.WrapMode = DataGridViewTriState.False;
            this.dtvAnalytics.DefaultCellStyle = style44;
            this.dtvAnalytics.Location = new Point(6, 0x20);
            this.dtvAnalytics.MultiSelect = false;
            this.dtvAnalytics.Name = "dtvAnalytics";
            this.dtvAnalytics.ReadOnly = true;
            style45.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style45.BackColor = SystemColors.Control;
            style45.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style45.ForeColor = SystemColors.WindowText;
            style45.SelectionBackColor = SystemColors.HighlightText;
            style45.SelectionForeColor = SystemColors.HighlightText;
            style45.WrapMode = DataGridViewTriState.True;
            this.dtvAnalytics.RowHeadersDefaultCellStyle = style45;
            this.dtvAnalytics.RowHeadersWidth = 30;
            this.dtvAnalytics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalytics.Size = new Size(0x412, 0x18d);
            this.dtvAnalytics.TabIndex = 9;
            this.MoTa.HeaderText = "M\x00f4 tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.GaiTri.HeaderText = "Gi\x00e1 trị";
            this.GaiTri.Name = "GaiTri";
            this.GaiTri.ReadOnly = true;
            this.TuKhoaOnpage.HeaderText = "Từ kh\x00f3a";
            this.TuKhoaOnpage.Name = "TuKhoaOnpage";
            this.TuKhoaOnpage.ReadOnly = true;
            this.SoLanXuatHien.HeaderText = "Số lần xuất hiện";
            this.SoLanXuatHien.Name = "SoLanXuatHien";
            this.SoLanXuatHien.ReadOnly = true;
            this.btnSaveAnalytics.BackColor = Color.Transparent;
            this.btnSaveAnalytics.Cursor = Cursors.Hand;
            this.btnSaveAnalytics.Image = Resources.smethod_7();
            this.btnSaveAnalytics.Location = new Point(0x3fb, 3);
            this.btnSaveAnalytics.Name = "btnSaveAnalytics";
            this.btnSaveAnalytics.Size = new Size(0x1f, 0x17);
            this.btnSaveAnalytics.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnSaveAnalytics.TabIndex = 14;
            this.btnSaveAnalytics.TabStop = false;
            this.btnSaveAnalytics.Click += new EventHandler(this.btnSaveAnalytics_Click);
            this.ckAnchorError.AutoSize = true;
            this.ckAnchorError.Location = new Point(0x34a, 0x1bd);
            this.ckAnchorError.Name = "ckAnchorError";
            this.ckAnchorError.Size = new Size(0x34, 0x12);
            this.ckAnchorError.TabIndex = 13;
            this.ckAnchorError.Text = "Error";
            this.ckAnchorError.UseVisualStyleBackColor = true;
            this.ckAnchorError.CheckedChanged += new EventHandler(this.ckAnchorImage_CheckedChanged);
            this.ckAnchorTitle.AutoSize = true;
            this.ckAnchorTitle.Location = new Point(0x255, 0x1bd);
            this.ckAnchorTitle.Name = "ckAnchorTitle";
            this.ckAnchorTitle.Size = new Size(0x59, 0x12);
            this.ckAnchorTitle.TabIndex = 11;
            this.ckAnchorTitle.Text = "Kh\x00f4ng Title";
            this.ckAnchorTitle.UseVisualStyleBackColor = true;
            this.ckAnchorTitle.CheckedChanged += new EventHandler(this.ckAnchorImage_CheckedChanged);
            this.ckAnchorNofollow.AutoSize = true;
            this.ckAnchorNofollow.Location = new Point(0x2fb, 0x1bd);
            this.ckAnchorNofollow.Name = "ckAnchorNofollow";
            this.ckAnchorNofollow.Size = new Size(0x49, 0x12);
            this.ckAnchorNofollow.TabIndex = 12;
            this.ckAnchorNofollow.Text = "Nofollow";
            this.ckAnchorNofollow.UseVisualStyleBackColor = true;
            this.ckAnchorNofollow.CheckedChanged += new EventHandler(this.ckAnchorImage_CheckedChanged);
            this.ckAnchorExternal.AutoSize = true;
            this.ckAnchorExternal.Location = new Point(900, 0x1bd);
            this.ckAnchorExternal.Name = "ckAnchorExternal";
            this.ckAnchorExternal.Size = new Size(70, 0x12);
            this.ckAnchorExternal.TabIndex = 14;
            this.ckAnchorExternal.Text = "External";
            this.ckAnchorExternal.UseVisualStyleBackColor = true;
            this.ckAnchorExternal.CheckedChanged += new EventHandler(this.ckAnchorImage_CheckedChanged);
            this.ckAnchorImage.AutoSize = true;
            this.ckAnchorImage.Location = new Point(0x3d0, 0x1bd);
            this.ckAnchorImage.Name = "ckAnchorImage";
            this.ckAnchorImage.Size = new Size(60, 0x12);
            this.ckAnchorImage.TabIndex = 15;
            this.ckAnchorImage.Text = "Image";
            this.ckAnchorImage.UseVisualStyleBackColor = true;
            this.ckAnchorImage.CheckedChanged += new EventHandler(this.ckAnchorImage_CheckedChanged);
            this.btnCheckError.DialogResult = DialogResult.Cancel;
            this.btnCheckError.FlatStyle = FlatStyle.System;
            this.btnCheckError.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckError.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckError.Location = new Point(0, 0x1b7);
            this.btnCheckError.Name = "btnCheckError";
            this.btnCheckError.Size = new Size(0x54, 0x1c);
            this.btnCheckError.TabIndex = 10;
            this.btnCheckError.Text = "Kiểm tra lỗi";
            this.btnCheckError.UseVisualStyleBackColor = true;
            this.btnCheckError.Click += new EventHandler(this.btnCheckError_Click);
            this.label48.AutoSize = true;
            this.label48.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label48.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label48.Location = new Point(3, 0x814);
            this.label48.Name = "label48";
            this.label48.Size = new Size(100, 0x10);
            this.label48.TabIndex = 0x1b;
            this.label48.Text = "M\x00e3 nguồn HTML";
            this.txtAnalyticsHTML.BorderStyle = BorderStyle.None;
            this.txtAnalyticsHTML.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAnalyticsHTML.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAnalyticsHTML.Location = new Point(-1, 0x82e);
            this.txtAnalyticsHTML.Name = "txtAnalyticsHTML";
            this.txtAnalyticsHTML.Size = new Size(0x418, 0x1d2);
            this.txtAnalyticsHTML.TabIndex = 0x17;
            this.txtAnalyticsHTML.Text = "";
            this.dtvAnalyticsWord4.AllowUserToAddRows = false;
            this.dtvAnalyticsWord4.AllowUserToDeleteRows = false;
            this.dtvAnalyticsWord4.AllowUserToOrderColumns = true;
            style46.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalyticsWord4.AlternatingRowsDefaultCellStyle = style46;
            this.dtvAnalyticsWord4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalyticsWord4.BackgroundColor = Color.White;
            this.dtvAnalyticsWord4.BorderStyle = BorderStyle.None;
            style47.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style47.BackColor = SystemColors.Control;
            style47.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style47.ForeColor = SystemColors.WindowText;
            style47.SelectionBackColor = SystemColors.Highlight;
            style47.SelectionForeColor = SystemColors.HighlightText;
            style47.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord4.ColumnHeadersDefaultCellStyle = style47;
            this.dtvAnalyticsWord4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn17, this.dataGridViewTextBoxColumn18, this.dataGridViewTextBoxColumn19 };
            this.dtvAnalyticsWord4.Columns.AddRange(dataGridViewColumns);
            style48.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style48.BackColor = SystemColors.Window;
            style48.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style48.ForeColor = Color.FromArgb(0, 0, 0x40);
            style48.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style48.SelectionForeColor = Color.White;
            style48.WrapMode = DataGridViewTriState.False;
            this.dtvAnalyticsWord4.DefaultCellStyle = style48;
            this.dtvAnalyticsWord4.Location = new Point(0x30f, 0x604);
            this.dtvAnalyticsWord4.MultiSelect = false;
            this.dtvAnalyticsWord4.Name = "dtvAnalyticsWord4";
            this.dtvAnalyticsWord4.ReadOnly = true;
            style49.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style49.BackColor = SystemColors.Control;
            style49.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style49.ForeColor = SystemColors.WindowText;
            style49.SelectionBackColor = SystemColors.HighlightText;
            style49.SelectionForeColor = SystemColors.HighlightText;
            style49.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord4.RowHeadersDefaultCellStyle = style49;
            this.dtvAnalyticsWord4.RowHeadersWidth = 30;
            this.dtvAnalyticsWord4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalyticsWord4.Size = new Size(0x108, 0x207);
            this.dtvAnalyticsWord4.TabIndex = 0x16;
            this.dtvAnalyticsWord4.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnalyticsWord4_RowPostPaint);
            this.dataGridViewTextBoxColumn17.FillWeight = 139.7233f;
            this.dataGridViewTextBoxColumn17.HeaderText = "Từ kho\x00e1";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.FillWeight = 99.36298f;
            this.dataGridViewTextBoxColumn18.HeaderText = "Mật độ";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.FillWeight = 60.9137f;
            this.dataGridViewTextBoxColumn19.HeaderText = "Lặp";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dtvAnalyticsWord3.AllowUserToAddRows = false;
            this.dtvAnalyticsWord3.AllowUserToDeleteRows = false;
            this.dtvAnalyticsWord3.AllowUserToOrderColumns = true;
            style50.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalyticsWord3.AlternatingRowsDefaultCellStyle = style50;
            this.dtvAnalyticsWord3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalyticsWord3.BackgroundColor = Color.White;
            this.dtvAnalyticsWord3.BorderStyle = BorderStyle.None;
            style51.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style51.BackColor = SystemColors.Control;
            style51.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style51.ForeColor = SystemColors.WindowText;
            style51.SelectionBackColor = SystemColors.Highlight;
            style51.SelectionForeColor = SystemColors.HighlightText;
            style51.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord3.ColumnHeadersDefaultCellStyle = style51;
            this.dtvAnalyticsWord3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn12, this.dataGridViewTextBoxColumn15, this.dataGridViewTextBoxColumn16 };
            this.dtvAnalyticsWord3.Columns.AddRange(dataGridViewColumns);
            style52.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style52.BackColor = SystemColors.Window;
            style52.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style52.ForeColor = Color.FromArgb(0, 0, 0x40);
            style52.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style52.SelectionForeColor = Color.White;
            style52.WrapMode = DataGridViewTriState.False;
            this.dtvAnalyticsWord3.DefaultCellStyle = style52;
            this.dtvAnalyticsWord3.Location = new Point(0x20a, 0x604);
            this.dtvAnalyticsWord3.MultiSelect = false;
            this.dtvAnalyticsWord3.Name = "dtvAnalyticsWord3";
            this.dtvAnalyticsWord3.ReadOnly = true;
            style53.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style53.BackColor = SystemColors.Control;
            style53.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style53.ForeColor = SystemColors.WindowText;
            style53.SelectionBackColor = SystemColors.HighlightText;
            style53.SelectionForeColor = SystemColors.HighlightText;
            style53.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord3.RowHeadersDefaultCellStyle = style53;
            this.dtvAnalyticsWord3.RowHeadersWidth = 30;
            this.dtvAnalyticsWord3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalyticsWord3.Size = new Size(0xff, 0x207);
            this.dtvAnalyticsWord3.TabIndex = 0x15;
            this.dtvAnalyticsWord3.RowPrePaint += new DataGridViewRowPrePaintEventHandler(this.dtvAnalyticsWord3_RowPrePaint);
            this.dataGridViewTextBoxColumn12.FillWeight = 139.7233f;
            this.dataGridViewTextBoxColumn12.HeaderText = "Từ kho\x00e1";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.FillWeight = 99.36298f;
            this.dataGridViewTextBoxColumn15.HeaderText = "Mật độ";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.FillWeight = 60.9137f;
            this.dataGridViewTextBoxColumn16.HeaderText = "Lặp";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dtvAnalyticsWord2.AllowUserToAddRows = false;
            this.dtvAnalyticsWord2.AllowUserToDeleteRows = false;
            this.dtvAnalyticsWord2.AllowUserToOrderColumns = true;
            style54.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalyticsWord2.AlternatingRowsDefaultCellStyle = style54;
            this.dtvAnalyticsWord2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalyticsWord2.BackgroundColor = Color.White;
            this.dtvAnalyticsWord2.BorderStyle = BorderStyle.None;
            style55.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style55.BackColor = SystemColors.Control;
            style55.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style55.ForeColor = SystemColors.WindowText;
            style55.SelectionBackColor = SystemColors.Highlight;
            style55.SelectionForeColor = SystemColors.HighlightText;
            style55.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord2.ColumnHeadersDefaultCellStyle = style55;
            this.dtvAnalyticsWord2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn9, this.dataGridViewTextBoxColumn10, this.dataGridViewTextBoxColumn11 };
            this.dtvAnalyticsWord2.Columns.AddRange(dataGridViewColumns);
            style56.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style56.BackColor = SystemColors.Window;
            style56.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style56.ForeColor = Color.FromArgb(0, 0, 0x40);
            style56.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style56.SelectionForeColor = Color.White;
            style56.WrapMode = DataGridViewTriState.False;
            this.dtvAnalyticsWord2.DefaultCellStyle = style56;
            this.dtvAnalyticsWord2.Location = new Point(0x105, 0x604);
            this.dtvAnalyticsWord2.MultiSelect = false;
            this.dtvAnalyticsWord2.Name = "dtvAnalyticsWord2";
            this.dtvAnalyticsWord2.ReadOnly = true;
            style57.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style57.BackColor = SystemColors.Control;
            style57.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style57.ForeColor = SystemColors.WindowText;
            style57.SelectionBackColor = SystemColors.HighlightText;
            style57.SelectionForeColor = SystemColors.HighlightText;
            style57.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord2.RowHeadersDefaultCellStyle = style57;
            this.dtvAnalyticsWord2.RowHeadersWidth = 30;
            this.dtvAnalyticsWord2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalyticsWord2.Size = new Size(0xff, 0x207);
            this.dtvAnalyticsWord2.TabIndex = 20;
            this.dtvAnalyticsWord2.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnalyticsWord2_RowPostPaint);
            this.dataGridViewTextBoxColumn9.FillWeight = 139.7233f;
            this.dataGridViewTextBoxColumn9.HeaderText = "Từ kho\x00e1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.FillWeight = 99.36298f;
            this.dataGridViewTextBoxColumn10.HeaderText = "Mật độ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.FillWeight = 60.9137f;
            this.dataGridViewTextBoxColumn11.HeaderText = "Lặp";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dtvAnalyticsWord1.AllowUserToAddRows = false;
            this.dtvAnalyticsWord1.AllowUserToDeleteRows = false;
            this.dtvAnalyticsWord1.AllowUserToOrderColumns = true;
            style58.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalyticsWord1.AlternatingRowsDefaultCellStyle = style58;
            this.dtvAnalyticsWord1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalyticsWord1.BackgroundColor = Color.White;
            this.dtvAnalyticsWord1.BorderStyle = BorderStyle.None;
            style59.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style59.BackColor = SystemColors.Control;
            style59.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style59.ForeColor = SystemColors.WindowText;
            style59.SelectionBackColor = SystemColors.Highlight;
            style59.SelectionForeColor = SystemColors.HighlightText;
            style59.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord1.ColumnHeadersDefaultCellStyle = style59;
            this.dtvAnalyticsWord1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.KeyKey1, this.KeyDensity1, this.KeyLoop1 };
            this.dtvAnalyticsWord1.Columns.AddRange(dataGridViewColumns);
            style60.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style60.BackColor = SystemColors.Window;
            style60.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style60.ForeColor = Color.FromArgb(0, 0, 0x40);
            style60.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style60.SelectionForeColor = Color.White;
            style60.WrapMode = DataGridViewTriState.False;
            this.dtvAnalyticsWord1.DefaultCellStyle = style60;
            this.dtvAnalyticsWord1.Location = new Point(0, 0x604);
            this.dtvAnalyticsWord1.MultiSelect = false;
            this.dtvAnalyticsWord1.Name = "dtvAnalyticsWord1";
            this.dtvAnalyticsWord1.ReadOnly = true;
            style61.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style61.BackColor = SystemColors.Control;
            style61.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style61.ForeColor = SystemColors.WindowText;
            style61.SelectionBackColor = SystemColors.HighlightText;
            style61.SelectionForeColor = SystemColors.HighlightText;
            style61.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsWord1.RowHeadersDefaultCellStyle = style61;
            this.dtvAnalyticsWord1.RowHeadersWidth = 30;
            this.dtvAnalyticsWord1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalyticsWord1.Size = new Size(0xff, 0x207);
            this.dtvAnalyticsWord1.TabIndex = 0x13;
            this.dtvAnalyticsWord1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnalyticsWord1_RowPostPaint);
            this.KeyKey1.FillWeight = 140.4269f;
            this.KeyKey1.HeaderText = "Từ kho\x00e1";
            this.KeyKey1.Name = "KeyKey1";
            this.KeyKey1.ReadOnly = true;
            this.KeyDensity1.FillWeight = 98.98478f;
            this.KeyDensity1.HeaderText = "Mật độ";
            this.KeyDensity1.Name = "KeyDensity1";
            this.KeyDensity1.ReadOnly = true;
            this.KeyLoop1.FillWeight = 60.58836f;
            this.KeyLoop1.HeaderText = "Lặp";
            this.KeyLoop1.Name = "KeyLoop1";
            this.KeyLoop1.ReadOnly = true;
            this.dtvAnalyticsImage.AllowUserToAddRows = false;
            this.dtvAnalyticsImage.AllowUserToDeleteRows = false;
            this.dtvAnalyticsImage.AllowUserToOrderColumns = true;
            style62.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalyticsImage.AlternatingRowsDefaultCellStyle = style62;
            this.dtvAnalyticsImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalyticsImage.BackgroundColor = Color.White;
            this.dtvAnalyticsImage.BorderStyle = BorderStyle.None;
            style63.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style63.BackColor = SystemColors.Control;
            style63.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style63.ForeColor = SystemColors.WindowText;
            style63.SelectionBackColor = SystemColors.Highlight;
            style63.SelectionForeColor = SystemColors.HighlightText;
            style63.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsImage.ColumnHeadersDefaultCellStyle = style63;
            this.dtvAnalyticsImage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn7, this.ImageAlt, this.dataGridViewTextBoxColumn28, this.dataGridViewLinkColumn1 };
            this.dtvAnalyticsImage.Columns.AddRange(dataGridViewColumns);
            style64.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style64.BackColor = SystemColors.Window;
            style64.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style64.ForeColor = Color.FromArgb(0, 0, 0x40);
            style64.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style64.SelectionForeColor = Color.White;
            style64.WrapMode = DataGridViewTriState.False;
            this.dtvAnalyticsImage.DefaultCellStyle = style64;
            this.dtvAnalyticsImage.Location = new Point(0x213, 0x40d);
            this.dtvAnalyticsImage.MultiSelect = false;
            this.dtvAnalyticsImage.Name = "dtvAnalyticsImage";
            this.dtvAnalyticsImage.ReadOnly = true;
            style65.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style65.BackColor = SystemColors.Control;
            style65.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style65.ForeColor = SystemColors.WindowText;
            style65.SelectionBackColor = SystemColors.HighlightText;
            style65.SelectionForeColor = SystemColors.HighlightText;
            style65.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsImage.RowHeadersDefaultCellStyle = style65;
            this.dtvAnalyticsImage.RowHeadersWidth = 40;
            this.dtvAnalyticsImage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalyticsImage.Size = new Size(0x205, 0x1d3);
            this.dtvAnalyticsImage.TabIndex = 0x12;
            this.dtvAnalyticsImage.CellContentClick += new DataGridViewCellEventHandler(this.dtvAnalyticsImage_CellContentClick);
            this.dtvAnalyticsImage.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnalyticsImage_RowPostPaint);
            style66.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = style66;
            this.dataGridViewTextBoxColumn7.FillWeight = 37.51707f;
            this.dataGridViewTextBoxColumn7.HeaderText = "TOP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.ImageAlt.FillWeight = 166.013f;
            this.ImageAlt.HeaderText = "Alt";
            this.ImageAlt.Name = "ImageAlt";
            this.ImageAlt.ReadOnly = true;
            style67.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn28.DefaultCellStyle = style67;
            this.dataGridViewTextBoxColumn28.FillWeight = 30.45685f;
            this.dataGridViewTextBoxColumn28.HeaderText = "Lặp";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewLinkColumn1.FillWeight = 166.013f;
            this.dataGridViewLinkColumn1.HeaderText = "Link";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.lbAnalyticsImage.AutoSize = true;
            this.lbAnalyticsImage.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbAnalyticsImage.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.lbAnalyticsImage.Location = new Point(0x213, 0x3f5);
            this.lbAnalyticsImage.Name = "lbAnalyticsImage";
            this.lbAnalyticsImage.Size = new Size(0x53, 0x10);
            this.lbAnalyticsImage.TabIndex = 20;
            this.lbAnalyticsImage.Text = "Thẻ h\x00ecnh ảnh";
            this.dtvAnalyticsHeading.AllowUserToAddRows = false;
            this.dtvAnalyticsHeading.AllowUserToDeleteRows = false;
            this.dtvAnalyticsHeading.AllowUserToOrderColumns = true;
            style68.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalyticsHeading.AlternatingRowsDefaultCellStyle = style68;
            this.dtvAnalyticsHeading.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalyticsHeading.BackgroundColor = Color.White;
            this.dtvAnalyticsHeading.BorderStyle = BorderStyle.None;
            style69.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style69.BackColor = SystemColors.Control;
            style69.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style69.ForeColor = SystemColors.WindowText;
            style69.SelectionBackColor = SystemColors.Highlight;
            style69.SelectionForeColor = SystemColors.HighlightText;
            style69.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsHeading.ColumnHeadersDefaultCellStyle = style69;
            this.dtvAnalyticsHeading.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn8, this.Column3, this.Column2 };
            this.dtvAnalyticsHeading.Columns.AddRange(dataGridViewColumns);
            style70.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style70.BackColor = SystemColors.Window;
            style70.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style70.ForeColor = Color.FromArgb(0, 0, 0x40);
            style70.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style70.SelectionForeColor = Color.White;
            style70.WrapMode = DataGridViewTriState.False;
            this.dtvAnalyticsHeading.DefaultCellStyle = style70;
            this.dtvAnalyticsHeading.Location = new Point(0, 0x40d);
            this.dtvAnalyticsHeading.MultiSelect = false;
            this.dtvAnalyticsHeading.Name = "dtvAnalyticsHeading";
            this.dtvAnalyticsHeading.ReadOnly = true;
            style71.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style71.BackColor = SystemColors.Control;
            style71.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style71.ForeColor = SystemColors.WindowText;
            style71.SelectionBackColor = SystemColors.HighlightText;
            style71.SelectionForeColor = SystemColors.HighlightText;
            style71.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsHeading.RowHeadersDefaultCellStyle = style71;
            this.dtvAnalyticsHeading.RowHeadersWidth = 40;
            this.dtvAnalyticsHeading.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalyticsHeading.Size = new Size(0x20d, 0x1d3);
            this.dtvAnalyticsHeading.TabIndex = 0x11;
            this.dtvAnalyticsHeading.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnalyticsHeading_RowPostPaint);
            style72.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn_0.DefaultCellStyle = style72;
            this.dataGridViewTextBoxColumn_0.FillWeight = 37.51707f;
            this.dataGridViewTextBoxColumn_0.HeaderText = "TOP";
            this.dataGridViewTextBoxColumn_0.Name = "Loại";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.FillWeight = 291.6271f;
            this.dataGridViewTextBoxColumn8.HeaderText = "Từ kho\x00e1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            style73.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = style73;
            this.Column3.FillWeight = 30.45685f;
            this.Column3.HeaderText = "Lặp";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            style74.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = style74;
            this.Column2.FillWeight = 40.39903f;
            this.Column2.HeaderText = "Loại";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.label47.AutoSize = true;
            this.label47.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label47.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label47.Location = new Point(780, 0x5eb);
            this.label47.Name = "label47";
            this.label47.Size = new Size(0x2f, 0x10);
            this.label47.TabIndex = 0x12;
            this.label47.Text = "4 k\x00fd tự";
            this.label46.AutoSize = true;
            this.label46.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label46.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label46.Location = new Point(0x207, 0x5eb);
            this.label46.Name = "label46";
            this.label46.Size = new Size(0x2f, 0x10);
            this.label46.TabIndex = 0x12;
            this.label46.Text = "3 k\x00fd tự";
            this.label45.AutoSize = true;
            this.label45.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label45.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label45.Location = new Point(0x102, 0x5eb);
            this.label45.Name = "label45";
            this.label45.Size = new Size(0x2f, 0x10);
            this.label45.TabIndex = 0x12;
            this.label45.Text = "2 k\x00fd tự";
            this.label44.AutoSize = true;
            this.label44.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label44.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label44.Location = new Point(3, 0x5eb);
            this.label44.Name = "label44";
            this.label44.Size = new Size(0x2f, 0x10);
            this.label44.TabIndex = 0x12;
            this.label44.Text = "1 k\x00fd tự";
            this.lbAnalyticsHeading.AutoSize = true;
            this.lbAnalyticsHeading.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbAnalyticsHeading.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.lbAnalyticsHeading.Location = new Point(-3, 0x3f5);
            this.lbAnalyticsHeading.Name = "lbAnalyticsHeading";
            this.lbAnalyticsHeading.Size = new Size(80, 0x10);
            this.lbAnalyticsHeading.TabIndex = 0x12;
            this.lbAnalyticsHeading.Text = "Thẻ Heading";
            this.dtvAnalyticsLink.AllowUserToAddRows = false;
            this.dtvAnalyticsLink.AllowUserToDeleteRows = false;
            this.dtvAnalyticsLink.AllowUserToOrderColumns = true;
            style75.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnalyticsLink.AlternatingRowsDefaultCellStyle = style75;
            this.dtvAnalyticsLink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnalyticsLink.BackgroundColor = Color.White;
            this.dtvAnalyticsLink.BorderStyle = BorderStyle.None;
            style76.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style76.BackColor = SystemColors.Control;
            style76.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style76.ForeColor = SystemColors.WindowText;
            style76.SelectionBackColor = SystemColors.Highlight;
            style76.SelectionForeColor = SystemColors.HighlightText;
            style76.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsLink.ColumnHeadersDefaultCellStyle = style76;
            this.dtvAnalyticsLink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn26, this.AnalyticsName, this.dataGridViewTextBoxColumn27, this.AnalyticsUrl, this.AnalyticsTitle, this.AnalyticsRel, this.Analytics404, this.AnalyticsType, this.AnalyticsImg };
            this.dtvAnalyticsLink.Columns.AddRange(dataGridViewColumns);
            style77.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style77.BackColor = SystemColors.Window;
            style77.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style77.ForeColor = Color.FromArgb(0, 0, 0x40);
            style77.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style77.SelectionForeColor = Color.White;
            style77.WrapMode = DataGridViewTriState.False;
            this.dtvAnalyticsLink.DefaultCellStyle = style77;
            this.dtvAnalyticsLink.Location = new Point(6, 0x1d9);
            this.dtvAnalyticsLink.MultiSelect = false;
            this.dtvAnalyticsLink.Name = "dtvAnalyticsLink";
            this.dtvAnalyticsLink.ReadOnly = true;
            style78.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style78.BackColor = SystemColors.Control;
            style78.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style78.ForeColor = SystemColors.WindowText;
            style78.SelectionBackColor = SystemColors.HighlightText;
            style78.SelectionForeColor = SystemColors.HighlightText;
            style78.WrapMode = DataGridViewTriState.True;
            this.dtvAnalyticsLink.RowHeadersDefaultCellStyle = style78;
            this.dtvAnalyticsLink.RowHeadersWidth = 40;
            this.dtvAnalyticsLink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnalyticsLink.Size = new Size(0x412, 0x219);
            this.dtvAnalyticsLink.TabIndex = 0x10;
            this.dtvAnalyticsLink.CellContentClick += new DataGridViewCellEventHandler(this.dtvAnalyticsLink_CellContentClick);
            this.dtvAnalyticsLink.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnalyticsLink_RowPostPaint);
            style79.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn26.DefaultCellStyle = style79;
            this.dataGridViewTextBoxColumn26.FillWeight = 29.47276f;
            this.dataGridViewTextBoxColumn26.HeaderText = "TOP";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.AnalyticsName.FillWeight = 205.4911f;
            this.AnalyticsName.HeaderText = "Name";
            this.AnalyticsName.Name = "AnalyticsName";
            this.AnalyticsName.ReadOnly = true;
            style80.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn27.DefaultCellStyle = style80;
            this.dataGridViewTextBoxColumn27.FillWeight = 45.68528f;
            this.dataGridViewTextBoxColumn27.HeaderText = "Lặp";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.AnalyticsUrl.FillWeight = 193.218f;
            this.AnalyticsUrl.HeaderText = "Url";
            this.AnalyticsUrl.Name = "AnalyticsUrl";
            this.AnalyticsUrl.ReadOnly = true;
            this.AnalyticsUrl.Resizable = DataGridViewTriState.True;
            this.AnalyticsUrl.SortMode = DataGridViewColumnSortMode.Automatic;
            this.AnalyticsTitle.FillWeight = 172.9188f;
            this.AnalyticsTitle.HeaderText = "Title";
            this.AnalyticsTitle.Name = "AnalyticsTitle";
            this.AnalyticsTitle.ReadOnly = true;
            this.AnalyticsRel.FillWeight = 63.63699f;
            this.AnalyticsRel.HeaderText = "Rel";
            this.AnalyticsRel.Name = "AnalyticsRel";
            this.AnalyticsRel.ReadOnly = true;
            this.Analytics404.FillWeight = 41.93267f;
            this.Analytics404.HeaderText = "Error";
            this.Analytics404.Name = "Analytics404";
            this.Analytics404.ReadOnly = true;
            this.AnalyticsType.FillWeight = 86.73245f;
            this.AnalyticsType.HeaderText = "Li\x00ean kết";
            this.AnalyticsType.Name = "AnalyticsType";
            this.AnalyticsType.ReadOnly = true;
            this.AnalyticsImg.FillWeight = 60.9118f;
            this.AnalyticsImg.HeaderText = "Loại link";
            this.AnalyticsImg.Name = "AnalyticsImg";
            this.AnalyticsImg.ReadOnly = true;
            this.lbAnalyticsAnchor.AutoSize = true;
            this.lbAnalyticsAnchor.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbAnalyticsAnchor.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.lbAnalyticsAnchor.Location = new Point(90, 0x1bd);
            this.lbAnalyticsAnchor.Name = "lbAnalyticsAnchor";
            this.lbAnalyticsAnchor.Size = new Size(0x34, 0x10);
            this.lbAnalyticsAnchor.TabIndex = 7;
            this.lbAnalyticsAnchor.Text = "Li\x00ean kết";
            this.label21.AutoSize = true;
            this.label21.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label21.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label21.Location = new Point(3, 4);
            this.label21.Name = "label21";
            this.label21.Size = new Size(0x6c, 0x10);
            this.label21.TabIndex = 7;
            this.label21.Text = "Ph\x00e2n t\x00edch Onpage";
            this.label23.AutoSize = true;
            this.label23.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label23.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label23.Location = new Point(0x286, 0x15);
            this.label23.Name = "label23";
            this.label23.Size = new Size(0x37, 0x10);
            this.label23.TabIndex = 7;
            this.label23.Text = "Từ kh\x00f3a";
            this.txtKeywordAnalytics.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtKeywordAnalytics.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtKeywordAnalytics.Location = new Point(0x2c3, 0x11);
            this.txtKeywordAnalytics.Name = "txtKeywordAnalytics";
            this.txtKeywordAnalytics.Size = new Size(0x83, 0x17);
            this.txtKeywordAnalytics.TabIndex = 5;
            this.txtKeywordAnalytics.KeyUp += new KeyEventHandler(this.txtWebsiteUrl_KeyUp);
            this.txtWebsiteUrl2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtWebsiteUrl2.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtWebsiteUrl2.Location = new Point(0x147, 0x11);
            this.txtWebsiteUrl2.Name = "txtWebsiteUrl2";
            this.txtWebsiteUrl2.Size = new Size(0xf9, 0x17);
            this.txtWebsiteUrl2.TabIndex = 3;
            this.txtWebsiteUrl2.KeyUp += new KeyEventHandler(this.txtWebsiteUrl_KeyUp);
            this.txtWebsiteUrl.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtWebsiteUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtWebsiteUrl.Location = new Point(9, 0x11);
            this.txtWebsiteUrl.Name = "txtWebsiteUrl";
            this.txtWebsiteUrl.Size = new Size(0xf9, 0x17);
            this.txtWebsiteUrl.TabIndex = 1;
            this.txtWebsiteUrl.KeyUp += new KeyEventHandler(this.txtWebsiteUrl_KeyUp);
            this.btnOptimize.DialogResult = DialogResult.Cancel;
            this.btnOptimize.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnOptimize.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnOptimize.Location = new Point(0x3ec, 13);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new Size(0x44, 0x1f);
            this.btnOptimize.TabIndex = 8;
            this.btnOptimize.Text = "Tối Ưu";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new EventHandler(this.btnOptimize_Click);
            this.btnAnalyticsCompare.DialogResult = DialogResult.Cancel;
            this.btnAnalyticsCompare.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAnalyticsCompare.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnAnalyticsCompare.Location = new Point(0x39f, 13);
            this.btnAnalyticsCompare.Name = "btnAnalyticsCompare";
            this.btnAnalyticsCompare.Size = new Size(0x47, 0x1f);
            this.btnAnalyticsCompare.TabIndex = 7;
            this.btnAnalyticsCompare.Text = "So s\x00e1nh";
            this.btnAnalyticsCompare.UseVisualStyleBackColor = true;
            this.btnAnalyticsCompare.Click += new EventHandler(this.btnAnalyticsCompare_Click);
            this.btnAnalytics.DialogResult = DialogResult.Cancel;
            this.btnAnalytics.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAnalytics.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnAnalytics.Location = new Point(0x34c, 13);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new Size(0x4d, 0x1f);
            this.btnAnalytics.TabIndex = 6;
            this.btnAnalytics.Text = "Ph\x00e2n T\x00edch";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new EventHandler(this.btnAnalytics_Click);
            this.tbCheckBacklink.Controls.Add(this.groupBox26);
            this.tbCheckBacklink.Location = new Point(4, 0x3d);
            this.tbCheckBacklink.Name = "tbCheckBacklink";
            this.tbCheckBacklink.Size = new Size(0x444, 670);
            this.tbCheckBacklink.TabIndex = 14;
            this.tbCheckBacklink.Text = "Check Backlink";
            this.tbCheckBacklink.UseVisualStyleBackColor = true;
            this.groupBox26.Controls.Add(this.btnCheckBacklinkSave);
            this.groupBox26.Controls.Add(this.btnCheckBacklinkFilter);
            this.groupBox26.Controls.Add(this.label16);
            this.groupBox26.Controls.Add(this.label64);
            this.groupBox26.Controls.Add(this.dtvCheckBacklink);
            this.groupBox26.Controls.Add(this.btnCheckBLOK);
            this.groupBox26.Controls.Add(this.txtCheckBacklinkExt);
            this.groupBox26.Controls.Add(this.txtCheckBLUrl);
            this.groupBox26.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox26.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox26.Location = new Point(8, 7);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new Size(0x434, 0x296);
            this.groupBox26.TabIndex = 0x17;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Kiểm tra Backlink";
            this.btnCheckBacklinkSave.BackColor = Color.Transparent;
            this.btnCheckBacklinkSave.Cursor = Cursors.Hand;
            this.btnCheckBacklinkSave.Image = Resources.smethod_7();
            this.btnCheckBacklinkSave.Location = new Point(0x10, 0x33);
            this.btnCheckBacklinkSave.Name = "btnCheckBacklinkSave";
            this.btnCheckBacklinkSave.Size = new Size(0x16, 0x17);
            this.btnCheckBacklinkSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnCheckBacklinkSave.TabIndex = 0x24;
            this.btnCheckBacklinkSave.TabStop = false;
            this.btnCheckBacklinkSave.Click += new EventHandler(this.btnCheckBacklinkSave_Click);
            this.btnCheckBacklinkFilter.DialogResult = DialogResult.Cancel;
            this.btnCheckBacklinkFilter.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckBacklinkFilter.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckBacklinkFilter.Location = new Point(0x3f6, 0x10);
            this.btnCheckBacklinkFilter.Name = "btnCheckBacklinkFilter";
            this.btnCheckBacklinkFilter.Size = new Size(0x38, 0x1a);
            this.btnCheckBacklinkFilter.TabIndex = 4;
            this.btnCheckBacklinkFilter.Text = "Lọc";
            this.btnCheckBacklinkFilter.UseVisualStyleBackColor = true;
            this.btnCheckBacklinkFilter.Click += new EventHandler(this.btnCheckBacklinkFilter_Click);
            this.label16.AutoSize = true;
            this.label16.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label16.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label16.Location = new Point(0x380, 0x17);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x30, 0x10);
            this.label16.TabIndex = 10;
            this.label16.Text = "Lọc Ext";
            this.label64.AutoSize = true;
            this.label64.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label64.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label64.Location = new Point(6, 0x17);
            this.label64.Name = "label64";
            this.label64.Size = new Size(0x36, 0x10);
            this.label64.TabIndex = 10;
            this.label64.Text = "Website";
            this.dtvCheckBacklink.AllowUserToAddRows = false;
            this.dtvCheckBacklink.AllowUserToDeleteRows = false;
            this.dtvCheckBacklink.AllowUserToOrderColumns = true;
            style81.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvCheckBacklink.AlternatingRowsDefaultCellStyle = style81;
            this.dtvCheckBacklink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvCheckBacklink.BackgroundColor = Color.White;
            this.dtvCheckBacklink.BorderStyle = BorderStyle.None;
            style82.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style82.BackColor = SystemColors.Control;
            style82.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style82.ForeColor = SystemColors.WindowText;
            style82.SelectionBackColor = SystemColors.Highlight;
            style82.SelectionForeColor = SystemColors.HighlightText;
            style82.WrapMode = DataGridViewTriState.True;
            this.dtvCheckBacklink.ColumnHeadersDefaultCellStyle = style82;
            this.dtvCheckBacklink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn31, this.Column9, this.Column11, this.Column7 };
            this.dtvCheckBacklink.Columns.AddRange(dataGridViewColumns);
            style83.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style83.BackColor = SystemColors.Window;
            style83.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style83.ForeColor = Color.FromArgb(0, 0, 0x40);
            style83.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style83.SelectionForeColor = Color.White;
            style83.WrapMode = DataGridViewTriState.False;
            this.dtvCheckBacklink.DefaultCellStyle = style83;
            this.dtvCheckBacklink.Location = new Point(6, 0x33);
            this.dtvCheckBacklink.MultiSelect = false;
            this.dtvCheckBacklink.Name = "dtvCheckBacklink";
            this.dtvCheckBacklink.ReadOnly = true;
            style84.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style84.BackColor = SystemColors.Control;
            style84.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style84.ForeColor = SystemColors.WindowText;
            style84.SelectionBackColor = SystemColors.HighlightText;
            style84.SelectionForeColor = SystemColors.HighlightText;
            style84.WrapMode = DataGridViewTriState.True;
            this.dtvCheckBacklink.RowHeadersDefaultCellStyle = style84;
            this.dtvCheckBacklink.RowHeadersWidth = 40;
            this.dtvCheckBacklink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvCheckBacklink.Size = new Size(0x428, 0x25d);
            this.dtvCheckBacklink.TabIndex = 5;
            this.dtvCheckBacklink.CellContentClick += new DataGridViewCellEventHandler(this.dtvCheckBacklink_CellContentClick);
            this.dtvCheckBacklink.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvCheckBacklink_RowPostPaint);
            this.dataGridViewTextBoxColumn31.FillWeight = 168.4968f;
            this.dataGridViewTextBoxColumn31.HeaderText = "Website";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            style85.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle = style85;
            this.Column9.FillWeight = 31.61222f;
            this.Column9.HeaderText = "PR";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column11.FillWeight = 193.2477f;
            this.Column11.HeaderText = "Url Link";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = DataGridViewTriState.True;
            this.Column11.SortMode = DataGridViewColumnSortMode.Automatic;
            style86.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = style86;
            this.Column7.FillWeight = 161.6589f;
            this.Column7.HeaderText = "Từ kho\x00e1";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.btnCheckBLOK.DialogResult = DialogResult.Cancel;
            this.btnCheckBLOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCheckBLOK.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnCheckBLOK.Location = new Point(0x336, 0x11);
            this.btnCheckBLOK.Name = "btnCheckBLOK";
            this.btnCheckBLOK.Size = new Size(0x44, 0x1b);
            this.btnCheckBLOK.TabIndex = 2;
            this.btnCheckBLOK.Text = "Kiểm Tra";
            this.btnCheckBLOK.UseVisualStyleBackColor = true;
            this.btnCheckBLOK.Click += new EventHandler(this.btnCheckBLOK_Click);
            this.txtCheckBacklinkExt.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCheckBacklinkExt.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtCheckBacklinkExt.Location = new Point(950, 0x12);
            this.txtCheckBacklinkExt.Name = "txtCheckBacklinkExt";
            this.txtCheckBacklinkExt.Size = new Size(0x3a, 0x17);
            this.txtCheckBacklinkExt.TabIndex = 3;
            this.txtCheckBacklinkExt.Text = "edu.vn";
            this.txtCheckBacklinkExt.TextAlign = HorizontalAlignment.Center;
            this.txtCheckBacklinkExt.KeyUp += new KeyEventHandler(this.txtCheckBLUrl_KeyUp);
            this.txtCheckBLUrl.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCheckBLUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtCheckBLUrl.Location = new Point(0x42, 0x13);
            this.txtCheckBLUrl.Name = "txtCheckBLUrl";
            this.txtCheckBLUrl.Size = new Size(750, 0x17);
            this.txtCheckBLUrl.TabIndex = 1;
            this.txtCheckBLUrl.KeyUp += new KeyEventHandler(this.txtCheckBLUrl_KeyUp);
            this.tbSearchBL.Controls.Add(this.groupBox18);
            this.tbSearchBL.Location = new Point(4, 0x3d);
            this.tbSearchBL.Name = "tbSearchBL";
            this.tbSearchBL.Size = new Size(0x444, 670);
            this.tbSearchBL.TabIndex = 20;
            this.tbSearchBL.Text = "T\x00ecm kiếm Backlink";
            this.tbSearchBL.UseVisualStyleBackColor = true;
            this.tbSearchBL.Enter += new EventHandler(this.tbSearchBL_Enter);
            this.groupBox18.Controls.Add(this.btnSearchBacklinkSave);
            this.groupBox18.Controls.Add(this.label77);
            this.groupBox18.Controls.Add(this.btnSearchExport);
            this.groupBox18.Controls.Add(this.label59);
            this.groupBox18.Controls.Add(this.label58);
            this.groupBox18.Controls.Add(this.txtSearchBLKey);
            this.groupBox18.Controls.Add(this.txtSearchBLExt);
            this.groupBox18.Controls.Add(this.txtSearchBLGExt);
            this.groupBox18.Controls.Add(this.cbSearchBLFilter);
            this.groupBox18.Controls.Add(this.label60);
            this.groupBox18.Controls.Add(this.btnSearchBacklink);
            this.groupBox18.Controls.Add(this.label55);
            this.groupBox18.Controls.Add(this.label57);
            this.groupBox18.Controls.Add(this.txtSearchBLLang);
            this.groupBox18.Controls.Add(this.dtvSearchBacklink);
            this.groupBox18.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox18.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox18.Location = new Point(8, 3);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new Size(0x434, 0x293);
            this.groupBox18.TabIndex = 0x10;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "T\x00ecm kiếm Backlink";
            this.btnSearchBacklinkSave.BackColor = Color.Transparent;
            this.btnSearchBacklinkSave.Cursor = Cursors.Hand;
            this.btnSearchBacklinkSave.Image = Resources.smethod_7();
            this.btnSearchBacklinkSave.Location = new Point(15, 0x34);
            this.btnSearchBacklinkSave.Name = "btnSearchBacklinkSave";
            this.btnSearchBacklinkSave.Size = new Size(0x16, 0x17);
            this.btnSearchBacklinkSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnSearchBacklinkSave.TabIndex = 0x23;
            this.btnSearchBacklinkSave.TabStop = false;
            this.btnSearchBacklinkSave.Click += new EventHandler(this.btnSearchBacklinkSave_Click);
            this.label77.AutoSize = true;
            this.label77.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label77.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label77.Location = new Point(0x343, 0x18);
            this.label77.Name = "label77";
            this.label77.Size = new Size(0x19, 0x10);
            this.label77.TabIndex = 0x22;
            this.label77.Text = "Ext";
            this.btnSearchExport.DialogResult = DialogResult.Cancel;
            this.btnSearchExport.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSearchExport.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSearchExport.Location = new Point(0x3ed, 15);
            this.btnSearchExport.Name = "btnSearchExport";
            this.btnSearchExport.Size = new Size(0x41, 0x1f);
            this.btnSearchExport.TabIndex = 7;
            this.btnSearchExport.Text = "Ghi File";
            this.btnSearchExport.UseVisualStyleBackColor = true;
            this.btnSearchExport.Click += new EventHandler(this.btnSearchExport_Click);
            this.label59.AutoSize = true;
            this.label59.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label59.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label59.Location = new Point(0x217, 0x17);
            this.label59.Name = "label59";
            this.label59.Size = new Size(0x1b, 0x10);
            this.label59.TabIndex = 0x12;
            this.label59.Text = "Lọc";
            this.label58.AutoSize = true;
            this.label58.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label58.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label58.Location = new Point(10, 0x18);
            this.label58.Name = "label58";
            this.label58.Size = new Size(0x37, 0x10);
            this.label58.TabIndex = 0x12;
            this.label58.Text = "Từ kh\x00f3a";
            this.txtSearchBLKey.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSearchBLKey.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtSearchBLKey.Location = new Point(0x47, 0x15);
            this.txtSearchBLKey.Name = "txtSearchBLKey";
            this.txtSearchBLKey.Size = new Size(0xf5, 0x17);
            this.txtSearchBLKey.TabIndex = 1;
            this.txtSearchBLKey.KeyUp += new KeyEventHandler(this.txtSearchBLKey_KeyUp);
            this.txtSearchBLExt.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSearchBLExt.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtSearchBLExt.Location = new Point(0x364, 20);
            this.txtSearchBLExt.Name = "txtSearchBLExt";
            this.txtSearchBLExt.Size = new Size(0x35, 0x17);
            this.txtSearchBLExt.TabIndex = 5;
            this.txtSearchBLExt.TextAlign = HorizontalAlignment.Center;
            this.txtSearchBLExt.KeyUp += new KeyEventHandler(this.txtSearchBLExt_KeyUp);
            this.txtSearchBLGExt.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSearchBLGExt.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtSearchBLGExt.Location = new Point(0x177, 0x15);
            this.txtSearchBLGExt.Name = "txtSearchBLGExt";
            this.txtSearchBLGExt.Size = new Size(0x35, 0x17);
            this.txtSearchBLGExt.TabIndex = 2;
            this.txtSearchBLGExt.Text = "com.vn";
            this.txtSearchBLGExt.TextAlign = HorizontalAlignment.Center;
            this.txtSearchBLGExt.KeyUp += new KeyEventHandler(this.txtSearchBLGExt_KeyUp);
            this.cbSearchBLFilter.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbSearchBLFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSearchBLFilter.FlatStyle = FlatStyle.Popup;
            this.cbSearchBLFilter.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbSearchBLFilter.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbSearchBLFilter.FormattingEnabled = true;
            this.cbSearchBLFilter.Location = new Point(0x238, 0x13);
            this.cbSearchBLFilter.Name = "cbSearchBLFilter";
            this.cbSearchBLFilter.Size = new Size(0x105, 0x18);
            this.cbSearchBLFilter.TabIndex = 4;
            this.label60.AutoSize = true;
            this.label60.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label60.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label60.Location = new Point(0x2b4, 0x17);
            this.label60.Name = "label60";
            this.label60.Size = new Size(0x19, 0x10);
            this.label60.TabIndex = 11;
            this.label60.Text = "Ext";
            this.btnSearchBacklink.DialogResult = DialogResult.Cancel;
            this.btnSearchBacklink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSearchBacklink.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSearchBacklink.Location = new Point(0x39f, 15);
            this.btnSearchBacklink.Name = "btnSearchBacklink";
            this.btnSearchBacklink.Size = new Size(0x48, 0x1f);
            this.btnSearchBacklink.TabIndex = 6;
            this.btnSearchBacklink.Text = "T\x00ecm Kiếm";
            this.btnSearchBacklink.UseVisualStyleBackColor = true;
            this.btnSearchBacklink.Click += new EventHandler(this.btnSearchBacklink_Click);
            this.label55.AutoSize = true;
            this.label55.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label55.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label55.Location = new Point(0x142, 0x18);
            this.label55.Name = "label55";
            this.label55.Size = new Size(0x2f, 0x10);
            this.label55.TabIndex = 11;
            this.label55.Text = "Google";
            this.label57.AutoSize = true;
            this.label57.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label57.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label57.Location = new Point(0x1b1, 0x18);
            this.label57.Name = "label57";
            this.label57.Size = new Size(0x3f, 0x10);
            this.label57.TabIndex = 12;
            this.label57.Text = "Ng\x00f4n ngữ";
            this.txtSearchBLLang.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSearchBLLang.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtSearchBLLang.Location = new Point(0x1f6, 20);
            this.txtSearchBLLang.Name = "txtSearchBLLang";
            this.txtSearchBLLang.Size = new Size(0x1b, 0x17);
            this.txtSearchBLLang.TabIndex = 3;
            this.txtSearchBLLang.Text = "vi";
            this.txtSearchBLLang.TextAlign = HorizontalAlignment.Center;
            this.txtSearchBLLang.KeyUp += new KeyEventHandler(this.txtSearchBLLang_KeyUp);
            this.dtvSearchBacklink.AllowUserToAddRows = false;
            this.dtvSearchBacklink.AllowUserToDeleteRows = false;
            this.dtvSearchBacklink.AllowUserToOrderColumns = true;
            style87.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvSearchBacklink.AlternatingRowsDefaultCellStyle = style87;
            this.dtvSearchBacklink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvSearchBacklink.BackgroundColor = Color.White;
            this.dtvSearchBacklink.BorderStyle = BorderStyle.None;
            style88.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style88.BackColor = SystemColors.Control;
            style88.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style88.ForeColor = SystemColors.WindowText;
            style88.SelectionBackColor = SystemColors.Highlight;
            style88.SelectionForeColor = SystemColors.HighlightText;
            style88.WrapMode = DataGridViewTriState.True;
            this.dtvSearchBacklink.ColumnHeadersDefaultCellStyle = style88;
            this.dtvSearchBacklink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.SearchWebsite, this.SearchExt, this.SearchPR, this.SearchLoop };
            this.dtvSearchBacklink.Columns.AddRange(dataGridViewColumns);
            style89.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style89.BackColor = SystemColors.Window;
            style89.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style89.ForeColor = Color.FromArgb(0, 0, 0x40);
            style89.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style89.SelectionForeColor = Color.White;
            style89.WrapMode = DataGridViewTriState.False;
            this.dtvSearchBacklink.DefaultCellStyle = style89;
            this.dtvSearchBacklink.Location = new Point(6, 0x34);
            this.dtvSearchBacklink.MultiSelect = false;
            this.dtvSearchBacklink.Name = "dtvSearchBacklink";
            this.dtvSearchBacklink.ReadOnly = true;
            style90.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style90.BackColor = SystemColors.Control;
            style90.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style90.ForeColor = SystemColors.WindowText;
            style90.SelectionBackColor = SystemColors.HighlightText;
            style90.SelectionForeColor = SystemColors.HighlightText;
            style90.WrapMode = DataGridViewTriState.True;
            this.dtvSearchBacklink.RowHeadersDefaultCellStyle = style90;
            this.dtvSearchBacklink.RowHeadersWidth = 40;
            this.dtvSearchBacklink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvSearchBacklink.Size = new Size(0x428, 0x259);
            this.dtvSearchBacklink.TabIndex = 8;
            this.dtvSearchBacklink.CellContentClick += new DataGridViewCellEventHandler(this.dtvSearchBacklink_CellContentClick);
            this.dtvSearchBacklink.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvSearchBacklink_RowPostPaint);
            this.SearchWebsite.FillWeight = 245.7776f;
            this.SearchWebsite.HeaderText = "Website";
            this.SearchWebsite.Name = "SearchWebsite";
            this.SearchWebsite.ReadOnly = true;
            this.SearchWebsite.Resizable = DataGridViewTriState.True;
            this.SearchWebsite.SortMode = DataGridViewColumnSortMode.Automatic;
            style91.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SearchExt.DefaultCellStyle = style91;
            this.SearchExt.FillWeight = 61.96511f;
            this.SearchExt.HeaderText = "Ext";
            this.SearchExt.Name = "SearchExt";
            this.SearchExt.ReadOnly = true;
            style92.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SearchPR.DefaultCellStyle = style92;
            this.SearchPR.FillWeight = 34.77319f;
            this.SearchPR.HeaderText = "PR";
            this.SearchPR.Name = "SearchPR";
            this.SearchPR.ReadOnly = true;
            style93.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SearchLoop.DefaultCellStyle = style93;
            this.SearchLoop.FillWeight = 38.70237f;
            this.SearchLoop.HeaderText = "Lặp";
            this.SearchLoop.Name = "SearchLoop";
            this.SearchLoop.ReadOnly = true;
            this.tbSocial.BackColor = SystemColors.Control;
            this.tbSocial.Controls.Add(this.groupBox5);
            this.tbSocial.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.tbSocial.Location = new Point(4, 0x3d);
            this.tbSocial.Name = "tbSocial";
            this.tbSocial.Size = new Size(0x444, 670);
            this.tbSocial.TabIndex = 5;
            this.tbSocial.Text = "Submit Social";
            this.tbSocial.Enter += new EventHandler(this.tbSocial_Enter);
            this.groupBox5.BackColor = SystemColors.Control;
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.txtSocialGoogleID);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtSocialUrl);
            this.groupBox5.Controls.Add(this.btnSocialAuto);
            this.groupBox5.Controls.Add(this.btnSocialClose);
            this.groupBox5.Controls.Add(this.tabSocial);
            this.groupBox5.Controls.Add(this.btnSocialSend);
            this.groupBox5.Controls.Add(this.listSocial);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox5.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox5.Location = new Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(0x439, 0x296);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi sẻ nội dụng v\x00e0o c\x00e1c trang Mạng x\x00e3 hội";
            this.label43.AutoSize = true;
            this.label43.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label43.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label43.Location = new Point(0x1a6, 0x1d);
            this.label43.Name = "label43";
            this.label43.Size = new Size(0x65, 0x10);
            this.label43.TabIndex = 0x29;
            this.label43.Text = "Google Pages ID";
            this.txtSocialGoogleID.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSocialGoogleID.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtSocialGoogleID.Location = new Point(0x211, 0x1a);
            this.txtSocialGoogleID.Name = "txtSocialGoogleID";
            this.txtSocialGoogleID.Size = new Size(0xcc, 0x17);
            this.txtSocialGoogleID.TabIndex = 40;
            this.label14.AutoSize = true;
            this.label14.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label14.Location = new Point(6, 0x9f);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x2a1, 0x10);
            this.label14.TabIndex = 0x27;
            this.label14.Text = "Ch\x00fa \x00fd: Đăng nhập v\x00e0 chọn \"Lưu nhớ mật khẩu\" để lần sau kh\x00f4ng phải đăng nhập lại v\x00e0 sử dụng được Auto Submit :)";
            this.txtSocialUrl.BorderStyle = BorderStyle.None;
            this.txtSocialUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtSocialUrl.Location = new Point(6, 0x37);
            this.txtSocialUrl.Name = "txtSocialUrl";
            this.txtSocialUrl.Size = new Size(0x317, 0x65);
            this.txtSocialUrl.TabIndex = 1;
            this.txtSocialUrl.Text = "";
            this.txtSocialUrl.LinkClicked += new LinkClickedEventHandler(this.txtSocialUrl_LinkClicked);
            this.btnSocialAuto.DialogResult = DialogResult.Cancel;
            this.btnSocialAuto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSocialAuto.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSocialAuto.Location = new Point(0x3db, 0x60);
            this.btnSocialAuto.Name = "btnSocialAuto";
            this.btnSocialAuto.Size = new Size(0x57, 60);
            this.btnSocialAuto.TabIndex = 4;
            this.btnSocialAuto.Text = "Auto Submit";
            this.btnSocialAuto.UseVisualStyleBackColor = true;
            this.btnSocialAuto.Click += new EventHandler(this.btnSocialAuto_Click);
            this.btnSocialClose.BackColor = Color.Transparent;
            this.btnSocialClose.Cursor = Cursors.Hand;
            this.btnSocialClose.Image = Resources.smethod_12();
            this.btnSocialClose.Location = new Point(0x417, 0xad);
            this.btnSocialClose.Name = "btnSocialClose";
            this.btnSocialClose.Size = new Size(0x16, 0x16);
            this.btnSocialClose.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnSocialClose.TabIndex = 0x24;
            this.btnSocialClose.TabStop = false;
            this.btnSocialClose.Click += new EventHandler(this.btnSocialClose_Click);
            this.tabSocial.Location = new Point(6, 0xb2);
            this.tabSocial.Name = "tabSocial";
            this.tabSocial.SelectedIndex = 0;
            this.tabSocial.Size = new Size(0x42d, 0x1de);
            this.tabSocial.TabIndex = 5;
            this.btnSocialSend.DialogResult = DialogResult.Cancel;
            this.btnSocialSend.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSocialSend.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSocialSend.Location = new Point(0x3db, 0x1a);
            this.btnSocialSend.Name = "btnSocialSend";
            this.btnSocialSend.Size = new Size(0x57, 0x40);
            this.btnSocialSend.TabIndex = 3;
            this.btnSocialSend.Text = "Chia sẻ";
            this.btnSocialSend.UseVisualStyleBackColor = true;
            this.btnSocialSend.Click += new EventHandler(this.btnSocialSend_Click);
            this.listSocial.FormattingEnabled = true;
            this.listSocial.ItemHeight = 14;
            this.listSocial.Location = new Point(0x323, 0x1a);
            this.listSocial.Name = "listSocial";
            this.listSocial.SelectionMode = SelectionMode.MultiSimple;
            this.listSocial.Size = new Size(0xb2, 130);
            this.listSocial.TabIndex = 2;
            this.label17.AutoSize = true;
            this.label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label17.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label17.Location = new Point(0x2e1, 0x1c);
            this.label17.Name = "label17";
            this.label17.Size = new Size(60, 0x10);
            this.label17.TabIndex = 0x12;
            this.label17.Text = "Lựa chọn";
            this.label13.AutoSize = true;
            this.label13.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label13.Location = new Point(6, 0x1c);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x71, 0x10);
            this.label13.TabIndex = 0x12;
            this.label13.Text = "Danh s\x00e1ch Url Link";
            this.tbAdword.Controls.Add(this.groupBox28);
            this.tbAdword.Controls.Add(this.groupBox29);
            this.tbAdword.Location = new Point(4, 0x3d);
            this.tbAdword.Name = "tbAdword";
            this.tbAdword.Size = new Size(0x444, 670);
            this.tbAdword.TabIndex = 15;
            this.tbAdword.Text = "Quản l\x00fd Adword";
            this.tbAdword.UseVisualStyleBackColor = true;
            this.tbAdword.Enter += new EventHandler(this.tbAdword_Enter);
            this.groupBox28.Controls.Add(this.label74);
            this.groupBox28.Controls.Add(this.label73);
            this.groupBox28.Controls.Add(this.txtAdwordWeb);
            this.groupBox28.Controls.Add(this.txtAdwordExt);
            this.groupBox28.Controls.Add(this.label71);
            this.groupBox28.Controls.Add(this.label72);
            this.groupBox28.Controls.Add(this.label68);
            this.groupBox28.Controls.Add(this.txtAdwordLang);
            this.groupBox28.Controls.Add(this.label70);
            this.groupBox28.Controls.Add(this.txtAdwordKey);
            this.groupBox28.Controls.Add(this.btnAdwordSearch);
            this.groupBox28.Controls.Add(this.btnAdwordCheck);
            this.groupBox28.Controls.Add(this.btnAdwordDelete);
            this.groupBox28.Controls.Add(this.btnAdwordEdit);
            this.groupBox28.Controls.Add(this.btnAdwordAdd);
            this.groupBox28.Controls.Add(this.dtvAdword);
            this.groupBox28.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox28.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox28.Location = new Point(0x108, 3);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new Size(0x337, 0x296);
            this.groupBox28.TabIndex = 0x1a;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Danh s\x00e1ch từ kho\x00e1";
            this.label74.AutoSize = true;
            this.label74.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label74.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label74.Location = new Point(0x25d, 0x15);
            this.label74.Name = "label74";
            this.label74.Size = new Size(0x2f, 0x10);
            this.label74.TabIndex = 0x2b;
            this.label74.Text = "Google";
            this.label73.AutoSize = true;
            this.label73.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label73.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label73.Location = new Point(310, 20);
            this.label73.Name = "label73";
            this.label73.Size = new Size(0x36, 0x10);
            this.label73.TabIndex = 0x2b;
            this.label73.Text = "Website";
            this.txtAdwordWeb.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAdwordWeb.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAdwordWeb.Location = new Point(0x173, 0x11);
            this.txtAdwordWeb.Name = "txtAdwordWeb";
            this.txtAdwordWeb.Size = new Size(0xe4, 0x17);
            this.txtAdwordWeb.TabIndex = 4;
            this.txtAdwordExt.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAdwordExt.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAdwordExt.Location = new Point(0x295, 0x12);
            this.txtAdwordExt.Name = "txtAdwordExt";
            this.txtAdwordExt.Size = new Size(0x35, 0x17);
            this.txtAdwordExt.TabIndex = 5;
            this.txtAdwordExt.Text = "com.vn";
            this.txtAdwordExt.TextAlign = HorizontalAlignment.Center;
            this.label71.AutoSize = true;
            this.label71.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label71.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label71.Location = new Point(460, 20);
            this.label71.Name = "label71";
            this.label71.Size = new Size(0x3a, 0x10);
            this.label71.TabIndex = 0x27;
            this.label71.Text = "Quốc gia";
            this.label72.AutoSize = true;
            this.label72.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label72.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label72.Location = new Point(720, 0x15);
            this.label72.Name = "label72";
            this.label72.Size = new Size(0x3f, 0x10);
            this.label72.TabIndex = 0x26;
            this.label72.Text = "Ng\x00f4n ngữ";
            this.label68.AutoSize = true;
            this.label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label68.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label68.Location = new Point(0x205, 0x35);
            this.label68.Name = "label68";
            this.label68.Size = new Size(110, 0x10);
            this.label68.TabIndex = 10;
            this.label68.Text = "Th\x00eam | Sửa |Xo\x00e1";
            this.txtAdwordLang.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAdwordLang.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAdwordLang.Location = new Point(0x315, 0x11);
            this.txtAdwordLang.Name = "txtAdwordLang";
            this.txtAdwordLang.Size = new Size(0x1b, 0x17);
            this.txtAdwordLang.TabIndex = 6;
            this.txtAdwordLang.Text = "vi";
            this.txtAdwordLang.TextAlign = HorizontalAlignment.Center;
            this.label70.AutoSize = true;
            this.label70.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label70.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label70.Location = new Point(6, 20);
            this.label70.Name = "label70";
            this.label70.Size = new Size(0x37, 0x10);
            this.label70.TabIndex = 0x25;
            this.label70.Text = "Từ kh\x00f3a";
            this.txtAdwordKey.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAdwordKey.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAdwordKey.Location = new Point(0x43, 0x11);
            this.txtAdwordKey.Name = "txtAdwordKey";
            this.txtAdwordKey.Size = new Size(0xed, 0x17);
            this.txtAdwordKey.TabIndex = 3;
            this.btnAdwordSearch.BackColor = SystemColors.Control;
            this.btnAdwordSearch.Cursor = Cursors.Hand;
            this.btnAdwordSearch.Image = Resources.smethod_18();
            this.btnAdwordSearch.Location = new Point(0x279, 0x31);
            this.btnAdwordSearch.Name = "btnAdwordSearch";
            this.btnAdwordSearch.Size = new Size(0x16, 0x16);
            this.btnAdwordSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAdwordSearch.TabIndex = 0x23;
            this.btnAdwordSearch.TabStop = false;
            this.btnAdwordSearch.Click += new EventHandler(this.btnAdwordSearch_Click);
            this.btnAdwordCheck.DialogResult = DialogResult.Cancel;
            this.btnAdwordCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAdwordCheck.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnAdwordCheck.Location = new Point(0x2e9, 0x2e);
            this.btnAdwordCheck.Name = "btnAdwordCheck";
            this.btnAdwordCheck.Size = new Size(0x47, 0x1b);
            this.btnAdwordCheck.TabIndex = 7;
            this.btnAdwordCheck.Text = "Kiểm Tra";
            this.btnAdwordCheck.UseVisualStyleBackColor = true;
            this.btnAdwordCheck.Click += new EventHandler(this.btnAdwordCheck_Click);
            this.btnAdwordDelete.BackColor = SystemColors.Control;
            this.btnAdwordDelete.Cursor = Cursors.Hand;
            this.btnAdwordDelete.Image = Resources.smethod_12();
            this.btnAdwordDelete.Location = new Point(0x2cd, 0x31);
            this.btnAdwordDelete.Name = "btnAdwordDelete";
            this.btnAdwordDelete.Size = new Size(0x16, 0x16);
            this.btnAdwordDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnAdwordDelete.TabIndex = 0x16;
            this.btnAdwordDelete.TabStop = false;
            this.btnAdwordDelete.Click += new EventHandler(this.btnAdwordDelete_Click);
            this.btnAdwordEdit.BackColor = SystemColors.Control;
            this.btnAdwordEdit.Cursor = Cursors.Hand;
            this.btnAdwordEdit.Image = Resources.smethod_15();
            this.btnAdwordEdit.Location = new Point(0x2b1, 0x31);
            this.btnAdwordEdit.Name = "btnAdwordEdit";
            this.btnAdwordEdit.Size = new Size(0x16, 0x16);
            this.btnAdwordEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAdwordEdit.TabIndex = 0x15;
            this.btnAdwordEdit.TabStop = false;
            this.btnAdwordEdit.Click += new EventHandler(this.btnAdwordEdit_Click);
            this.btnAdwordAdd.BackColor = SystemColors.Control;
            this.btnAdwordAdd.Cursor = Cursors.Hand;
            this.btnAdwordAdd.Image = Resources.smethod_14();
            this.btnAdwordAdd.Location = new Point(0x295, 0x31);
            this.btnAdwordAdd.Name = "btnAdwordAdd";
            this.btnAdwordAdd.Size = new Size(0x16, 0x16);
            this.btnAdwordAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAdwordAdd.TabIndex = 20;
            this.btnAdwordAdd.TabStop = false;
            this.btnAdwordAdd.Click += new EventHandler(this.btnAdwordAdd_Click);
            this.dtvAdword.AllowUserToAddRows = false;
            this.dtvAdword.AllowUserToDeleteRows = false;
            this.dtvAdword.AllowUserToOrderColumns = true;
            style94.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAdword.AlternatingRowsDefaultCellStyle = style94;
            this.dtvAdword.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAdword.BackgroundColor = Color.White;
            this.dtvAdword.BorderStyle = BorderStyle.None;
            style95.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style95.BackColor = SystemColors.Control;
            style95.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style95.ForeColor = SystemColors.WindowText;
            style95.SelectionBackColor = SystemColors.Highlight;
            style95.SelectionForeColor = SystemColors.HighlightText;
            style95.WrapMode = DataGridViewTriState.True;
            this.dtvAdword.ColumnHeadersDefaultCellStyle = style95;
            this.dtvAdword.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn30, this.dataGridViewTextBoxColumn32, this.dataGridViewLinkColumn3, this.dataGridViewTextBoxColumn33, this.Column12, this.Column16, this.Column13, this.Column14 };
            this.dtvAdword.Columns.AddRange(dataGridViewColumns);
            this.dtvAdword.ContextMenuStrip = this.mnuArticle;
            style96.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style96.BackColor = SystemColors.Window;
            style96.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style96.ForeColor = Color.FromArgb(0, 0, 0x40);
            style96.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style96.SelectionForeColor = Color.White;
            style96.WrapMode = DataGridViewTriState.False;
            this.dtvAdword.DefaultCellStyle = style96;
            this.dtvAdword.Location = new Point(6, 0x4e);
            this.dtvAdword.MultiSelect = false;
            this.dtvAdword.Name = "dtvAdword";
            this.dtvAdword.ReadOnly = true;
            style97.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style97.BackColor = SystemColors.Control;
            style97.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style97.ForeColor = SystemColors.WindowText;
            style97.SelectionBackColor = SystemColors.HighlightText;
            style97.SelectionForeColor = SystemColors.HighlightText;
            style97.WrapMode = DataGridViewTriState.True;
            this.dtvAdword.RowHeadersDefaultCellStyle = style97;
            this.dtvAdword.RowHeadersWidth = 30;
            this.dtvAdword.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAdword.Size = new Size(0x32c, 0x242);
            this.dtvAdword.TabIndex = 8;
            this.dtvAdword.CellClick += new DataGridViewCellEventHandler(this.dtvAdword_CellClick);
            this.dtvAdword.CellContentClick += new DataGridViewCellEventHandler(this.dtvAdword_CellContentClick);
            this.dtvAdword.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAdword_RowPostPaint);
            this.dataGridViewTextBoxColumn30.HeaderText = "ID";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            this.dataGridViewTextBoxColumn32.FillWeight = 220.3802f;
            this.dataGridViewTextBoxColumn32.HeaderText = "Từ kho\x00e1";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewLinkColumn3.FillWeight = 172.8994f;
            this.dataGridViewLinkColumn3.HeaderText = "Website";
            this.dataGridViewLinkColumn3.Name = "dataGridViewLinkColumn3";
            this.dataGridViewLinkColumn3.ReadOnly = true;
            this.dataGridViewLinkColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            style98.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn33.DefaultCellStyle = style98;
            this.dataGridViewTextBoxColumn33.FillWeight = 69.60617f;
            this.dataGridViewTextBoxColumn33.HeaderText = "TOP 3";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            style99.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column12.DefaultCellStyle = style99;
            this.Column12.FillWeight = 72.70892f;
            this.Column12.HeaderText = "TOP 10";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            style100.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column16.DefaultCellStyle = style100;
            this.Column16.FillWeight = 44.14243f;
            this.Column16.HeaderText = "BTOP3";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column13.HeaderText = "Ext";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column14.HeaderText = "Lang";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            toolStripItems = new ToolStripItem[] { this.btnArticleCheckOne, this.btnArticleOpenChange, this.btnArticleOpenAll, this.btnArticleRemove };
            this.mnuArticle.Items.AddRange(toolStripItems);
            this.mnuArticle.Name = "mnuArticle";
            this.mnuArticle.Size = new Size(0xb8, 0x5c);
            this.btnArticleCheckOne.Image = Resources.smethod_21();
            this.btnArticleCheckOne.Name = "btnArticleCheckOne";
            this.btnArticleCheckOne.Size = new Size(0xb7, 0x16);
            this.btnArticleCheckOne.Text = "Kiểm tra";
            this.btnArticleCheckOne.Click += new EventHandler(this.btnArticleCheckOne_Click);
            this.btnArticleOpenChange.Image = Resources.smethod_21();
            this.btnArticleOpenChange.Name = "btnArticleOpenChange";
            this.btnArticleOpenChange.Size = new Size(0xb7, 0x16);
            this.btnArticleOpenChange.Text = "Mở website phản hồi";
            this.btnArticleOpenChange.Click += new EventHandler(this.btnArticleOpenChange_Click);
            this.btnArticleOpenAll.Image = Resources.smethod_21();
            this.btnArticleOpenAll.Name = "btnArticleOpenAll";
            this.btnArticleOpenAll.Size = new Size(0xb7, 0x16);
            this.btnArticleOpenAll.Text = "Mở tất cả website";
            this.btnArticleOpenAll.Click += new EventHandler(this.btnArticleOpenAll_Click);
            this.btnArticleRemove.Image = Resources.smethod_21();
            this.btnArticleRemove.Name = "btnArticleRemove";
            this.btnArticleRemove.Size = new Size(0xb7, 0x16);
            this.btnArticleRemove.Text = "Xo\x00e1";
            this.btnArticleRemove.Click += new EventHandler(this.btnArticleDelete_Click);
            this.groupBox29.Controls.Add(this.btnAdwordCateSearch);
            this.groupBox29.Controls.Add(this.btnAdwordCateAdd);
            this.groupBox29.Controls.Add(this.dtvAdwordCate);
            this.groupBox29.Controls.Add(this.txtAdwordCate);
            this.groupBox29.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox29.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox29.Location = new Point(6, 3);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new Size(0xfc, 0x296);
            this.groupBox29.TabIndex = 0x19;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Danh mục";
            this.btnAdwordCateSearch.BackColor = SystemColors.Control;
            this.btnAdwordCateSearch.Cursor = Cursors.Hand;
            this.btnAdwordCateSearch.Image = Resources.smethod_18();
            this.btnAdwordCateSearch.Location = new Point(0xc4, 20);
            this.btnAdwordCateSearch.Name = "btnAdwordCateSearch";
            this.btnAdwordCateSearch.Size = new Size(0x16, 0x16);
            this.btnAdwordCateSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAdwordCateSearch.TabIndex = 0x23;
            this.btnAdwordCateSearch.TabStop = false;
            this.btnAdwordCateSearch.Click += new EventHandler(this.btnAdwordCateSearch_Click);
            this.btnAdwordCateAdd.BackColor = SystemColors.Control;
            this.btnAdwordCateAdd.Cursor = Cursors.Hand;
            this.btnAdwordCateAdd.Image = Resources.smethod_14();
            this.btnAdwordCateAdd.Location = new Point(0xe0, 20);
            this.btnAdwordCateAdd.Name = "btnAdwordCateAdd";
            this.btnAdwordCateAdd.Size = new Size(0x16, 0x16);
            this.btnAdwordCateAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAdwordCateAdd.TabIndex = 20;
            this.btnAdwordCateAdd.TabStop = false;
            this.btnAdwordCateAdd.Click += new EventHandler(this.btnAdwordCateAdd_Click);
            this.dtvAdwordCate.AllowUserToAddRows = false;
            this.dtvAdwordCate.AllowUserToDeleteRows = false;
            this.dtvAdwordCate.AllowUserToOrderColumns = true;
            style101.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAdwordCate.AlternatingRowsDefaultCellStyle = style101;
            this.dtvAdwordCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAdwordCate.BackgroundColor = Color.White;
            this.dtvAdwordCate.BorderStyle = BorderStyle.None;
            style102.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style102.BackColor = SystemColors.Control;
            style102.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style102.ForeColor = SystemColors.WindowText;
            style102.SelectionBackColor = SystemColors.Highlight;
            style102.SelectionForeColor = SystemColors.HighlightText;
            style102.WrapMode = DataGridViewTriState.True;
            this.dtvAdwordCate.ColumnHeadersDefaultCellStyle = style102;
            this.dtvAdwordCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn34, this.dataGridViewTextBoxColumn35 };
            this.dtvAdwordCate.Columns.AddRange(dataGridViewColumns);
            style103.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style103.BackColor = SystemColors.Window;
            style103.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style103.ForeColor = Color.FromArgb(0, 0, 0x40);
            style103.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style103.SelectionForeColor = Color.White;
            style103.WrapMode = DataGridViewTriState.False;
            this.dtvAdwordCate.DefaultCellStyle = style103;
            this.dtvAdwordCate.Location = new Point(6, 0x30);
            this.dtvAdwordCate.MultiSelect = false;
            this.dtvAdwordCate.Name = "dtvAdwordCate";
            this.dtvAdwordCate.ReadOnly = true;
            style104.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style104.BackColor = SystemColors.Control;
            style104.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style104.ForeColor = SystemColors.WindowText;
            style104.SelectionBackColor = SystemColors.HighlightText;
            style104.SelectionForeColor = SystemColors.HighlightText;
            style104.WrapMode = DataGridViewTriState.True;
            this.dtvAdwordCate.RowHeadersDefaultCellStyle = style104;
            this.dtvAdwordCate.RowHeadersWidth = 30;
            this.dtvAdwordCate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAdwordCate.Size = new Size(240, 0x260);
            this.dtvAdwordCate.TabIndex = 2;
            this.dtvAdwordCate.CellClick += new DataGridViewCellEventHandler(this.dtvAdwordCate_CellClick);
            this.dtvAdwordCate.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAdwordCate_RowPostPaint);
            this.dataGridViewTextBoxColumn34.HeaderText = "ID";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            this.dataGridViewTextBoxColumn35.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.txtAdwordCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAdwordCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAdwordCate.Location = new Point(6, 20);
            this.txtAdwordCate.Name = "txtAdwordCate";
            this.txtAdwordCate.Size = new Size(0xb8, 0x17);
            this.txtAdwordCate.TabIndex = 1;
            this.tbView.Controls.Add(this.groupBox38);
            this.tbView.Location = new Point(4, 0x3d);
            this.tbView.Name = "tbView";
            this.tbView.Size = new Size(0x444, 670);
            this.tbView.TabIndex = 0x15;
            this.tbView.Text = "Chia sẻ View";
            this.tbView.UseVisualStyleBackColor = true;
            this.tbView.Enter += new EventHandler(this.tbView_Enter);
            this.groupBox38.BackColor = SystemColors.Control;
            this.groupBox38.Controls.Add(this.rdViewDisable);
            this.groupBox38.Controls.Add(this.rdViewEnable);
            this.groupBox38.Controls.Add(this.btnExitsWebsite);
            this.groupBox38.Controls.Add(this.label94);
            this.groupBox38.Controls.Add(this.lbViewTime);
            this.groupBox38.Controls.Add(this.lbViewClick);
            this.groupBox38.Controls.Add(this.lbViewCoin);
            this.groupBox38.Controls.Add(this.txtViewWebsite);
            this.groupBox38.Controls.Add(this.btnViewGetSite);
            this.groupBox38.Controls.Add(this.btnViewUpdate);
            this.groupBox38.Controls.Add(this.tabView);
            this.groupBox38.Controls.Add(this.label61);
            this.groupBox38.Controls.Add(this.label41);
            this.groupBox38.Controls.Add(this.label93);
            this.groupBox38.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox38.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox38.Location = new Point(8, 5);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new Size(0x439, 0x296);
            this.groupBox38.TabIndex = 2;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "Chi sẻ nội dụng v\x00e0o c\x00e1c trang Mạng x\x00e3 hội";
            this.rdViewDisable.AutoSize = true;
            this.rdViewDisable.Location = new Point(0x21e, 0x19);
            this.rdViewDisable.Name = "rdViewDisable";
            this.rdViewDisable.Size = new Size(0x3e, 0x12);
            this.rdViewDisable.TabIndex = 3;
            this.rdViewDisable.TabStop = true;
            this.rdViewDisable.Text = "Disable";
            this.rdViewDisable.UseVisualStyleBackColor = true;
            this.rdViewEnable.AutoSize = true;
            this.rdViewEnable.Location = new Point(0x1db, 0x19);
            this.rdViewEnable.Name = "rdViewEnable";
            this.rdViewEnable.Size = new Size(0x3d, 0x12);
            this.rdViewEnable.TabIndex = 2;
            this.rdViewEnable.TabStop = true;
            this.rdViewEnable.Text = "Enable";
            this.rdViewEnable.UseVisualStyleBackColor = true;
            this.btnExitsWebsite.DialogResult = DialogResult.Cancel;
            this.btnExitsWebsite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExitsWebsite.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnExitsWebsite.Location = new Point(0x3d7, 0x11);
            this.btnExitsWebsite.Name = "btnExitsWebsite";
            this.btnExitsWebsite.Size = new Size(0x5c, 0x1f);
            this.btnExitsWebsite.TabIndex = 6;
            this.btnExitsWebsite.Text = "Tắt website";
            this.btnExitsWebsite.UseVisualStyleBackColor = true;
            this.btnExitsWebsite.Click += new EventHandler(this.btnExitsWebsite_Click);
            this.label94.AutoSize = true;
            this.label94.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label94.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label94.Location = new Point(0x2ef, 0x1a);
            this.label94.Name = "label94";
            this.label94.Size = new Size(0x6b, 0x10);
            this.label94.TabIndex = 0x27;
            this.label94.Text = "Thời gian c\x00f2n lại:";
            this.lbViewTime.AutoSize = true;
            this.lbViewTime.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbViewTime.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.lbViewTime.Location = new Point(0x360, 0x1a);
            this.lbViewTime.Name = "lbViewTime";
            this.lbViewTime.Size = new Size(15, 0x10);
            this.lbViewTime.TabIndex = 0x27;
            this.lbViewTime.Text = "0";
            this.lbViewClick.AutoSize = true;
            this.lbViewClick.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbViewClick.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.lbViewClick.Location = new Point(0x1ad, 0x1a);
            this.lbViewClick.Name = "lbViewClick";
            this.lbViewClick.Size = new Size(15, 0x10);
            this.lbViewClick.TabIndex = 0x27;
            this.lbViewClick.Text = "0";
            this.lbViewCoin.AutoSize = true;
            this.lbViewCoin.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbViewCoin.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.lbViewCoin.Location = new Point(0x161, 0x1a);
            this.lbViewCoin.Name = "lbViewCoin";
            this.lbViewCoin.Size = new Size(15, 0x10);
            this.lbViewCoin.TabIndex = 0x27;
            this.lbViewCoin.Text = "0";
            this.txtViewWebsite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtViewWebsite.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtViewWebsite.Location = new Point(0x3f, 0x15);
            this.txtViewWebsite.Name = "txtViewWebsite";
            this.txtViewWebsite.Size = new Size(0xf3, 0x17);
            this.txtViewWebsite.TabIndex = 1;
            this.btnViewGetSite.DialogResult = DialogResult.Cancel;
            this.btnViewGetSite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnViewGetSite.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnViewGetSite.Location = new Point(0x375, 0x11);
            this.btnViewGetSite.Name = "btnViewGetSite";
            this.btnViewGetSite.Size = new Size(0x5c, 0x1f);
            this.btnViewGetSite.TabIndex = 5;
            this.btnViewGetSite.Text = "Tăng iCoin";
            this.btnViewGetSite.UseVisualStyleBackColor = true;
            this.btnViewGetSite.Click += new EventHandler(this.btnViewGetSite_Click);
            this.btnViewUpdate.DialogResult = DialogResult.Cancel;
            this.btnViewUpdate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnViewUpdate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnViewUpdate.Location = new Point(610, 0x11);
            this.btnViewUpdate.Name = "btnViewUpdate";
            this.btnViewUpdate.Size = new Size(0x48, 0x1f);
            this.btnViewUpdate.TabIndex = 4;
            this.btnViewUpdate.Text = "Cập nhật";
            this.btnViewUpdate.UseVisualStyleBackColor = true;
            this.btnViewUpdate.Click += new EventHandler(this.btnViewUpdate_Click);
            this.tabView.Location = new Point(6, 0x33);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new Size(0x42d, 0x25d);
            this.tabView.TabIndex = 7;
            this.label61.AutoSize = true;
            this.label61.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label61.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label61.Location = new Point(0x185, 0x1a);
            this.label61.Name = "label61";
            this.label61.Size = new Size(0x22, 0x10);
            this.label61.TabIndex = 0x12;
            this.label61.Text = "Click";
            this.label41.AutoSize = true;
            this.label41.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label41.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label41.Location = new Point(0x137, 0x1a);
            this.label41.Name = "label41";
            this.label41.Size = new Size(0x24, 0x10);
            this.label41.TabIndex = 0x12;
            this.label41.Text = "iCoin";
            this.label93.AutoSize = true;
            this.label93.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label93.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label93.Location = new Point(3, 0x1a);
            this.label93.Name = "label93";
            this.label93.Size = new Size(0x36, 0x10);
            this.label93.TabIndex = 0x12;
            this.label93.Text = "Website";
            this.tbRival.Controls.Add(this.groupBox9);
            this.tbRival.Location = new Point(4, 0x3d);
            this.tbRival.Name = "tbRival";
            this.tbRival.Size = new Size(0x444, 670);
            this.tbRival.TabIndex = 11;
            this.tbRival.Text = "Ph\x00e2n t\x00edch Đối thủ";
            this.tbRival.UseVisualStyleBackColor = true;
            this.groupBox9.Controls.Add(this.txtRivalDomain);
            this.groupBox9.Controls.Add(this.btnRivalCheck);
            this.groupBox9.Controls.Add(this.dtvRivalMonth2);
            this.groupBox9.Controls.Add(this.dtvRivalMonth1);
            this.groupBox9.Controls.Add(this.dtvRivalList);
            this.groupBox9.Controls.Add(this.dtvRivalHigh);
            this.groupBox9.Controls.Add(this.dtvRivalTop);
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Controls.Add(this.label37);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.Domain);
            this.groupBox9.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox9.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox9.Location = new Point(4, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new Size(0x438, 0x296);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ph\x00e2n t\x00edch từ kho\x00e1 đối thủ (Double Click TOP từ kho\x00e1)";
            this.txtRivalDomain.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtRivalDomain.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtRivalDomain.Location = new Point(0x4a, 0x12);
            this.txtRivalDomain.Name = "txtRivalDomain";
            this.txtRivalDomain.Size = new Size(0x36b, 0x17);
            this.txtRivalDomain.TabIndex = 1;
            this.txtRivalDomain.KeyUp += new KeyEventHandler(this.txtRivalDomain_KeyUp);
            this.btnRivalCheck.DialogResult = DialogResult.Cancel;
            this.btnRivalCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRivalCheck.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRivalCheck.Location = new Point(0x3bb, 14);
            this.btnRivalCheck.Name = "btnRivalCheck";
            this.btnRivalCheck.Size = new Size(0x74, 0x1d);
            this.btnRivalCheck.TabIndex = 2;
            this.btnRivalCheck.Text = "Kiểm Tra";
            this.btnRivalCheck.UseVisualStyleBackColor = true;
            this.btnRivalCheck.Click += new EventHandler(this.btnRivalCheck_Click);
            this.dtvRivalMonth2.AllowUserToAddRows = false;
            this.dtvRivalMonth2.AllowUserToDeleteRows = false;
            this.dtvRivalMonth2.AllowUserToOrderColumns = true;
            style105.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvRivalMonth2.AlternatingRowsDefaultCellStyle = style105;
            this.dtvRivalMonth2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRivalMonth2.BackgroundColor = Color.White;
            this.dtvRivalMonth2.BorderStyle = BorderStyle.None;
            style106.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style106.BackColor = SystemColors.Control;
            style106.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style106.ForeColor = SystemColors.WindowText;
            style106.SelectionBackColor = SystemColors.Highlight;
            style106.SelectionForeColor = SystemColors.HighlightText;
            style106.WrapMode = DataGridViewTriState.True;
            this.dtvRivalMonth2.ColumnHeadersDefaultCellStyle = style106;
            this.dtvRivalMonth2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4 };
            this.dtvRivalMonth2.Columns.AddRange(dataGridViewColumns);
            style107.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style107.BackColor = SystemColors.Window;
            style107.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style107.ForeColor = Color.FromArgb(0, 0, 0x40);
            style107.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style107.SelectionForeColor = Color.White;
            style107.WrapMode = DataGridViewTriState.False;
            this.dtvRivalMonth2.DefaultCellStyle = style107;
            this.dtvRivalMonth2.Location = new Point(0x2d1, 70);
            this.dtvRivalMonth2.MultiSelect = false;
            this.dtvRivalMonth2.Name = "dtvRivalMonth2";
            this.dtvRivalMonth2.ReadOnly = true;
            style108.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style108.BackColor = SystemColors.Control;
            style108.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style108.ForeColor = SystemColors.WindowText;
            style108.SelectionBackColor = SystemColors.HighlightText;
            style108.SelectionForeColor = SystemColors.HighlightText;
            style108.WrapMode = DataGridViewTriState.True;
            this.dtvRivalMonth2.RowHeadersDefaultCellStyle = style108;
            this.dtvRivalMonth2.RowHeadersWidth = 30;
            this.dtvRivalMonth2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvRivalMonth2.Size = new Size(350, 0xf6);
            this.dtvRivalMonth2.TabIndex = 5;
            this.dtvRivalMonth2.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvRivalMonth2_CellDoubleClick);
            this.dtvRivalMonth2.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvRivalMonth2_RowPostPaint);
            this.dataGridViewTextBoxColumn3.FillWeight = 139.0863f;
            this.dataGridViewTextBoxColumn3.HeaderText = "Từ kh\x00f3a";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            style109.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = style109;
            this.dataGridViewTextBoxColumn4.FillWeight = 60.9137f;
            this.dataGridViewTextBoxColumn4.HeaderText = "% Truy cập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dtvRivalMonth1.AllowUserToAddRows = false;
            this.dtvRivalMonth1.AllowUserToDeleteRows = false;
            this.dtvRivalMonth1.AllowUserToOrderColumns = true;
            style110.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvRivalMonth1.AlternatingRowsDefaultCellStyle = style110;
            this.dtvRivalMonth1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRivalMonth1.BackgroundColor = Color.White;
            this.dtvRivalMonth1.BorderStyle = BorderStyle.None;
            style111.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style111.BackColor = SystemColors.Control;
            style111.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style111.ForeColor = SystemColors.WindowText;
            style111.SelectionBackColor = SystemColors.Highlight;
            style111.SelectionForeColor = SystemColors.HighlightText;
            style111.WrapMode = DataGridViewTriState.True;
            this.dtvRivalMonth1.ColumnHeadersDefaultCellStyle = style111;
            this.dtvRivalMonth1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2 };
            this.dtvRivalMonth1.Columns.AddRange(dataGridViewColumns);
            style112.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style112.BackColor = SystemColors.Window;
            style112.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style112.ForeColor = Color.FromArgb(0, 0, 0x40);
            style112.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style112.SelectionForeColor = Color.White;
            style112.WrapMode = DataGridViewTriState.False;
            this.dtvRivalMonth1.DefaultCellStyle = style112;
            this.dtvRivalMonth1.Location = new Point(0x16d, 70);
            this.dtvRivalMonth1.MultiSelect = false;
            this.dtvRivalMonth1.Name = "dtvRivalMonth1";
            this.dtvRivalMonth1.ReadOnly = true;
            style113.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style113.BackColor = SystemColors.Control;
            style113.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style113.ForeColor = SystemColors.WindowText;
            style113.SelectionBackColor = SystemColors.HighlightText;
            style113.SelectionForeColor = SystemColors.HighlightText;
            style113.WrapMode = DataGridViewTriState.True;
            this.dtvRivalMonth1.RowHeadersDefaultCellStyle = style113;
            this.dtvRivalMonth1.RowHeadersWidth = 30;
            this.dtvRivalMonth1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvRivalMonth1.Size = new Size(350, 0xf6);
            this.dtvRivalMonth1.TabIndex = 4;
            this.dtvRivalMonth1.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvRivalMonth1_CellDoubleClick);
            this.dtvRivalMonth1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvRivalMonth1_RowPostPaint);
            this.dataGridViewTextBoxColumn1.FillWeight = 139.0863f;
            this.dataGridViewTextBoxColumn1.HeaderText = "Từ kh\x00f3a";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            style114.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = style114;
            this.dataGridViewTextBoxColumn2.FillWeight = 60.9137f;
            this.dataGridViewTextBoxColumn2.HeaderText = "% Truy cập";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dtvRivalList.AllowUserToAddRows = false;
            this.dtvRivalList.AllowUserToDeleteRows = false;
            this.dtvRivalList.AllowUserToOrderColumns = true;
            style115.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvRivalList.AlternatingRowsDefaultCellStyle = style115;
            this.dtvRivalList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRivalList.BackgroundColor = Color.White;
            this.dtvRivalList.BorderStyle = BorderStyle.None;
            style116.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style116.BackColor = SystemColors.Control;
            style116.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style116.ForeColor = SystemColors.WindowText;
            style116.SelectionBackColor = SystemColors.Highlight;
            style116.SelectionForeColor = SystemColors.HighlightText;
            style116.WrapMode = DataGridViewTriState.True;
            this.dtvRivalList.ColumnHeadersDefaultCellStyle = style116;
            this.dtvRivalList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn22, this.dataGridViewTextBoxColumn23, this.Column1 };
            this.dtvRivalList.Columns.AddRange(dataGridViewColumns);
            style117.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style117.BackColor = SystemColors.Window;
            style117.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style117.ForeColor = Color.FromArgb(0, 0, 0x40);
            style117.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style117.SelectionForeColor = Color.White;
            style117.WrapMode = DataGridViewTriState.False;
            this.dtvRivalList.DefaultCellStyle = style117;
            this.dtvRivalList.Location = new Point(0x16d, 0x15a);
            this.dtvRivalList.MultiSelect = false;
            this.dtvRivalList.Name = "dtvRivalList";
            this.dtvRivalList.ReadOnly = true;
            style118.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style118.BackColor = SystemColors.Control;
            style118.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style118.ForeColor = SystemColors.WindowText;
            style118.SelectionBackColor = SystemColors.HighlightText;
            style118.SelectionForeColor = SystemColors.HighlightText;
            style118.WrapMode = DataGridViewTriState.True;
            this.dtvRivalList.RowHeadersDefaultCellStyle = style118;
            this.dtvRivalList.RowHeadersWidth = 30;
            this.dtvRivalList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvRivalList.Size = new Size(0x2c5, 310);
            this.dtvRivalList.TabIndex = 7;
            this.dtvRivalList.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvRivalList_CellDoubleClick);
            this.dtvRivalList.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvRivalTop_RowPostPaint);
            this.dataGridViewTextBoxColumn22.FillWeight = 177.3483f;
            this.dataGridViewTextBoxColumn22.HeaderText = "Từ kh\x00f3a";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            style119.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = style119;
            this.dataGridViewTextBoxColumn23.FillWeight = 61.73793f;
            this.dataGridViewTextBoxColumn23.HeaderText = "Chỉ số truy cập";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            style120.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = style120;
            this.Column1.FillWeight = 60.9137f;
            this.Column1.HeaderText = "Chỉ số t\x00ecm kiếm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.dtvRivalHigh.AllowUserToAddRows = false;
            this.dtvRivalHigh.AllowUserToDeleteRows = false;
            this.dtvRivalHigh.AllowUserToOrderColumns = true;
            style121.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvRivalHigh.AlternatingRowsDefaultCellStyle = style121;
            this.dtvRivalHigh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRivalHigh.BackgroundColor = Color.White;
            this.dtvRivalHigh.BorderStyle = BorderStyle.None;
            style122.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style122.BackColor = SystemColors.Control;
            style122.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style122.ForeColor = SystemColors.WindowText;
            style122.SelectionBackColor = SystemColors.Highlight;
            style122.SelectionForeColor = SystemColors.HighlightText;
            style122.WrapMode = DataGridViewTriState.True;
            this.dtvRivalHigh.ColumnHeadersDefaultCellStyle = style122;
            this.dtvRivalHigh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn24, this.dataGridViewTextBoxColumn25 };
            this.dtvRivalHigh.Columns.AddRange(dataGridViewColumns);
            style123.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style123.BackColor = SystemColors.Window;
            style123.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style123.ForeColor = Color.FromArgb(0, 0, 0x40);
            style123.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style123.SelectionForeColor = Color.White;
            style123.WrapMode = DataGridViewTriState.False;
            this.dtvRivalHigh.DefaultCellStyle = style123;
            this.dtvRivalHigh.Location = new Point(6, 0x15a);
            this.dtvRivalHigh.MultiSelect = false;
            this.dtvRivalHigh.Name = "dtvRivalHigh";
            this.dtvRivalHigh.ReadOnly = true;
            style124.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style124.BackColor = SystemColors.Control;
            style124.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style124.ForeColor = SystemColors.WindowText;
            style124.SelectionBackColor = SystemColors.HighlightText;
            style124.SelectionForeColor = SystemColors.HighlightText;
            style124.WrapMode = DataGridViewTriState.True;
            this.dtvRivalHigh.RowHeadersDefaultCellStyle = style124;
            this.dtvRivalHigh.RowHeadersWidth = 30;
            this.dtvRivalHigh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvRivalHigh.Size = new Size(350, 310);
            this.dtvRivalHigh.TabIndex = 6;
            this.dtvRivalHigh.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvRivalHigh_CellDoubleClick);
            this.dtvRivalHigh.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvRivalTop_RowPostPaint);
            this.dataGridViewTextBoxColumn24.FillWeight = 139.0863f;
            this.dataGridViewTextBoxColumn24.HeaderText = "Từ kh\x00f3a";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            style125.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = style125;
            this.dataGridViewTextBoxColumn25.FillWeight = 60.9137f;
            this.dataGridViewTextBoxColumn25.HeaderText = "Độ mạnh";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dtvRivalTop.AllowUserToAddRows = false;
            this.dtvRivalTop.AllowUserToDeleteRows = false;
            this.dtvRivalTop.AllowUserToOrderColumns = true;
            style126.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvRivalTop.AlternatingRowsDefaultCellStyle = style126;
            this.dtvRivalTop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRivalTop.BackgroundColor = Color.White;
            this.dtvRivalTop.BorderStyle = BorderStyle.None;
            style127.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style127.BackColor = SystemColors.Control;
            style127.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style127.ForeColor = SystemColors.WindowText;
            style127.SelectionBackColor = SystemColors.Highlight;
            style127.SelectionForeColor = SystemColors.HighlightText;
            style127.WrapMode = DataGridViewTriState.True;
            this.dtvRivalTop.ColumnHeadersDefaultCellStyle = style127;
            this.dtvRivalTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn20, this.dataGridViewTextBoxColumn21 };
            this.dtvRivalTop.Columns.AddRange(dataGridViewColumns);
            style128.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style128.BackColor = SystemColors.Window;
            style128.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style128.ForeColor = Color.FromArgb(0, 0, 0x40);
            style128.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style128.SelectionForeColor = Color.White;
            style128.WrapMode = DataGridViewTriState.False;
            this.dtvRivalTop.DefaultCellStyle = style128;
            this.dtvRivalTop.Location = new Point(9, 70);
            this.dtvRivalTop.MultiSelect = false;
            this.dtvRivalTop.Name = "dtvRivalTop";
            this.dtvRivalTop.ReadOnly = true;
            style129.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style129.BackColor = SystemColors.Control;
            style129.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style129.ForeColor = SystemColors.WindowText;
            style129.SelectionBackColor = SystemColors.HighlightText;
            style129.SelectionForeColor = SystemColors.HighlightText;
            style129.WrapMode = DataGridViewTriState.True;
            this.dtvRivalTop.RowHeadersDefaultCellStyle = style129;
            this.dtvRivalTop.RowHeadersWidth = 30;
            this.dtvRivalTop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvRivalTop.Size = new Size(350, 0xf6);
            this.dtvRivalTop.TabIndex = 3;
            this.dtvRivalTop.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvRivalTop_CellDoubleClick);
            this.dtvRivalTop.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvRivalTop_RowPostPaint);
            this.dataGridViewTextBoxColumn20.FillWeight = 139.0863f;
            this.dataGridViewTextBoxColumn20.HeaderText = "Từ kh\x00f3a";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            style130.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = style130;
            this.dataGridViewTextBoxColumn21.FillWeight = 60.9137f;
            this.dataGridViewTextBoxColumn21.HeaderText = "% Truy cập";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.label36.AutoSize = true;
            this.label36.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label36.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label36.Location = new Point(0x2ce, 0x33);
            this.label36.Name = "label36";
            this.label36.Size = new Size(130, 0x10);
            this.label36.TabIndex = 1;
            this.label36.Text = "Lượng t\x00ecm kiếm GIẢM";
            this.label37.AutoSize = true;
            this.label37.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label37.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label37.Location = new Point(0x16a, 0x147);
            this.label37.Name = "label37";
            this.label37.Size = new Size(0xcf, 0x10);
            this.label37.TabIndex = 1;
            this.label37.Text = "Danh s\x00e1ch t\x00ecm ki\x00eam theo lưu lượng";
            this.label33.AutoSize = true;
            this.label33.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label33.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label33.Location = new Point(0x16a, 0x33);
            this.label33.Name = "label33";
            this.label33.Size = new Size(0x84, 0x10);
            this.label33.TabIndex = 1;
            this.label33.Text = "Lượng t\x00ecm kiếm TĂNG";
            this.label38.AutoSize = true;
            this.label38.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label38.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label38.Location = new Point(6, 0x147);
            this.label38.Name = "label38";
            this.label38.Size = new Size(0x79, 0x10);
            this.label38.TabIndex = 1;
            this.label38.Text = "Từ kho\x00e1 quan trọng";
            this.label25.AutoSize = true;
            this.label25.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label25.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label25.Location = new Point(6, 0x33);
            this.label25.Name = "label25";
            this.label25.Size = new Size(0x59, 0x10);
            this.label25.TabIndex = 1;
            this.label25.Text = "T\x00ecm kiếm TOP";
            this.label25.TextAlign = ContentAlignment.MiddleCenter;
            this.Domain.AutoSize = true;
            this.Domain.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Domain.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.Domain.Location = new Point(6, 0x15);
            this.Domain.Name = "Domain";
            this.Domain.Size = new Size(0x3e, 0x10);
            this.Domain.TabIndex = 1;
            this.Domain.Text = "T\x00ean miền";
            this.tbBacklink.Controls.Add(this.groupBox11);
            this.tbBacklink.Controls.Add(this.groupBox8);
            this.tbBacklink.Location = new Point(4, 0x3d);
            this.tbBacklink.Name = "tbBacklink";
            this.tbBacklink.Size = new Size(0x444, 670);
            this.tbBacklink.TabIndex = 12;
            this.tbBacklink.Text = "Quản l\x00fd Backlink";
            this.tbBacklink.UseVisualStyleBackColor = true;
            this.tbBacklink.Enter += new EventHandler(this.tbBacklink_Enter);
            this.groupBox11.Controls.Add(this.btnBacklinkSearch);
            this.groupBox11.Controls.Add(this.btnBacklinkDelete);
            this.groupBox11.Controls.Add(this.btnBacklinkEdit);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.btnBacklinkAdd);
            this.groupBox11.Controls.Add(this.dtvBacklink);
            this.groupBox11.Controls.Add(this.btnBacklinkCheck);
            this.groupBox11.Controls.Add(this.txtBacklinkUrl);
            this.groupBox11.Controls.Add(this.txtBacklinkWeblink);
            this.groupBox11.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox11.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox11.Location = new Point(0x10a, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new Size(0x337, 0x296);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Danh s\x00e1ch Backlink";
            this.btnBacklinkSearch.BackColor = SystemColors.Control;
            this.btnBacklinkSearch.Cursor = Cursors.Hand;
            this.btnBacklinkSearch.Image = Resources.smethod_18();
            this.btnBacklinkSearch.Location = new Point(0x27e, 20);
            this.btnBacklinkSearch.Name = "btnBacklinkSearch";
            this.btnBacklinkSearch.Size = new Size(0x16, 0x16);
            this.btnBacklinkSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnBacklinkSearch.TabIndex = 0x25;
            this.btnBacklinkSearch.TabStop = false;
            this.btnBacklinkSearch.Click += new EventHandler(this.btnBacklinkSearch_Click);
            this.btnBacklinkDelete.BackColor = SystemColors.Control;
            this.btnBacklinkDelete.Cursor = Cursors.Hand;
            this.btnBacklinkDelete.Image = Resources.smethod_12();
            this.btnBacklinkDelete.Location = new Point(0x2d2, 20);
            this.btnBacklinkDelete.Name = "btnBacklinkDelete";
            this.btnBacklinkDelete.Size = new Size(0x16, 0x16);
            this.btnBacklinkDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnBacklinkDelete.TabIndex = 0x16;
            this.btnBacklinkDelete.TabStop = false;
            this.btnBacklinkDelete.Click += new EventHandler(this.btnBacklinkDelete_Click);
            this.btnBacklinkEdit.BackColor = SystemColors.Control;
            this.btnBacklinkEdit.Cursor = Cursors.Hand;
            this.btnBacklinkEdit.Image = Resources.smethod_15();
            this.btnBacklinkEdit.Location = new Point(0x2b6, 20);
            this.btnBacklinkEdit.Name = "btnBacklinkEdit";
            this.btnBacklinkEdit.Size = new Size(0x16, 0x16);
            this.btnBacklinkEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnBacklinkEdit.TabIndex = 0x15;
            this.btnBacklinkEdit.TabStop = false;
            this.btnBacklinkEdit.Click += new EventHandler(this.btnBacklinkEdit_Click);
            this.label35.AutoSize = true;
            this.label35.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label35.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label35.Location = new Point(0x131, 0x17);
            this.label35.Name = "label35";
            this.label35.Size = new Size(0x4f, 0x10);
            this.label35.TabIndex = 10;
            this.label35.Text = "Web li\x00ean kết";
            this.label34.AutoSize = true;
            this.label34.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label34.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label34.Location = new Point(6, 0x17);
            this.label34.Name = "label34";
            this.label34.Size = new Size(0x34, 0x10);
            this.label34.TabIndex = 10;
            this.label34.Text = "Li\x00ean kết";
            this.btnBacklinkAdd.BackColor = SystemColors.Control;
            this.btnBacklinkAdd.Cursor = Cursors.Hand;
            this.btnBacklinkAdd.Image = Resources.smethod_14();
            this.btnBacklinkAdd.Location = new Point(0x29a, 20);
            this.btnBacklinkAdd.Name = "btnBacklinkAdd";
            this.btnBacklinkAdd.Size = new Size(0x16, 0x16);
            this.btnBacklinkAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnBacklinkAdd.TabIndex = 20;
            this.btnBacklinkAdd.TabStop = false;
            this.btnBacklinkAdd.Click += new EventHandler(this.btnBacklinkAdd_Click);
            this.dtvBacklink.AllowUserToAddRows = false;
            this.dtvBacklink.AllowUserToDeleteRows = false;
            this.dtvBacklink.AllowUserToOrderColumns = true;
            style131.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvBacklink.AlternatingRowsDefaultCellStyle = style131;
            this.dtvBacklink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvBacklink.BackgroundColor = Color.White;
            this.dtvBacklink.BorderStyle = BorderStyle.None;
            style132.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style132.BackColor = SystemColors.Control;
            style132.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style132.ForeColor = SystemColors.WindowText;
            style132.SelectionBackColor = SystemColors.Highlight;
            style132.SelectionForeColor = SystemColors.HighlightText;
            style132.WrapMode = DataGridViewTriState.True;
            this.dtvBacklink.ColumnHeadersDefaultCellStyle = style132;
            this.dtvBacklink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.BacklinkID, this.BacklinkName, this.BacklinkTitle, this.BacklinkUrl, this.BacklinkWebsite, this.BacklinkPR, this.BacklinkRel, this.BacklinkDensity, this.BacklinkIndex };
            this.dtvBacklink.Columns.AddRange(dataGridViewColumns);
            style133.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style133.BackColor = SystemColors.Window;
            style133.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style133.ForeColor = Color.FromArgb(0, 0, 0x40);
            style133.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style133.SelectionForeColor = Color.White;
            style133.WrapMode = DataGridViewTriState.False;
            this.dtvBacklink.DefaultCellStyle = style133;
            this.dtvBacklink.Location = new Point(6, 50);
            this.dtvBacklink.MultiSelect = false;
            this.dtvBacklink.Name = "dtvBacklink";
            this.dtvBacklink.ReadOnly = true;
            style134.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style134.BackColor = SystemColors.Control;
            style134.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style134.ForeColor = SystemColors.WindowText;
            style134.SelectionBackColor = SystemColors.HighlightText;
            style134.SelectionForeColor = SystemColors.HighlightText;
            style134.WrapMode = DataGridViewTriState.True;
            this.dtvBacklink.RowHeadersDefaultCellStyle = style134;
            this.dtvBacklink.RowHeadersWidth = 30;
            this.dtvBacklink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvBacklink.Size = new Size(0x32c, 0x25e);
            this.dtvBacklink.TabIndex = 11;
            this.dtvBacklink.CellClick += new DataGridViewCellEventHandler(this.dtvBacklink_CellClick);
            this.dtvBacklink.CellContentClick += new DataGridViewCellEventHandler(this.dtvBacklink_CellContentClick);
            this.dtvBacklink.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvBacklink_RowPostPaint);
            this.BacklinkID.HeaderText = "ID";
            this.BacklinkID.Name = "BacklinkID";
            this.BacklinkID.ReadOnly = true;
            this.BacklinkID.Visible = false;
            this.BacklinkName.FillWeight = 122.761f;
            this.BacklinkName.HeaderText = "Name";
            this.BacklinkName.Name = "BacklinkName";
            this.BacklinkName.ReadOnly = true;
            this.BacklinkTitle.FillWeight = 130.5443f;
            this.BacklinkTitle.HeaderText = "Title";
            this.BacklinkTitle.Name = "BacklinkTitle";
            this.BacklinkTitle.ReadOnly = true;
            this.BacklinkUrl.FillWeight = 140.6347f;
            this.BacklinkUrl.HeaderText = "Li\x00ean kết";
            this.BacklinkUrl.Name = "BacklinkUrl";
            this.BacklinkUrl.ReadOnly = true;
            this.BacklinkUrl.SortMode = DataGridViewColumnSortMode.Automatic;
            this.BacklinkWebsite.FillWeight = 153.678f;
            this.BacklinkWebsite.HeaderText = "Web li\x00ean kết";
            this.BacklinkWebsite.Name = "BacklinkWebsite";
            this.BacklinkWebsite.ReadOnly = true;
            this.BacklinkWebsite.SortMode = DataGridViewColumnSortMode.Automatic;
            style135.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.BacklinkPR.DefaultCellStyle = style135;
            this.BacklinkPR.FillWeight = 35.08284f;
            this.BacklinkPR.HeaderText = "PR";
            this.BacklinkPR.Name = "BacklinkPR";
            this.BacklinkPR.ReadOnly = true;
            style136.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.BacklinkRel.DefaultCellStyle = style136;
            this.BacklinkRel.FillWeight = 78.42464f;
            this.BacklinkRel.HeaderText = "Rel";
            this.BacklinkRel.Name = "BacklinkRel";
            this.BacklinkRel.ReadOnly = true;
            style137.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.BacklinkDensity.DefaultCellStyle = style137;
            this.BacklinkDensity.FillWeight = 101.5228f;
            this.BacklinkDensity.HeaderText = "Ph\x00f9 hợp (%)";
            this.BacklinkDensity.Name = "BacklinkDensity";
            this.BacklinkDensity.ReadOnly = true;
            style138.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.BacklinkIndex.DefaultCellStyle = style138;
            this.BacklinkIndex.FillWeight = 37.35165f;
            this.BacklinkIndex.HeaderText = "Index";
            this.BacklinkIndex.Name = "BacklinkIndex";
            this.BacklinkIndex.ReadOnly = true;
            this.btnBacklinkCheck.DialogResult = DialogResult.Cancel;
            this.btnBacklinkCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnBacklinkCheck.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnBacklinkCheck.Location = new Point(750, 0x11);
            this.btnBacklinkCheck.Name = "btnBacklinkCheck";
            this.btnBacklinkCheck.Size = new Size(0x44, 0x1b);
            this.btnBacklinkCheck.TabIndex = 10;
            this.btnBacklinkCheck.Text = "Kiểm Tra";
            this.btnBacklinkCheck.UseVisualStyleBackColor = true;
            this.btnBacklinkCheck.Click += new EventHandler(this.btnBacklinkCheck_Click);
            this.txtBacklinkUrl.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBacklinkUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtBacklinkUrl.Location = new Point(0x40, 20);
            this.txtBacklinkUrl.Name = "txtBacklinkUrl";
            this.txtBacklinkUrl.Size = new Size(0xeb, 0x17);
            this.txtBacklinkUrl.TabIndex = 5;
            this.txtBacklinkWeblink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBacklinkWeblink.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtBacklinkWeblink.Location = new Point(390, 0x13);
            this.txtBacklinkWeblink.Name = "txtBacklinkWeblink";
            this.txtBacklinkWeblink.Size = new Size(0xf2, 0x17);
            this.txtBacklinkWeblink.TabIndex = 6;
            this.groupBox8.Controls.Add(this.btnBacklinkCateSearch);
            this.groupBox8.Controls.Add(this.btnBacklinkCateAdd);
            this.groupBox8.Controls.Add(this.dtvBacklinkCate);
            this.groupBox8.Controls.Add(this.txtBacklinkCate);
            this.groupBox8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox8.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox8.Location = new Point(8, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new Size(0xfc, 0x296);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Danh mục";
            this.btnBacklinkCateSearch.BackColor = SystemColors.Control;
            this.btnBacklinkCateSearch.Cursor = Cursors.Hand;
            this.btnBacklinkCateSearch.Image = Resources.smethod_18();
            this.btnBacklinkCateSearch.Location = new Point(0xc4, 20);
            this.btnBacklinkCateSearch.Name = "btnBacklinkCateSearch";
            this.btnBacklinkCateSearch.Size = new Size(0x16, 0x16);
            this.btnBacklinkCateSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnBacklinkCateSearch.TabIndex = 0x24;
            this.btnBacklinkCateSearch.TabStop = false;
            this.btnBacklinkCateSearch.Click += new EventHandler(this.btnBacklinkCateSearch_Click);
            this.btnBacklinkCateAdd.BackColor = SystemColors.Control;
            this.btnBacklinkCateAdd.Cursor = Cursors.Hand;
            this.btnBacklinkCateAdd.Image = Resources.smethod_14();
            this.btnBacklinkCateAdd.Location = new Point(0xe0, 20);
            this.btnBacklinkCateAdd.Name = "btnBacklinkCateAdd";
            this.btnBacklinkCateAdd.Size = new Size(0x16, 0x16);
            this.btnBacklinkCateAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnBacklinkCateAdd.TabIndex = 20;
            this.btnBacklinkCateAdd.TabStop = false;
            this.btnBacklinkCateAdd.Click += new EventHandler(this.btnBacklinkCateAdd_Click);
            this.dtvBacklinkCate.AllowUserToAddRows = false;
            this.dtvBacklinkCate.AllowUserToDeleteRows = false;
            this.dtvBacklinkCate.AllowUserToOrderColumns = true;
            style139.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvBacklinkCate.AlternatingRowsDefaultCellStyle = style139;
            this.dtvBacklinkCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvBacklinkCate.BackgroundColor = Color.White;
            this.dtvBacklinkCate.BorderStyle = BorderStyle.None;
            style140.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style140.BackColor = SystemColors.Control;
            style140.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style140.ForeColor = SystemColors.WindowText;
            style140.SelectionBackColor = SystemColors.Highlight;
            style140.SelectionForeColor = SystemColors.HighlightText;
            style140.WrapMode = DataGridViewTriState.True;
            this.dtvBacklinkCate.ColumnHeadersDefaultCellStyle = style140;
            this.dtvBacklinkCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.CateID, this.dataGridViewTextBoxColumn5 };
            this.dtvBacklinkCate.Columns.AddRange(dataGridViewColumns);
            style141.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style141.BackColor = SystemColors.Window;
            style141.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style141.ForeColor = Color.FromArgb(0, 0, 0x40);
            style141.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style141.SelectionForeColor = Color.White;
            style141.WrapMode = DataGridViewTriState.False;
            this.dtvBacklinkCate.DefaultCellStyle = style141;
            this.dtvBacklinkCate.Location = new Point(6, 50);
            this.dtvBacklinkCate.MultiSelect = false;
            this.dtvBacklinkCate.Name = "dtvBacklinkCate";
            this.dtvBacklinkCate.ReadOnly = true;
            style142.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style142.BackColor = SystemColors.Control;
            style142.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style142.ForeColor = SystemColors.WindowText;
            style142.SelectionBackColor = SystemColors.HighlightText;
            style142.SelectionForeColor = SystemColors.HighlightText;
            style142.WrapMode = DataGridViewTriState.True;
            this.dtvBacklinkCate.RowHeadersDefaultCellStyle = style142;
            this.dtvBacklinkCate.RowHeadersWidth = 30;
            this.dtvBacklinkCate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvBacklinkCate.Size = new Size(240, 0x25e);
            this.dtvBacklinkCate.TabIndex = 4;
            this.dtvBacklinkCate.CellClick += new DataGridViewCellEventHandler(this.dtvBacklinkCate_CellClick);
            this.dtvBacklinkCate.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvBacklinkCate_RowPostPaint);
            this.CateID.HeaderText = "ID";
            this.CateID.Name = "CateID";
            this.CateID.ReadOnly = true;
            this.CateID.Visible = false;
            this.dataGridViewTextBoxColumn5.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.txtBacklinkCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBacklinkCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtBacklinkCate.Location = new Point(6, 20);
            this.txtBacklinkCate.Name = "txtBacklinkCate";
            this.txtBacklinkCate.Size = new Size(0xb8, 0x17);
            this.txtBacklinkCate.TabIndex = 1;
            this.tbNews.Controls.Add(this.groupBox25);
            this.tbNews.Controls.Add(this.groupBox24);
            this.tbNews.Controls.Add(this.groupBox30);
            this.tbNews.Location = new Point(4, 0x3d);
            this.tbNews.Name = "tbNews";
            this.tbNews.Size = new Size(0x444, 670);
            this.tbNews.TabIndex = 0x10;
            this.tbNews.Text = "T\x00ecm kiếm nội dung";
            this.tbNews.UseVisualStyleBackColor = true;
            this.tbNews.Enter += new EventHandler(this.tbNews_Enter);
            this.groupBox25.Controls.Add(this.ckNewsAuto4);
            this.groupBox25.Controls.Add(this.ckNewsAuto3);
            this.groupBox25.Controls.Add(this.ckNewsAuto1);
            this.groupBox25.Controls.Add(this.ckNewsAuto2);
            this.groupBox25.Controls.Add(this.btnNewsAuto);
            this.groupBox25.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox25.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox25.Location = new Point(0x105, 3);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new Size(0x33c, 0x41);
            this.groupBox25.TabIndex = 0x1c;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Đăng b\x00e0i Tự động (Lựa chọn nhiều b\x00e0i viết v\x00e0 C\x00e1c thuộc t\x00ednh để Auto)";
            this.ckNewsAuto4.AutoSize = true;
            this.ckNewsAuto4.Location = new Point(0x1e9, 30);
            this.ckNewsAuto4.Name = "ckNewsAuto4";
            this.ckNewsAuto4.Size = new Size(0xe1, 0x12);
            this.ckNewsAuto4.TabIndex = 0x13;
            this.ckNewsAuto4.Text = "Tự động th\x00eam nội dung v\x00e0o b\x00e0i viết";
            this.ckNewsAuto4.UseVisualStyleBackColor = true;
            this.ckNewsAuto3.AutoSize = true;
            this.ckNewsAuto3.Location = new Point(0x153, 30);
            this.ckNewsAuto3.Name = "ckNewsAuto3";
            this.ckNewsAuto3.Size = new Size(0x90, 0x12);
            this.ckNewsAuto3.TabIndex = 0x13;
            this.ckNewsAuto3.Text = "Tự động tạo Li\x00ean kết";
            this.ckNewsAuto3.UseVisualStyleBackColor = true;
            this.ckNewsAuto1.AutoSize = true;
            this.ckNewsAuto1.Location = new Point(6, 30);
            this.ckNewsAuto1.Name = "ckNewsAuto1";
            this.ckNewsAuto1.Size = new Size(220, 0x12);
            this.ckNewsAuto1.TabIndex = 0x13;
            this.ckNewsAuto1.Text = "Tự động th\x00eam từ kho\x00e1 v\x00e0o ti\x00eau đề";
            this.ckNewsAuto1.UseVisualStyleBackColor = true;
            this.ckNewsAuto2.AutoSize = true;
            this.ckNewsAuto2.Location = new Point(0xe8, 30);
            this.ckNewsAuto2.Name = "ckNewsAuto2";
            this.ckNewsAuto2.Size = new Size(0x65, 0x12);
            this.ckNewsAuto2.TabIndex = 0x13;
            this.ckNewsAuto2.Text = "Tự động Bold";
            this.ckNewsAuto2.UseVisualStyleBackColor = true;
            this.btnNewsAuto.DialogResult = DialogResult.Cancel;
            this.btnNewsAuto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnNewsAuto.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnNewsAuto.Location = new Point(720, 0x17);
            this.btnNewsAuto.Name = "btnNewsAuto";
            this.btnNewsAuto.Size = new Size(0x66, 0x1f);
            this.btnNewsAuto.TabIndex = 0x12;
            this.btnNewsAuto.Text = "Đăng B\x00e0i";
            this.btnNewsAuto.UseVisualStyleBackColor = true;
            this.btnNewsAuto.Click += new EventHandler(this.btnNewsAuto_Click);
            this.groupBox24.Controls.Add(this.dtvNews);
            this.groupBox24.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox24.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox24.Location = new Point(260, 0x4a);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new Size(0x33d, 0x252);
            this.groupBox24.TabIndex = 0x1d;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Danh s\x00e1ch b\x00e0i viết (Double Click để chọn)";
            this.dtvNews.AllowUserToAddRows = false;
            this.dtvNews.AllowUserToDeleteRows = false;
            this.dtvNews.AllowUserToOrderColumns = true;
            style143.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvNews.AlternatingRowsDefaultCellStyle = style143;
            this.dtvNews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvNews.BackgroundColor = Color.White;
            this.dtvNews.BorderStyle = BorderStyle.None;
            style144.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style144.BackColor = SystemColors.Control;
            style144.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style144.ForeColor = SystemColors.WindowText;
            style144.SelectionBackColor = SystemColors.Highlight;
            style144.SelectionForeColor = SystemColors.HighlightText;
            style144.WrapMode = DataGridViewTriState.True;
            this.dtvNews.ColumnHeadersDefaultCellStyle = style144;
            this.dtvNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.Column15, this.dataGridViewTextBoxColumn39, this.Column19, this.Column18, this.Column10, this.Column8, this.Column17, this.Column21 };
            this.dtvNews.Columns.AddRange(dataGridViewColumns);
            style145.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style145.BackColor = SystemColors.Window;
            style145.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style145.ForeColor = Color.FromArgb(0, 0, 0x40);
            style145.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style145.SelectionForeColor = Color.White;
            style145.WrapMode = DataGridViewTriState.False;
            this.dtvNews.DefaultCellStyle = style145;
            this.dtvNews.Location = new Point(6, 0x15);
            this.dtvNews.Name = "dtvNews";
            this.dtvNews.ReadOnly = true;
            style146.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style146.BackColor = SystemColors.Control;
            style146.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style146.ForeColor = SystemColors.WindowText;
            style146.SelectionBackColor = SystemColors.HighlightText;
            style146.SelectionForeColor = SystemColors.HighlightText;
            style146.WrapMode = DataGridViewTriState.True;
            this.dtvNews.RowHeadersDefaultCellStyle = style146;
            this.dtvNews.RowHeadersWidth = 30;
            this.dtvNews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvNews.Size = new Size(0x332, 0x235);
            this.dtvNews.TabIndex = 5;
            this.dtvNews.CellContentClick += new DataGridViewCellEventHandler(this.dtvNews_CellContentClick);
            this.dtvNews.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvNews_CellDoubleClick);
            this.dtvNews.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvNews_RowPostPaint);
            this.Column15.HeaderText = "ID";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            this.dataGridViewTextBoxColumn39.FillWeight = 264.1524f;
            this.dataGridViewTextBoxColumn39.HeaderText = "Ti\x00eau đề";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.Column19.FillWeight = 82.94421f;
            this.Column19.HeaderText = "Nguồn";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column18.FillWeight = 132.2054f;
            this.Column18.HeaderText = "Link";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column10.HeaderText = "Url";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column8.HeaderText = "Image";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column17.HeaderText = "Desc";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            this.Column21.FillWeight = 41.07823f;
            this.Column21.HeaderText = "Đ\x00e3 Post";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Resizable = DataGridViewTriState.True;
            this.Column21.SortMode = DataGridViewColumnSortMode.Automatic;
            this.groupBox30.Controls.Add(this.cbNewsCate);
            this.groupBox30.Controls.Add(this.btnNewsCateSearch);
            this.groupBox30.Controls.Add(this.btnNewsCateAdd);
            this.groupBox30.Controls.Add(this.dtvNewsCate);
            this.groupBox30.Controls.Add(this.txtNewsCate);
            this.groupBox30.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox30.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox30.Location = new Point(3, 3);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new Size(0xfc, 0x296);
            this.groupBox30.TabIndex = 0x1c;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Nh\x00f3m từ kho\x00e1 (Ph\x00e2n c\x00e1ch dấu \",\" )";
            this.cbNewsCate.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbNewsCate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbNewsCate.FlatStyle = FlatStyle.Popup;
            this.cbNewsCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbNewsCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbNewsCate.FormattingEnabled = true;
            items = new object[] { "Email", "Regex" };
            this.cbNewsCate.Items.AddRange(items);
            this.cbNewsCate.Location = new Point(6, 0x31);
            this.cbNewsCate.Name = "cbNewsCate";
            this.cbNewsCate.Size = new Size(240, 0x18);
            this.cbNewsCate.TabIndex = 0x24;
            this.cbNewsCate.SelectionChangeCommitted += new EventHandler(this.cbNewsCate_SelectionChangeCommitted);
            this.btnNewsCateSearch.BackColor = SystemColors.Control;
            this.btnNewsCateSearch.Cursor = Cursors.Hand;
            this.btnNewsCateSearch.Image = Resources.smethod_18();
            this.btnNewsCateSearch.Location = new Point(0xc4, 20);
            this.btnNewsCateSearch.Name = "btnNewsCateSearch";
            this.btnNewsCateSearch.Size = new Size(0x16, 0x16);
            this.btnNewsCateSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnNewsCateSearch.TabIndex = 0x23;
            this.btnNewsCateSearch.TabStop = false;
            this.btnNewsCateSearch.Click += new EventHandler(this.btnNewsCateSearch_Click);
            this.btnNewsCateAdd.BackColor = SystemColors.Control;
            this.btnNewsCateAdd.Cursor = Cursors.Hand;
            this.btnNewsCateAdd.Image = Resources.smethod_14();
            this.btnNewsCateAdd.Location = new Point(0xe0, 20);
            this.btnNewsCateAdd.Name = "btnNewsCateAdd";
            this.btnNewsCateAdd.Size = new Size(0x16, 0x16);
            this.btnNewsCateAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnNewsCateAdd.TabIndex = 20;
            this.btnNewsCateAdd.TabStop = false;
            this.btnNewsCateAdd.Click += new EventHandler(this.btnNewsCateAdd_Click);
            this.dtvNewsCate.AllowUserToAddRows = false;
            this.dtvNewsCate.AllowUserToDeleteRows = false;
            this.dtvNewsCate.AllowUserToOrderColumns = true;
            style147.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvNewsCate.AlternatingRowsDefaultCellStyle = style147;
            this.dtvNewsCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvNewsCate.BackgroundColor = Color.White;
            this.dtvNewsCate.BorderStyle = BorderStyle.None;
            style148.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style148.BackColor = SystemColors.Control;
            style148.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style148.ForeColor = SystemColors.WindowText;
            style148.SelectionBackColor = SystemColors.Highlight;
            style148.SelectionForeColor = SystemColors.HighlightText;
            style148.WrapMode = DataGridViewTriState.True;
            this.dtvNewsCate.ColumnHeadersDefaultCellStyle = style148;
            this.dtvNewsCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn45, this.dataGridViewTextBoxColumn46 };
            this.dtvNewsCate.Columns.AddRange(dataGridViewColumns);
            style149.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style149.BackColor = SystemColors.Window;
            style149.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style149.ForeColor = Color.FromArgb(0, 0, 0x40);
            style149.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style149.SelectionForeColor = Color.White;
            style149.WrapMode = DataGridViewTriState.False;
            this.dtvNewsCate.DefaultCellStyle = style149;
            this.dtvNewsCate.Location = new Point(6, 0x4f);
            this.dtvNewsCate.MultiSelect = false;
            this.dtvNewsCate.Name = "dtvNewsCate";
            this.dtvNewsCate.ReadOnly = true;
            style150.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style150.BackColor = SystemColors.Control;
            style150.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style150.ForeColor = SystemColors.WindowText;
            style150.SelectionBackColor = SystemColors.HighlightText;
            style150.SelectionForeColor = SystemColors.HighlightText;
            style150.WrapMode = DataGridViewTriState.True;
            this.dtvNewsCate.RowHeadersDefaultCellStyle = style150;
            this.dtvNewsCate.RowHeadersWidth = 30;
            this.dtvNewsCate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvNewsCate.Size = new Size(240, 0x241);
            this.dtvNewsCate.TabIndex = 4;
            this.dtvNewsCate.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvNewsCate_CellDoubleClick);
            this.dtvNewsCate.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvNewsCate_RowPostPaint);
            this.dataGridViewTextBoxColumn45.HeaderText = "ID";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Visible = false;
            this.dataGridViewTextBoxColumn46.HeaderText = "Từ kho\x00e1";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.txtNewsCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNewsCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtNewsCate.Location = new Point(6, 20);
            this.txtNewsCate.Name = "txtNewsCate";
            this.txtNewsCate.Size = new Size(0xb8, 0x17);
            this.txtNewsCate.TabIndex = 1;
            this.txtNewsCate.KeyUp += new KeyEventHandler(this.txtNewsCate_KeyUp);
            this.tbHTML.Controls.Add(this.btnHTMLCode);
            this.tbHTML.Controls.Add(this.btnHTMLBBcode);
            this.tbHTML.Controls.Add(this.btnHTMLBold);
            this.tbHTML.Controls.Add(this.txtHTMLDesc);
            this.tbHTML.Controls.Add(this.groupBox34);
            this.tbHTML.Controls.Add(this.groupBox33);
            this.tbHTML.Controls.Add(this.groupBox32);
            this.tbHTML.Controls.Add(this.label67);
            this.tbHTML.Controls.Add(this.txtHTMLKeyword);
            this.tbHTML.Controls.Add(this.txtHTMLTitle);
            this.tbHTML.Controls.Add(this.label83);
            this.tbHTML.Controls.Add(this.label66);
            this.tbHTML.Controls.Add(this.webEditor);
            this.tbHTML.Controls.Add(this.btnHTMLSaveImage);
            this.tbHTML.Controls.Add(this.btnHTMLRemoveHref);
            this.tbHTML.Location = new Point(4, 0x3d);
            this.tbHTML.Name = "tbHTML";
            this.tbHTML.Size = new Size(0x444, 670);
            this.tbHTML.TabIndex = 0x11;
            this.tbHTML.Text = "Copyrighter Pro";
            this.tbHTML.UseVisualStyleBackColor = true;
            this.tbHTML.Enter += new EventHandler(this.tbHTML_Enter);
            this.btnHTMLCode.DialogResult = DialogResult.Cancel;
            this.btnHTMLCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLCode.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLCode.Location = new Point(0x2fa, 0x77);
            this.btnHTMLCode.Name = "btnHTMLCode";
            this.btnHTMLCode.Size = new Size(0x4f, 0x1a);
            this.btnHTMLCode.TabIndex = 6;
            this.btnHTMLCode.Text = "HTML";
            this.btnHTMLCode.UseVisualStyleBackColor = true;
            this.btnHTMLCode.Click += new EventHandler(this.btnHTMLCode_Click);
            this.btnHTMLBBcode.DialogResult = DialogResult.Cancel;
            this.btnHTMLBBcode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLBBcode.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLBBcode.Location = new Point(0x2fa, 90);
            this.btnHTMLBBcode.Name = "btnHTMLBBcode";
            this.btnHTMLBBcode.Size = new Size(0x4f, 0x1a);
            this.btnHTMLBBcode.TabIndex = 6;
            this.btnHTMLBBcode.Text = "BBCode";
            this.btnHTMLBBcode.UseVisualStyleBackColor = true;
            this.btnHTMLBBcode.Click += new EventHandler(this.btnHTMLBBcode_Click);
            this.btnHTMLBold.DialogResult = DialogResult.Cancel;
            this.btnHTMLBold.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLBold.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLBold.Location = new Point(0x339, 10);
            this.btnHTMLBold.Name = "btnHTMLBold";
            this.btnHTMLBold.Size = new Size(0x2f, 0x1b);
            this.btnHTMLBold.TabIndex = 3;
            this.btnHTMLBold.Text = "Bold";
            this.btnHTMLBold.UseVisualStyleBackColor = true;
            this.btnHTMLBold.Click += new EventHandler(this.btnHTMLBold_Click);
            this.txtHTMLDesc.BorderStyle = BorderStyle.None;
            this.txtHTMLDesc.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtHTMLDesc.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtHTMLDesc.Location = new Point(0x47, 0x29);
            this.txtHTMLDesc.Name = "txtHTMLDesc";
            this.txtHTMLDesc.Size = new Size(0x268, 0x25);
            this.txtHTMLDesc.TabIndex = 4;
            this.txtHTMLDesc.Text = "";
            this.groupBox34.Controls.Add(this.numericHTMLRandomContent);
            this.groupBox34.Controls.Add(this.label80);
            this.groupBox34.Controls.Add(this.label78);
            this.groupBox34.Controls.Add(this.btnHTMLAddContent);
            this.groupBox34.Controls.Add(this.cbHTMLTitle);
            this.groupBox34.Controls.Add(this.cbHTMLContent);
            this.groupBox34.Controls.Add(this.btnHTMLAutoInsertContent);
            this.groupBox34.Controls.Add(this.btnHTMLInsertContent);
            this.groupBox34.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox34.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox34.Location = new Point(0x36e, 0x1f3);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new Size(0xce, 0xa6);
            this.groupBox34.TabIndex = 0x2b;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Quản l\x00fd nội dung";
            this.numericHTMLRandomContent.Location = new Point(160, 0x5e);
            this.numericHTMLRandomContent.Maximum = new decimal(new int[] { 0xe10 });
            this.numericHTMLRandomContent.Name = "numericHTMLRandomContent";
            this.numericHTMLRandomContent.Size = new Size(40, 0x16);
            this.numericHTMLRandomContent.TabIndex = 0x11;
            this.numericHTMLRandomContent.TextAlign = HorizontalAlignment.Center;
            this.numericHTMLRandomContent.Value = new decimal(new int[] { 1 });
            this.label80.AutoSize = true;
            this.label80.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label80.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label80.Location = new Point(6, 0x47);
            this.label80.Name = "label80";
            this.label80.Size = new Size(0x33, 0x10);
            this.label80.TabIndex = 0x23;
            this.label80.Text = "Ti\x00eau đề";
            this.label78.AutoSize = true;
            this.label78.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label78.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label78.Location = new Point(5, 20);
            this.label78.Name = "label78";
            this.label78.Size = new Size(0x3a, 0x10);
            this.label78.TabIndex = 0x23;
            this.label78.Text = "Nội dung";
            this.btnHTMLAddContent.BackColor = SystemColors.Control;
            this.btnHTMLAddContent.Cursor = Cursors.Hand;
            this.btnHTMLAddContent.Image = Resources.smethod_14();
            this.btnHTMLAddContent.Location = new Point(0xb2, 40);
            this.btnHTMLAddContent.Name = "btnHTMLAddContent";
            this.btnHTMLAddContent.Size = new Size(0x16, 0x16);
            this.btnHTMLAddContent.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnHTMLAddContent.TabIndex = 0x25;
            this.btnHTMLAddContent.TabStop = false;
            this.btnHTMLAddContent.Click += new EventHandler(this.btnHTMLAddContent_Click);
            this.cbHTMLTitle.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbHTMLTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbHTMLTitle.FlatStyle = FlatStyle.Popup;
            this.cbHTMLTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbHTMLTitle.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbHTMLTitle.FormattingEnabled = true;
            this.cbHTMLTitle.Location = new Point(6, 0x5e);
            this.cbHTMLTitle.Name = "cbHTMLTitle";
            this.cbHTMLTitle.Size = new Size(0x91, 0x18);
            this.cbHTMLTitle.TabIndex = 0x10;
            this.cbHTMLContent.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbHTMLContent.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbHTMLContent.FlatStyle = FlatStyle.Popup;
            this.cbHTMLContent.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbHTMLContent.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbHTMLContent.FormattingEnabled = true;
            this.cbHTMLContent.Location = new Point(6, 40);
            this.cbHTMLContent.Name = "cbHTMLContent";
            this.cbHTMLContent.Size = new Size(0xa6, 0x18);
            this.cbHTMLContent.TabIndex = 15;
            this.cbHTMLContent.SelectedIndexChanged += new EventHandler(this.cbHTMLContent_SelectedIndexChanged);
            this.btnHTMLAutoInsertContent.DialogResult = DialogResult.Cancel;
            this.btnHTMLAutoInsertContent.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLAutoInsertContent.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLAutoInsertContent.Location = new Point(0x66, 0x80);
            this.btnHTMLAutoInsertContent.Name = "btnHTMLAutoInsertContent";
            this.btnHTMLAutoInsertContent.Size = new Size(0x60, 0x1b);
            this.btnHTMLAutoInsertContent.TabIndex = 0x13;
            this.btnHTMLAutoInsertContent.Text = "Tạo Nội Dung";
            this.btnHTMLAutoInsertContent.UseVisualStyleBackColor = true;
            this.btnHTMLAutoInsertContent.Click += new EventHandler(this.btnHTMLAutoInsertContent_Click);
            this.btnHTMLInsertContent.DialogResult = DialogResult.Cancel;
            this.btnHTMLInsertContent.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLInsertContent.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLInsertContent.Location = new Point(9, 0x80);
            this.btnHTMLInsertContent.Name = "btnHTMLInsertContent";
            this.btnHTMLInsertContent.Size = new Size(0x57, 0x1b);
            this.btnHTMLInsertContent.TabIndex = 0x12;
            this.btnHTMLInsertContent.Text = "Th\x00eam";
            this.btnHTMLInsertContent.UseVisualStyleBackColor = true;
            this.btnHTMLInsertContent.Click += new EventHandler(this.btnHTMLInsertContent_Click);
            this.groupBox33.Controls.Add(this.cbHTMLAnchor);
            this.groupBox33.Controls.Add(this.label53);
            this.groupBox33.Controls.Add(this.btnHTMLAddAnchor);
            this.groupBox33.Controls.Add(this.btnHTMLInsertAnchor);
            this.groupBox33.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox33.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox33.Location = new Point(0x36e, 0x183);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new Size(0xce, 0x6a);
            this.groupBox33.TabIndex = 0x2a;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Li\x00ean kết tự động";
            this.cbHTMLAnchor.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbHTMLAnchor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbHTMLAnchor.FlatStyle = FlatStyle.Popup;
            this.cbHTMLAnchor.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbHTMLAnchor.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbHTMLAnchor.FormattingEnabled = true;
            this.cbHTMLAnchor.Location = new Point(6, 40);
            this.cbHTMLAnchor.Name = "cbHTMLAnchor";
            this.cbHTMLAnchor.Size = new Size(0xa6, 0x18);
            this.cbHTMLAnchor.TabIndex = 13;
            this.label53.AutoSize = true;
            this.label53.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label53.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label53.Location = new Point(6, 0x13);
            this.label53.Name = "label53";
            this.label53.Size = new Size(0x34, 0x10);
            this.label53.TabIndex = 0x20;
            this.label53.Text = "Li\x00ean kết";
            this.btnHTMLAddAnchor.BackColor = SystemColors.Control;
            this.btnHTMLAddAnchor.Cursor = Cursors.Hand;
            this.btnHTMLAddAnchor.Image = Resources.smethod_14();
            this.btnHTMLAddAnchor.Location = new Point(0xb2, 40);
            this.btnHTMLAddAnchor.Name = "btnHTMLAddAnchor";
            this.btnHTMLAddAnchor.Size = new Size(0x16, 0x16);
            this.btnHTMLAddAnchor.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnHTMLAddAnchor.TabIndex = 0x22;
            this.btnHTMLAddAnchor.TabStop = false;
            this.btnHTMLAddAnchor.Click += new EventHandler(this.btnHTMLAddAnchor_Click);
            this.btnHTMLInsertAnchor.DialogResult = DialogResult.Cancel;
            this.btnHTMLInsertAnchor.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLInsertAnchor.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLInsertAnchor.Location = new Point(0x3d, 70);
            this.btnHTMLInsertAnchor.Name = "btnHTMLInsertAnchor";
            this.btnHTMLInsertAnchor.Size = new Size(0x4b, 0x1b);
            this.btnHTMLInsertAnchor.TabIndex = 14;
            this.btnHTMLInsertAnchor.Text = "Cập nhật";
            this.btnHTMLInsertAnchor.UseVisualStyleBackColor = true;
            this.btnHTMLInsertAnchor.Click += new EventHandler(this.btnHTMLInsertAnchor_Click);
            this.groupBox32.Controls.Add(this.txtHTMLTags);
            this.groupBox32.Controls.Add(this.listHTMLCategory);
            this.groupBox32.Controls.Add(this.btnHTMLPostHand);
            this.groupBox32.Controls.Add(this.btnHTMLPost);
            this.groupBox32.Controls.Add(this.cbHTMLAccount);
            this.groupBox32.Controls.Add(this.btnHTMLAddAccount);
            this.groupBox32.Controls.Add(this.label81);
            this.groupBox32.Controls.Add(this.label82);
            this.groupBox32.Controls.Add(this.label79);
            this.groupBox32.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox32.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox32.Location = new Point(0x36e, 3);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new Size(0xce, 0x17a);
            this.groupBox32.TabIndex = 0x29;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Đăng b\x00e0i";
            this.txtHTMLTags.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtHTMLTags.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtHTMLTags.Location = new Point(4, 0x13c);
            this.txtHTMLTags.Name = "txtHTMLTags";
            this.txtHTMLTags.Size = new Size(0xc2, 0x17);
            this.txtHTMLTags.TabIndex = 11;
            this.listHTMLCategory.FormattingEnabled = true;
            this.listHTMLCategory.ItemHeight = 14;
            this.listHTMLCategory.Location = new Point(6, 0x5b);
            this.listHTMLCategory.Name = "listHTMLCategory";
            this.listHTMLCategory.SelectionMode = SelectionMode.MultiSimple;
            this.listHTMLCategory.Size = new Size(0xc2, 200);
            this.listHTMLCategory.TabIndex = 10;
            this.btnHTMLPostHand.DialogResult = DialogResult.Cancel;
            this.btnHTMLPostHand.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLPostHand.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLPostHand.Location = new Point(0x66, 0x159);
            this.btnHTMLPostHand.Name = "btnHTMLPostHand";
            this.btnHTMLPostHand.Size = new Size(0x60, 0x1b);
            this.btnHTMLPostHand.TabIndex = 12;
            this.btnHTMLPostHand.Text = "B\x00e1n Tự Động";
            this.btnHTMLPostHand.UseVisualStyleBackColor = true;
            this.btnHTMLPostHand.Click += new EventHandler(this.btnHTMLPostHand_Click);
            this.btnHTMLPost.DialogResult = DialogResult.Cancel;
            this.btnHTMLPost.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLPost.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLPost.Location = new Point(4, 0x159);
            this.btnHTMLPost.Name = "btnHTMLPost";
            this.btnHTMLPost.Size = new Size(0x5c, 0x1b);
            this.btnHTMLPost.TabIndex = 12;
            this.btnHTMLPost.Text = "Auto Post";
            this.btnHTMLPost.UseVisualStyleBackColor = true;
            this.btnHTMLPost.Click += new EventHandler(this.btnHTMLPost_Click);
            this.cbHTMLAccount.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbHTMLAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbHTMLAccount.FlatStyle = FlatStyle.Popup;
            this.cbHTMLAccount.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbHTMLAccount.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbHTMLAccount.FormattingEnabled = true;
            this.cbHTMLAccount.Location = new Point(6, 40);
            this.cbHTMLAccount.Name = "cbHTMLAccount";
            this.cbHTMLAccount.Size = new Size(0xa7, 0x18);
            this.cbHTMLAccount.TabIndex = 8;
            this.cbHTMLAccount.SelectionChangeCommitted += new EventHandler(this.cbHTMLAccount_SelectionChangeCommitted);
            this.btnHTMLAddAccount.BackColor = SystemColors.Control;
            this.btnHTMLAddAccount.Cursor = Cursors.Hand;
            this.btnHTMLAddAccount.Image = Resources.smethod_14();
            this.btnHTMLAddAccount.Location = new Point(0xb2, 40);
            this.btnHTMLAddAccount.Name = "btnHTMLAddAccount";
            this.btnHTMLAddAccount.Size = new Size(0x16, 0x16);
            this.btnHTMLAddAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnHTMLAddAccount.TabIndex = 40;
            this.btnHTMLAddAccount.TabStop = false;
            this.btnHTMLAddAccount.Click += new EventHandler(this.btnHTMLAddAccount_Click);
            this.label81.AutoSize = true;
            this.label81.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label81.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label81.Location = new Point(6, 0x48);
            this.label81.Name = "label81";
            this.label81.Size = new Size(0x41, 0x10);
            this.label81.TabIndex = 0x26;
            this.label81.Text = "Danh mục";
            this.label82.AutoSize = true;
            this.label82.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label82.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label82.Location = new Point(5, 0x125);
            this.label82.Name = "label82";
            this.label82.Size = new Size(0x24, 0x10);
            this.label82.TabIndex = 0x26;
            this.label82.Text = "Tags";
            this.label79.AutoSize = true;
            this.label79.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label79.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label79.Location = new Point(3, 20);
            this.label79.Name = "label79";
            this.label79.Size = new Size(0x40, 0x10);
            this.label79.TabIndex = 0x26;
            this.label79.Text = "T\x00e0i khoản";
            this.label67.AutoSize = true;
            this.label67.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label67.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label67.Location = new Point(14, 0x29);
            this.label67.Name = "label67";
            this.label67.Size = new Size(40, 0x10);
            this.label67.TabIndex = 30;
            this.label67.Text = "M\x00f4 tả";
            this.txtHTMLKeyword.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtHTMLKeyword.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtHTMLKeyword.Location = new Point(640, 12);
            this.txtHTMLKeyword.Name = "txtHTMLKeyword";
            this.txtHTMLKeyword.Size = new Size(0xb3, 0x17);
            this.txtHTMLKeyword.TabIndex = 2;
            this.txtHTMLTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtHTMLTitle.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtHTMLTitle.Location = new Point(0x47, 12);
            this.txtHTMLTitle.Name = "txtHTMLTitle";
            this.txtHTMLTitle.Size = new Size(0x1f6, 0x17);
            this.txtHTMLTitle.TabIndex = 1;
            this.label83.AutoSize = true;
            this.label83.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label83.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label83.Location = new Point(0x243, 15);
            this.label83.Name = "label83";
            this.label83.Size = new Size(0x37, 0x10);
            this.label83.TabIndex = 0x1c;
            this.label83.Text = "Từ kho\x00e1";
            this.label66.AutoSize = true;
            this.label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label66.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label66.Location = new Point(14, 15);
            this.label66.Name = "label66";
            this.label66.Size = new Size(0x33, 0x10);
            this.label66.TabIndex = 0x1c;
            this.label66.Text = "Ti\x00eau đề";
            this.webEditor.Location = new Point(8, 0x54);
            this.webEditor.MinimumSize = new Size(20, 20);
            this.webEditor.Name = "webEditor";
            this.webEditor.ScriptErrorsSuppressed = true;
            this.webEditor.Size = new Size(0x360, 0x245);
            this.webEditor.TabIndex = 7;
            this.webEditor.Url = new Uri("http://igoo.vn/editor.html", UriKind.Absolute);
            this.btnHTMLSaveImage.DialogResult = DialogResult.Cancel;
            this.btnHTMLSaveImage.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLSaveImage.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLSaveImage.Location = new Point(0x2b5, 0x2b);
            this.btnHTMLSaveImage.Name = "btnHTMLSaveImage";
            this.btnHTMLSaveImage.Size = new Size(90, 0x23);
            this.btnHTMLSaveImage.TabIndex = 6;
            this.btnHTMLSaveImage.Text = "Tải H\x00ecnh Ảnh";
            this.btnHTMLSaveImage.UseVisualStyleBackColor = true;
            this.btnHTMLSaveImage.Click += new EventHandler(this.btnHTMLSaveImage_Click);
            this.btnHTMLRemoveHref.DialogResult = DialogResult.Cancel;
            this.btnHTMLRemoveHref.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLRemoveHref.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLRemoveHref.Location = new Point(0x315, 0x2b);
            this.btnHTMLRemoveHref.Name = "btnHTMLRemoveHref";
            this.btnHTMLRemoveHref.Size = new Size(0x53, 0x23);
            this.btnHTMLRemoveHref.TabIndex = 5;
            this.btnHTMLRemoveHref.Text = "Xo\x00e1 li\x00ean kết";
            this.btnHTMLRemoveHref.UseVisualStyleBackColor = true;
            this.btnHTMLRemoveHref.Click += new EventHandler(this.btnHTMLRemoveHref_Click);
            this.tbSubmit.Controls.Add(this.groupBox6);
            this.tbSubmit.Location = new Point(4, 0x3d);
            this.tbSubmit.Name = "tbSubmit";
            this.tbSubmit.Size = new Size(0x444, 670);
            this.tbSubmit.TabIndex = 13;
            this.tbSubmit.Text = "Marketing Tools";
            this.tbSubmit.UseVisualStyleBackColor = true;
            this.tbSubmit.Enter += new EventHandler(this.tbSubmit_Enter);
            this.groupBox6.Controls.Add(this.btnSubmitGetSource);
            this.groupBox6.Controls.Add(this.webSubmit);
            this.groupBox6.Controls.Add(this.btnSubmitSave);
            this.groupBox6.Controls.Add(this.btnSubmitImport);
            this.groupBox6.Controls.Add(this.numAutoClick);
            this.groupBox6.Controls.Add(this.label49);
            this.groupBox6.Controls.Add(this.numSubmitTime);
            this.groupBox6.Controls.Add(this.label54);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.btnSubmitAuto);
            this.groupBox6.Controls.Add(this.btnSubmitView);
            this.groupBox6.Controls.Add(this.btnSubmitNext);
            this.groupBox6.Controls.Add(this.btnSubmitOK);
            this.groupBox6.Controls.Add(this.txtSubmitAdd);
            this.groupBox6.Controls.Add(this.txtSubmitAddress);
            this.groupBox6.Controls.Add(this.btnSubmitSearch);
            this.groupBox6.Controls.Add(this.btnSubmitDelete);
            this.groupBox6.Controls.Add(this.btnSubmitEdit);
            this.groupBox6.Controls.Add(this.btnAutoClick);
            this.groupBox6.Controls.Add(this.btnSubmitAdd);
            this.groupBox6.Controls.Add(this.dtvSubmit);
            this.groupBox6.Controls.Add(this.cbAuto);
            this.groupBox6.Controls.Add(this.cbSubmitCate);
            this.groupBox6.Controls.Add(this.cbAttributeCate);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.lbnhom);
            this.groupBox6.Controls.Add(this.btnSubmitAttribute);
            this.groupBox6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox6.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox6.Location = new Point(6, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(0x439, 0x298);
            this.groupBox6.TabIndex = 0x18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quản l\x00fd Submit nội dung";
            this.btnSubmitGetSource.BackColor = Color.White;
            this.btnSubmitGetSource.Cursor = Cursors.Hand;
            this.btnSubmitGetSource.Image = Resources.smethod_7();
            this.btnSubmitGetSource.Location = new Point(0x400, 0x48);
            this.btnSubmitGetSource.Name = "btnSubmitGetSource";
            this.btnSubmitGetSource.Size = new Size(0x16, 0x17);
            this.btnSubmitGetSource.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnSubmitGetSource.TabIndex = 0x2f;
            this.btnSubmitGetSource.TabStop = false;
            this.btnSubmitGetSource.Click += new EventHandler(this.btnSubmitGetSource_Click);
            this.webSubmit.Location = new Point(0xde, 0x38);
            this.webSubmit.MinimumSize = new Size(20, 20);
            this.webSubmit.Name = "webSubmit";
            this.webSubmit.ScriptErrorsSuppressed = true;
            this.webSubmit.Size = new Size(0x355, 0x25a);
            this.webSubmit.TabIndex = 0x30;
            this.webSubmit.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webSubmit_DocumentCompleted);
            this.webSubmit.Navigating += new WebBrowserNavigatingEventHandler(this.webSubmit_Navigating);
            this.btnSubmitSave.BackColor = Color.Transparent;
            this.btnSubmitSave.Cursor = Cursors.Hand;
            this.btnSubmitSave.Image = Resources.smethod_7();
            this.btnSubmitSave.Location = new Point(0xc2, 0xa5);
            this.btnSubmitSave.Name = "btnSubmitSave";
            this.btnSubmitSave.Size = new Size(0x16, 0x17);
            this.btnSubmitSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnSubmitSave.TabIndex = 0x2f;
            this.btnSubmitSave.TabStop = false;
            this.btnSubmitSave.Click += new EventHandler(this.btnSubmitSave_Click);
            this.btnSubmitImport.DialogResult = DialogResult.Cancel;
            this.btnSubmitImport.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSubmitImport.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSubmitImport.Location = new Point(6, 0xc2);
            this.btnSubmitImport.Name = "btnSubmitImport";
            this.btnSubmitImport.Size = new Size(0x6b, 0x20);
            this.btnSubmitImport.TabIndex = 0x2e;
            this.btnSubmitImport.Text = "Nhập nhiều Url";
            this.btnSubmitImport.UseVisualStyleBackColor = true;
            this.btnSubmitImport.Click += new EventHandler(this.btnSubmitImport_Click);
            this.numSubmitTime.Increment = new decimal(new int[] { 5 });
            this.numSubmitTime.Location = new Point(0x39c, 0x18);
            this.numSubmitTime.Maximum = new decimal(new int[] { 0xe10 });
            this.numSubmitTime.Name = "numSubmitTime";
            this.numSubmitTime.Size = new Size(0x2d, 0x16);
            this.numSubmitTime.TabIndex = 2;
            this.numSubmitTime.TextAlign = HorizontalAlignment.Center;
            this.numSubmitTime.Value = new decimal(new int[] { 10 });
            this.label54.AutoSize = true;
            this.label54.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label54.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label54.Location = new Point(0x3cf, 0x1a);
            this.label54.Name = "label54";
            this.label54.Size = new Size(0x1f, 0x10);
            this.label54.TabIndex = 0x2d;
            this.label54.Text = "gi\x00e2y";
            this.label51.AutoSize = true;
            this.label51.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label51.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label51.Location = new Point(0x332, 0x1a);
            this.label51.Name = "label51";
            this.label51.Size = new Size(100, 0x10);
            this.label51.TabIndex = 0x2a;
            this.label51.Text = "Tự động Submit";
            this.btnSubmitAuto.DialogResult = DialogResult.Cancel;
            this.btnSubmitAuto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSubmitAuto.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSubmitAuto.Location = new Point(0x3f4, 0x12);
            this.btnSubmitAuto.Name = "btnSubmitAuto";
            this.btnSubmitAuto.Size = new Size(0x3f, 0x20);
            this.btnSubmitAuto.TabIndex = 9;
            this.btnSubmitAuto.Text = "Bắt Đầu";
            this.btnSubmitAuto.UseVisualStyleBackColor = true;
            this.btnSubmitAuto.Click += new EventHandler(this.btnSubmitAuto_Click);
            this.btnSubmitView.DialogResult = DialogResult.Cancel;
            this.btnSubmitView.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSubmitView.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSubmitView.Location = new Point(0x77, 0xc2);
            this.btnSubmitView.Name = "btnSubmitView";
            this.btnSubmitView.Size = new Size(0x61, 0x20);
            this.btnSubmitView.TabIndex = 6;
            this.btnSubmitView.Text = "Duyệt Web";
            this.btnSubmitView.UseVisualStyleBackColor = true;
            this.btnSubmitView.Click += new EventHandler(this.btnSubmitView_Click);
            this.btnSubmitNext.DialogResult = DialogResult.Cancel;
            this.btnSubmitNext.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSubmitNext.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSubmitNext.Location = new Point(0xde, 0x12);
            this.btnSubmitNext.Name = "btnSubmitNext";
            this.btnSubmitNext.Size = new Size(0x69, 0x1f);
            this.btnSubmitNext.TabIndex = 10;
            this.btnSubmitNext.Text = "Trang tiếp theo";
            this.btnSubmitNext.UseVisualStyleBackColor = true;
            this.btnSubmitNext.Click += new EventHandler(this.btnSubmitNext_Click);
            this.btnSubmitOK.DialogResult = DialogResult.Cancel;
            this.btnSubmitOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnSubmitOK.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnSubmitOK.Location = new Point(0x14d, 0x12);
            this.btnSubmitOK.Name = "btnSubmitOK";
            this.btnSubmitOK.Size = new Size(0x51, 0x1f);
            this.btnSubmitOK.TabIndex = 11;
            this.btnSubmitOK.Text = "Cập nhật";
            this.btnSubmitOK.UseVisualStyleBackColor = true;
            this.btnSubmitOK.Click += new EventHandler(this.btnSubmitOK_Click);
            this.txtSubmitAdd.BackColor = SystemColors.Control;
            this.txtSubmitAdd.Cursor = Cursors.Hand;
            this.txtSubmitAdd.Image = Resources.smethod_14();
            this.txtSubmitAdd.Location = new Point(0xc2, 0x2d);
            this.txtSubmitAdd.Name = "txtSubmitAdd";
            this.txtSubmitAdd.Size = new Size(0x16, 0x16);
            this.txtSubmitAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.txtSubmitAdd.TabIndex = 20;
            this.txtSubmitAdd.TabStop = false;
            this.txtSubmitAdd.Click += new EventHandler(this.txtSubmitAdd_Click);
            this.txtSubmitAddress.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSubmitAddress.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtSubmitAddress.Location = new Point(6, 0x89);
            this.txtSubmitAddress.Name = "txtSubmitAddress";
            this.txtSubmitAddress.Size = new Size(0xb6, 0x17);
            this.txtSubmitAddress.TabIndex = 5;
            this.txtSubmitAddress.KeyUp += new KeyEventHandler(this.txtSubmitAddress_KeyUp);
            this.btnSubmitSearch.BackColor = SystemColors.Control;
            this.btnSubmitSearch.Cursor = Cursors.Hand;
            this.btnSubmitSearch.Image = Resources.smethod_18();
            this.btnSubmitSearch.Location = new Point(0xc2, 0x89);
            this.btnSubmitSearch.Name = "btnSubmitSearch";
            this.btnSubmitSearch.Size = new Size(0x16, 0x16);
            this.btnSubmitSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnSubmitSearch.TabIndex = 0x25;
            this.btnSubmitSearch.TabStop = false;
            this.btnSubmitSearch.Click += new EventHandler(this.btnSubmitSearch_Click);
            this.btnSubmitDelete.BackColor = SystemColors.Control;
            this.btnSubmitDelete.Cursor = Cursors.Hand;
            this.btnSubmitDelete.Image = Resources.smethod_12();
            this.btnSubmitDelete.Location = new Point(0xa6, 0xa5);
            this.btnSubmitDelete.Name = "btnSubmitDelete";
            this.btnSubmitDelete.Size = new Size(0x16, 0x16);
            this.btnSubmitDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnSubmitDelete.TabIndex = 40;
            this.btnSubmitDelete.TabStop = false;
            this.btnSubmitDelete.Click += new EventHandler(this.btnSubmitDelete_Click);
            this.btnSubmitEdit.BackColor = SystemColors.Control;
            this.btnSubmitEdit.Cursor = Cursors.Hand;
            this.btnSubmitEdit.Image = Resources.smethod_15();
            this.btnSubmitEdit.Location = new Point(0x8a, 0xa5);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new Size(0x16, 0x16);
            this.btnSubmitEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnSubmitEdit.TabIndex = 0x27;
            this.btnSubmitEdit.TabStop = false;
            this.btnSubmitEdit.Click += new EventHandler(this.btnSubmitEdit_Click);
            this.btnAutoClick.DialogResult = DialogResult.Cancel;
            this.btnAutoClick.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAutoClick.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnAutoClick.Location = new Point(0x2e2, 0x12);
            this.btnAutoClick.Name = "btnAutoClick";
            this.btnAutoClick.Size = new Size(0x4a, 0x1f);
            this.btnAutoClick.TabIndex = 8;
            this.btnAutoClick.Text = "Auto Click";
            this.btnAutoClick.UseVisualStyleBackColor = true;
            this.btnAutoClick.Click += new EventHandler(this.btnAutoClick_Click);
            this.btnSubmitAdd.BackColor = SystemColors.Control;
            this.btnSubmitAdd.Cursor = Cursors.Hand;
            this.btnSubmitAdd.Image = Resources.smethod_14();
            this.btnSubmitAdd.Location = new Point(110, 0xa5);
            this.btnSubmitAdd.Name = "btnSubmitAdd";
            this.btnSubmitAdd.Size = new Size(0x16, 0x16);
            this.btnSubmitAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnSubmitAdd.TabIndex = 0x26;
            this.btnSubmitAdd.TabStop = false;
            this.btnSubmitAdd.Click += new EventHandler(this.btnSubmitAdd_Click);
            this.dtvSubmit.AllowUserToAddRows = false;
            this.dtvSubmit.AllowUserToDeleteRows = false;
            this.dtvSubmit.AllowUserToOrderColumns = true;
            style151.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvSubmit.AlternatingRowsDefaultCellStyle = style151;
            this.dtvSubmit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvSubmit.BackgroundColor = Color.White;
            this.dtvSubmit.BorderStyle = BorderStyle.None;
            style152.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style152.BackColor = SystemColors.Control;
            style152.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style152.ForeColor = SystemColors.WindowText;
            style152.SelectionBackColor = SystemColors.Highlight;
            style152.SelectionForeColor = SystemColors.HighlightText;
            style152.WrapMode = DataGridViewTriState.True;
            this.dtvSubmit.ColumnHeadersDefaultCellStyle = style152;
            this.dtvSubmit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSubmit.ColumnHeadersVisible = false;
            dataGridViewColumns = new DataGridViewColumn[] { this.SubmitID, this.SubmitURL, this.SubmitAttributeID };
            this.dtvSubmit.Columns.AddRange(dataGridViewColumns);
            style153.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style153.BackColor = SystemColors.Window;
            style153.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style153.ForeColor = Color.FromArgb(0, 0, 0x40);
            style153.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style153.SelectionForeColor = Color.White;
            style153.WrapMode = DataGridViewTriState.False;
            this.dtvSubmit.DefaultCellStyle = style153;
            this.dtvSubmit.Location = new Point(6, 0xe8);
            this.dtvSubmit.MultiSelect = false;
            this.dtvSubmit.Name = "dtvSubmit";
            this.dtvSubmit.ReadOnly = true;
            style154.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style154.BackColor = SystemColors.Control;
            style154.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style154.ForeColor = SystemColors.WindowText;
            style154.SelectionBackColor = SystemColors.HighlightText;
            style154.SelectionForeColor = SystemColors.HighlightText;
            style154.WrapMode = DataGridViewTriState.True;
            this.dtvSubmit.RowHeadersDefaultCellStyle = style154;
            this.dtvSubmit.RowHeadersWidth = 30;
            this.dtvSubmit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvSubmit.Size = new Size(210, 0x1aa);
            this.dtvSubmit.TabIndex = 7;
            this.dtvSubmit.CellClick += new DataGridViewCellEventHandler(this.dtvSubmit_CellClick);
            this.dtvSubmit.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvSubmit_CellDoubleClick);
            this.dtvSubmit.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvSubmit_RowPostPaint);
            this.SubmitID.HeaderText = "ID";
            this.SubmitID.Name = "SubmitID";
            this.SubmitID.ReadOnly = true;
            this.SubmitID.Visible = false;
            this.SubmitURL.FillWeight = 290.4007f;
            this.SubmitURL.HeaderText = "Đường dẫn";
            this.SubmitURL.Name = "SubmitURL";
            this.SubmitURL.ReadOnly = true;
            this.SubmitURL.Resizable = DataGridViewTriState.True;
            this.SubmitAttributeID.HeaderText = "AttributeID";
            this.SubmitAttributeID.Name = "SubmitAttributeID";
            this.SubmitAttributeID.ReadOnly = true;
            this.SubmitAttributeID.Visible = false;
            this.cbAuto.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbAuto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbAuto.FlatStyle = FlatStyle.Popup;
            this.cbAuto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbAuto.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbAuto.FormattingEnabled = true;
            this.cbAuto.Location = new Point(490, 0x16);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new Size(0xa3, 0x18);
            this.cbAuto.TabIndex = 1;
            this.cbSubmitCate.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbSubmitCate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSubmitCate.FlatStyle = FlatStyle.Popup;
            this.cbSubmitCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbSubmitCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbSubmitCate.FormattingEnabled = true;
            this.cbSubmitCate.Location = new Point(6, 0x2d);
            this.cbSubmitCate.Name = "cbSubmitCate";
            this.cbSubmitCate.Size = new Size(0xb6, 0x18);
            this.cbSubmitCate.TabIndex = 3;
            this.cbSubmitCate.SelectionChangeCommitted += new EventHandler(this.cbSubmitCate_SelectionChangeCommitted);
            this.cbAttributeCate.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbAttributeCate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbAttributeCate.FlatStyle = FlatStyle.Popup;
            this.cbAttributeCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbAttributeCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbAttributeCate.FormattingEnabled = true;
            this.cbAttributeCate.Location = new Point(6, 0x5b);
            this.cbAttributeCate.Name = "cbAttributeCate";
            this.cbAttributeCate.Size = new Size(0xb6, 0x18);
            this.cbAttributeCate.TabIndex = 4;
            this.label11.AutoSize = true;
            this.label11.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label11.Location = new Point(420, 0x1a);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x40, 0x10);
            this.label11.TabIndex = 10;
            this.label11.Text = "Auto Click";
            this.label30.AutoSize = true;
            this.label30.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label30.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label30.Location = new Point(6, 0xa9);
            this.label30.Name = "label30";
            this.label30.Size = new Size(0x62, 0x10);
            this.label30.TabIndex = 10;
            this.label30.Text = "Th\x00eam|Sửa|Xo\x00e1";
            this.label18.AutoSize = true;
            this.label18.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label18.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label18.Location = new Point(3, 0x76);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x47, 0x10);
            this.label18.TabIndex = 10;
            this.label18.Text = "Đường dẫn";
            this.label15.AutoSize = true;
            this.label15.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label15.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label15.Location = new Point(3, 0x1a);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x81, 0x10);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nh\x00f3m danh s\x00e1ch Link";
            this.lbnhom.AutoSize = true;
            this.lbnhom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbnhom.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.lbnhom.Location = new Point(3, 0x48);
            this.lbnhom.Name = "lbnhom";
            this.lbnhom.Size = new Size(150, 0x10);
            this.lbnhom.TabIndex = 10;
            this.lbnhom.Text = "Thuộc t\x00ednh nhập Website";
            this.btnSubmitAttribute.BackColor = SystemColors.Control;
            this.btnSubmitAttribute.Cursor = Cursors.Hand;
            this.btnSubmitAttribute.Image = Resources.smethod_14();
            this.btnSubmitAttribute.Location = new Point(0xc2, 0x5b);
            this.btnSubmitAttribute.Name = "btnSubmitAttribute";
            this.btnSubmitAttribute.Size = new Size(0x16, 0x18);
            this.btnSubmitAttribute.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnSubmitAttribute.TabIndex = 0x25;
            this.btnSubmitAttribute.TabStop = false;
            this.btnSubmitAttribute.Click += new EventHandler(this.btnSubmitAttribute_Click);
            this.tbArticle.Controls.Add(this.groupBox12);
            this.tbArticle.Controls.Add(this.groupBox23);
            this.tbArticle.Location = new Point(4, 0x3d);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new Size(0x444, 670);
            this.tbArticle.TabIndex = 9;
            this.tbArticle.Text = "Quản l\x00fd Marketing";
            this.tbArticle.UseVisualStyleBackColor = true;
            this.tbArticle.Enter += new EventHandler(this.tbArticle_Enter);
            this.groupBox12.Controls.Add(this.btnArticleSearch);
            this.groupBox12.Controls.Add(this.btnArticleRefresh);
            this.groupBox12.Controls.Add(this.numAuto);
            this.groupBox12.Controls.Add(this.label39);
            this.groupBox12.Controls.Add(this.label52);
            this.groupBox12.Controls.Add(this.ckFollow);
            this.groupBox12.Controls.Add(this.btnArticleFollow);
            this.groupBox12.Controls.Add(this.btnArticleCheck);
            this.groupBox12.Controls.Add(this.btnArticleDelete);
            this.groupBox12.Controls.Add(this.btnArticleEdit);
            this.groupBox12.Controls.Add(this.label40);
            this.groupBox12.Controls.Add(this.btnArticleAdd);
            this.groupBox12.Controls.Add(this.dtvArticle);
            this.groupBox12.Controls.Add(this.txtArticleLink);
            this.groupBox12.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox12.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox12.Location = new Point(0x108, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new Size(0x337, 0x296);
            this.groupBox12.TabIndex = 0x18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Danh s\x00e1ch b\x00e0i viết";
            this.btnArticleSearch.BackColor = SystemColors.Control;
            this.btnArticleSearch.Cursor = Cursors.Hand;
            this.btnArticleSearch.Image = Resources.smethod_18();
            this.btnArticleSearch.Location = new Point(0x231, 20);
            this.btnArticleSearch.Name = "btnArticleSearch";
            this.btnArticleSearch.Size = new Size(0x16, 0x16);
            this.btnArticleSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnArticleSearch.TabIndex = 0x23;
            this.btnArticleSearch.TabStop = false;
            this.btnArticleSearch.Click += new EventHandler(this.btnArticleSearch_Click);
            this.btnArticleRefresh.DialogResult = DialogResult.Cancel;
            this.btnArticleRefresh.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnArticleRefresh.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnArticleRefresh.Location = new Point(750, 0x12);
            this.btnArticleRefresh.Name = "btnArticleRefresh";
            this.btnArticleRefresh.Size = new Size(0x44, 0x1b);
            this.btnArticleRefresh.TabIndex = 5;
            this.btnArticleRefresh.Text = "L\x00e0m Mới";
            this.btnArticleRefresh.UseVisualStyleBackColor = true;
            this.btnArticleRefresh.Click += new EventHandler(this.btnArticleRefresh_Click);
            this.numAuto.Increment = new decimal(new int[] { 5 });
            this.numAuto.Location = new Point(80, 0x33);
            this.numAuto.Maximum = new decimal(new int[] { 0xe10 });
            this.numAuto.Name = "numAuto";
            this.numAuto.Size = new Size(0x45, 0x16);
            this.numAuto.TabIndex = 6;
            this.numAuto.TextAlign = HorizontalAlignment.Center;
            this.numAuto.Value = new decimal(new int[] { 5 });
            this.label39.AutoSize = true;
            this.label39.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label39.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label39.Location = new Point(0x9b, 0x35);
            this.label39.Name = "label39";
            this.label39.Size = new Size(0x21, 0x10);
            this.label39.TabIndex = 0x20;
            this.label39.Text = "ph\x00fat";
            this.label52.AutoSize = true;
            this.label52.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label52.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label52.Location = new Point(4, 0x35);
            this.label52.Name = "label52";
            this.label52.Size = new Size(70, 0x10);
            this.label52.TabIndex = 0x1f;
            this.label52.Text = "Auto check";
            this.ckFollow.AutoSize = true;
            this.ckFollow.Location = new Point(0x2cf, 0x37);
            this.ckFollow.Name = "ckFollow";
            this.ckFollow.Size = new Size(0x4b, 0x12);
            this.ckFollow.TabIndex = 8;
            this.ckFollow.Text = "Theo d\x00f5i";
            this.ckFollow.UseVisualStyleBackColor = true;
            this.ckFollow.CheckedChanged += new EventHandler(this.ckFollow_CheckedChanged);
            this.btnArticleFollow.DialogResult = DialogResult.Cancel;
            this.btnArticleFollow.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnArticleFollow.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnArticleFollow.Location = new Point(0xc2, 0x2f);
            this.btnArticleFollow.Name = "btnArticleFollow";
            this.btnArticleFollow.Size = new Size(0x44, 0x1b);
            this.btnArticleFollow.TabIndex = 7;
            this.btnArticleFollow.Text = "Theo D\x00f5i";
            this.btnArticleFollow.UseVisualStyleBackColor = true;
            this.btnArticleFollow.Click += new EventHandler(this.btnArticleFollow_Click);
            this.btnArticleCheck.DialogResult = DialogResult.Cancel;
            this.btnArticleCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnArticleCheck.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnArticleCheck.Location = new Point(0x2a1, 0x12);
            this.btnArticleCheck.Name = "btnArticleCheck";
            this.btnArticleCheck.Size = new Size(0x47, 0x1b);
            this.btnArticleCheck.TabIndex = 4;
            this.btnArticleCheck.Text = "Kiểm Tra";
            this.btnArticleCheck.UseVisualStyleBackColor = true;
            this.btnArticleCheck.Click += new EventHandler(this.btnArticleCheck_Click);
            this.btnArticleDelete.BackColor = SystemColors.Control;
            this.btnArticleDelete.Cursor = Cursors.Hand;
            this.btnArticleDelete.Image = Resources.smethod_12();
            this.btnArticleDelete.Location = new Point(0x285, 20);
            this.btnArticleDelete.Name = "btnArticleDelete";
            this.btnArticleDelete.Size = new Size(0x16, 0x16);
            this.btnArticleDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnArticleDelete.TabIndex = 0x16;
            this.btnArticleDelete.TabStop = false;
            this.btnArticleDelete.Click += new EventHandler(this.btnArticleDelete_Click);
            this.btnArticleEdit.BackColor = SystemColors.Control;
            this.btnArticleEdit.Cursor = Cursors.Hand;
            this.btnArticleEdit.Image = Resources.smethod_15();
            this.btnArticleEdit.Location = new Point(0x269, 20);
            this.btnArticleEdit.Name = "btnArticleEdit";
            this.btnArticleEdit.Size = new Size(0x16, 0x16);
            this.btnArticleEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnArticleEdit.TabIndex = 0x15;
            this.btnArticleEdit.TabStop = false;
            this.btnArticleEdit.Click += new EventHandler(this.btnArticleEdit_Click);
            this.label40.AutoSize = true;
            this.label40.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label40.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label40.Location = new Point(6, 0x17);
            this.label40.Name = "label40";
            this.label40.Size = new Size(0x34, 0x10);
            this.label40.TabIndex = 10;
            this.label40.Text = "Li\x00ean kết";
            this.btnArticleAdd.BackColor = SystemColors.Control;
            this.btnArticleAdd.Cursor = Cursors.Hand;
            this.btnArticleAdd.Image = Resources.smethod_14();
            this.btnArticleAdd.Location = new Point(0x24d, 20);
            this.btnArticleAdd.Name = "btnArticleAdd";
            this.btnArticleAdd.Size = new Size(0x16, 0x16);
            this.btnArticleAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnArticleAdd.TabIndex = 20;
            this.btnArticleAdd.TabStop = false;
            this.btnArticleAdd.Click += new EventHandler(this.btnArticleAdd_Click);
            this.dtvArticle.AllowUserToAddRows = false;
            this.dtvArticle.AllowUserToDeleteRows = false;
            this.dtvArticle.AllowUserToOrderColumns = true;
            style155.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvArticle.AlternatingRowsDefaultCellStyle = style155;
            this.dtvArticle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvArticle.BackgroundColor = Color.White;
            this.dtvArticle.BorderStyle = BorderStyle.None;
            style156.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style156.BackColor = SystemColors.Control;
            style156.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style156.ForeColor = SystemColors.WindowText;
            style156.SelectionBackColor = SystemColors.Highlight;
            style156.SelectionForeColor = SystemColors.HighlightText;
            style156.WrapMode = DataGridViewTriState.True;
            this.dtvArticle.ColumnHeadersDefaultCellStyle = style156;
            this.dtvArticle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn6, this.ArticleLink, this.Column6, this.Column4, this.Column5, this.ArticleAuthor };
            this.dtvArticle.Columns.AddRange(dataGridViewColumns);
            this.dtvArticle.ContextMenuStrip = this.mnuArticle;
            style157.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style157.BackColor = SystemColors.Window;
            style157.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style157.ForeColor = Color.FromArgb(0, 0, 0x40);
            style157.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style157.SelectionForeColor = Color.White;
            style157.WrapMode = DataGridViewTriState.False;
            this.dtvArticle.DefaultCellStyle = style157;
            this.dtvArticle.Location = new Point(6, 80);
            this.dtvArticle.MultiSelect = false;
            this.dtvArticle.Name = "dtvArticle";
            this.dtvArticle.ReadOnly = true;
            style158.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style158.BackColor = SystemColors.Control;
            style158.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style158.ForeColor = SystemColors.WindowText;
            style158.SelectionBackColor = SystemColors.HighlightText;
            style158.SelectionForeColor = SystemColors.HighlightText;
            style158.WrapMode = DataGridViewTriState.True;
            this.dtvArticle.RowHeadersDefaultCellStyle = style158;
            this.dtvArticle.RowHeadersWidth = 30;
            this.dtvArticle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvArticle.Size = new Size(0x32c, 0x240);
            this.dtvArticle.TabIndex = 9;
            this.dtvArticle.CellClick += new DataGridViewCellEventHandler(this.dtvArticle_CellClick);
            this.dtvArticle.CellContentClick += new DataGridViewCellEventHandler(this.dtvArticle_CellContentClick);
            this.dtvArticle.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvArticle_RowPostPaint);
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.ArticleLink.FillWeight = 290.4007f;
            this.ArticleLink.HeaderText = "Li\x00ean kết";
            this.ArticleLink.Name = "ArticleLink";
            this.ArticleLink.ReadOnly = true;
            this.ArticleLink.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Column6.FillWeight = 50.53364f;
            this.Column6.HeaderText = "Phản hồi";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = DataGridViewTriState.True;
            this.Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            style159.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = style159;
            this.Column4.FillWeight = 42.26708f;
            this.Column4.HeaderText = "Trước";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            style160.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = style160;
            this.Column5.FillWeight = 40.65647f;
            this.Column5.HeaderText = "Sau";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.ArticleAuthor.FillWeight = 76.14213f;
            this.ArticleAuthor.HeaderText = "Theo d\x00f5i";
            this.ArticleAuthor.Name = "ArticleAuthor";
            this.ArticleAuthor.ReadOnly = true;
            this.ArticleAuthor.Resizable = DataGridViewTriState.True;
            this.ArticleAuthor.SortMode = DataGridViewColumnSortMode.Automatic;
            this.txtArticleLink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtArticleLink.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtArticleLink.Location = new Point(80, 20);
            this.txtArticleLink.Name = "txtArticleLink";
            this.txtArticleLink.Size = new Size(0x1db, 0x17);
            this.txtArticleLink.TabIndex = 3;
            this.groupBox23.Controls.Add(this.btnArticleCateSearch);
            this.groupBox23.Controls.Add(this.btnArticleCateAdd);
            this.groupBox23.Controls.Add(this.dtvArticleCate);
            this.groupBox23.Controls.Add(this.txtArticleCate);
            this.groupBox23.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox23.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox23.Location = new Point(6, 3);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new Size(0xfc, 0x296);
            this.groupBox23.TabIndex = 0x17;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Danh mục";
            this.btnArticleCateSearch.BackColor = SystemColors.Control;
            this.btnArticleCateSearch.Cursor = Cursors.Hand;
            this.btnArticleCateSearch.Image = Resources.smethod_18();
            this.btnArticleCateSearch.Location = new Point(0xc4, 20);
            this.btnArticleCateSearch.Name = "btnArticleCateSearch";
            this.btnArticleCateSearch.Size = new Size(0x16, 0x16);
            this.btnArticleCateSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnArticleCateSearch.TabIndex = 0x23;
            this.btnArticleCateSearch.TabStop = false;
            this.btnArticleCateSearch.Click += new EventHandler(this.btnArticleCateSearch_Click);
            this.btnArticleCateAdd.BackColor = SystemColors.Control;
            this.btnArticleCateAdd.Cursor = Cursors.Hand;
            this.btnArticleCateAdd.Image = Resources.smethod_14();
            this.btnArticleCateAdd.Location = new Point(0xe0, 20);
            this.btnArticleCateAdd.Name = "btnArticleCateAdd";
            this.btnArticleCateAdd.Size = new Size(0x16, 0x16);
            this.btnArticleCateAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnArticleCateAdd.TabIndex = 20;
            this.btnArticleCateAdd.TabStop = false;
            this.btnArticleCateAdd.Click += new EventHandler(this.btnArticleCateAdd_Click);
            this.dtvArticleCate.AllowUserToAddRows = false;
            this.dtvArticleCate.AllowUserToDeleteRows = false;
            this.dtvArticleCate.AllowUserToOrderColumns = true;
            style161.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvArticleCate.AlternatingRowsDefaultCellStyle = style161;
            this.dtvArticleCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvArticleCate.BackgroundColor = Color.White;
            this.dtvArticleCate.BorderStyle = BorderStyle.None;
            style162.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style162.BackColor = SystemColors.Control;
            style162.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style162.ForeColor = SystemColors.WindowText;
            style162.SelectionBackColor = SystemColors.Highlight;
            style162.SelectionForeColor = SystemColors.HighlightText;
            style162.WrapMode = DataGridViewTriState.True;
            this.dtvArticleCate.ColumnHeadersDefaultCellStyle = style162;
            this.dtvArticleCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn13, this.dataGridViewTextBoxColumn14 };
            this.dtvArticleCate.Columns.AddRange(dataGridViewColumns);
            style163.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style163.BackColor = SystemColors.Window;
            style163.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style163.ForeColor = Color.FromArgb(0, 0, 0x40);
            style163.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style163.SelectionForeColor = Color.White;
            style163.WrapMode = DataGridViewTriState.False;
            this.dtvArticleCate.DefaultCellStyle = style163;
            this.dtvArticleCate.Location = new Point(6, 0x31);
            this.dtvArticleCate.MultiSelect = false;
            this.dtvArticleCate.Name = "dtvArticleCate";
            this.dtvArticleCate.ReadOnly = true;
            style164.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style164.BackColor = SystemColors.Control;
            style164.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style164.ForeColor = SystemColors.WindowText;
            style164.SelectionBackColor = SystemColors.HighlightText;
            style164.SelectionForeColor = SystemColors.HighlightText;
            style164.WrapMode = DataGridViewTriState.True;
            this.dtvArticleCate.RowHeadersDefaultCellStyle = style164;
            this.dtvArticleCate.RowHeadersWidth = 30;
            this.dtvArticleCate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvArticleCate.Size = new Size(240, 0x25f);
            this.dtvArticleCate.TabIndex = 2;
            this.dtvArticleCate.CellClick += new DataGridViewCellEventHandler(this.dtvArticleCate_CellClick);
            this.dtvArticleCate.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvArticleCate_RowPostPaint);
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn14.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.txtArticleCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtArticleCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtArticleCate.Location = new Point(6, 20);
            this.txtArticleCate.Name = "txtArticleCate";
            this.txtArticleCate.Size = new Size(0xb8, 0x17);
            this.txtArticleCate.TabIndex = 1;
            this.tbRegex.Controls.Add(this.groupBox35);
            this.tbRegex.Controls.Add(this.groupBox31);
            this.tbRegex.Controls.Add(this.groupBox7);
            this.tbRegex.Location = new Point(4, 0x3d);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new Size(0x444, 670);
            this.tbRegex.TabIndex = 0x12;
            this.tbRegex.Text = "Lọc nội dung";
            this.tbRegex.UseVisualStyleBackColor = true;
            this.tbRegex.Enter += new EventHandler(this.tbRegex_Enter);
            this.groupBox35.Controls.Add(this.RegexResultSave);
            this.groupBox35.Controls.Add(this.btnRegexFilterLink);
            this.groupBox35.Controls.Add(this.btnRegexFilterEmail);
            this.groupBox35.Controls.Add(this.numericRegexDelay);
            this.groupBox35.Controls.Add(this.btnRegexFilterYahoo);
            this.groupBox35.Controls.Add(this.btnRegexReplace);
            this.groupBox35.Controls.Add(this.rtbRegexResult);
            this.groupBox35.Controls.Add(this.txtReplaceContent);
            this.groupBox35.Controls.Add(this.btnRegexGetContentByRegex);
            this.groupBox35.Controls.Add(this.txtRegexRegex);
            this.groupBox35.Controls.Add(this.label75);
            this.groupBox35.Controls.Add(this.cbRegexType);
            this.groupBox35.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox35.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox35.Location = new Point(0x233, 3);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new Size(0x209, 0x296);
            this.groupBox35.TabIndex = 0x27;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Lọc nội dung từ Website";
            this.RegexResultSave.BackColor = Color.Transparent;
            this.RegexResultSave.Cursor = Cursors.Hand;
            this.RegexResultSave.Image = Resources.smethod_7();
            this.RegexResultSave.Location = new Point(0x1d8, 0x59);
            this.RegexResultSave.Name = "RegexResultSave";
            this.RegexResultSave.Size = new Size(0x16, 0x16);
            this.RegexResultSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.RegexResultSave.TabIndex = 0x1f;
            this.RegexResultSave.TabStop = false;
            this.RegexResultSave.Click += new EventHandler(this.RegexResultSave_Click);
            this.btnRegexFilterLink.DialogResult = DialogResult.Cancel;
            this.btnRegexFilterLink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRegexFilterLink.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRegexFilterLink.Location = new Point(6, 0x270);
            this.btnRegexFilterLink.Name = "btnRegexFilterLink";
            this.btnRegexFilterLink.Size = new Size(0xa6, 0x20);
            this.btnRegexFilterLink.TabIndex = 4;
            this.btnRegexFilterLink.Text = "Lọc Link tr\x00f9ng lặp";
            this.btnRegexFilterLink.UseVisualStyleBackColor = true;
            this.btnRegexFilterLink.Click += new EventHandler(this.btnRegexFilterLink_Click);
            this.btnRegexFilterEmail.DialogResult = DialogResult.Cancel;
            this.btnRegexFilterEmail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRegexFilterEmail.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRegexFilterEmail.Location = new Point(0xb1, 0x270);
            this.btnRegexFilterEmail.Name = "btnRegexFilterEmail";
            this.btnRegexFilterEmail.Size = new Size(0xa6, 0x20);
            this.btnRegexFilterEmail.TabIndex = 4;
            this.btnRegexFilterEmail.Text = "Lọc Email tr\x00f9ng lặp";
            this.btnRegexFilterEmail.UseVisualStyleBackColor = true;
            this.btnRegexFilterEmail.Click += new EventHandler(this.btnRegexFilterEmail_Click);
            this.numericRegexDelay.Location = new Point(370, 20);
            this.numericRegexDelay.Maximum = new decimal(new int[] { 0x186a0 });
            this.numericRegexDelay.Minimum = new decimal(new int[] { 200 });
            this.numericRegexDelay.Name = "numericRegexDelay";
            this.numericRegexDelay.Size = new Size(0x36, 0x16);
            this.numericRegexDelay.TabIndex = 8;
            this.numericRegexDelay.TextAlign = HorizontalAlignment.Center;
            this.numericRegexDelay.Value = new decimal(new int[] { 0x3e8 });
            this.btnRegexFilterYahoo.DialogResult = DialogResult.Cancel;
            this.btnRegexFilterYahoo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRegexFilterYahoo.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRegexFilterYahoo.Location = new Point(0x15d, 0x270);
            this.btnRegexFilterYahoo.Name = "btnRegexFilterYahoo";
            this.btnRegexFilterYahoo.Size = new Size(0xa6, 0x20);
            this.btnRegexFilterYahoo.TabIndex = 4;
            this.btnRegexFilterYahoo.Text = "Lọc Nick Yahoo từ Email";
            this.btnRegexFilterYahoo.UseVisualStyleBackColor = true;
            this.btnRegexFilterYahoo.Click += new EventHandler(this.btnRegexFilterYahoo_Click);
            this.btnRegexReplace.DialogResult = DialogResult.Cancel;
            this.btnRegexReplace.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRegexReplace.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRegexReplace.Location = new Point(0x1b0, 50);
            this.btnRegexReplace.Name = "btnRegexReplace";
            this.btnRegexReplace.Size = new Size(0x51, 0x1b);
            this.btnRegexReplace.TabIndex = 11;
            this.btnRegexReplace.Text = "Thay thế";
            this.btnRegexReplace.UseVisualStyleBackColor = true;
            this.btnRegexReplace.Click += new EventHandler(this.btnRegexReplace_Click);
            this.rtbRegexResult.BorderStyle = BorderStyle.None;
            this.rtbRegexResult.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.rtbRegexResult.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.rtbRegexResult.Location = new Point(6, 0x51);
            this.rtbRegexResult.Name = "rtbRegexResult";
            this.rtbRegexResult.Size = new Size(0x1fd, 0x219);
            this.rtbRegexResult.TabIndex = 12;
            this.rtbRegexResult.Text = "";
            this.rtbRegexResult.LinkClicked += new LinkClickedEventHandler(this.rtbRegexResult_LinkClicked);
            this.txtReplaceContent.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtReplaceContent.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtReplaceContent.Location = new Point(0x22, 0x34);
            this.txtReplaceContent.Name = "txtReplaceContent";
            this.txtReplaceContent.Size = new Size(0x188, 0x17);
            this.txtReplaceContent.TabIndex = 9;
            this.btnRegexGetContentByRegex.DialogResult = DialogResult.Cancel;
            this.btnRegexGetContentByRegex.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRegexGetContentByRegex.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRegexGetContentByRegex.Location = new Point(0x1b0, 0x12);
            this.btnRegexGetContentByRegex.Name = "btnRegexGetContentByRegex";
            this.btnRegexGetContentByRegex.Size = new Size(0x53, 0x1b);
            this.btnRegexGetContentByRegex.TabIndex = 10;
            this.btnRegexGetContentByRegex.Text = "Thực hiện";
            this.btnRegexGetContentByRegex.UseVisualStyleBackColor = true;
            this.btnRegexGetContentByRegex.Click += new EventHandler(this.btnRegexGetContentByRegex_Click);
            this.txtRegexRegex.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtRegexRegex.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtRegexRegex.Location = new Point(0x63, 20);
            this.txtRegexRegex.Name = "txtRegexRegex";
            this.txtRegexRegex.Size = new Size(0x109, 0x17);
            this.txtRegexRegex.TabIndex = 7;
            this.label75.AutoSize = true;
            this.label75.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label75.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label75.Location = new Point(4, 0x37);
            this.label75.Name = "label75";
            this.label75.Size = new Size(0x18, 0x10);
            this.label75.TabIndex = 30;
            this.label75.Text = "Url";
            this.cbRegexType.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbRegexType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbRegexType.FlatStyle = FlatStyle.Popup;
            this.cbRegexType.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbRegexType.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbRegexType.FormattingEnabled = true;
            items = new object[] { "Email", "Regex" };
            this.cbRegexType.Items.AddRange(items);
            this.cbRegexType.Location = new Point(7, 20);
            this.cbRegexType.Name = "cbRegexType";
            this.cbRegexType.Size = new Size(0x56, 0x18);
            this.cbRegexType.TabIndex = 6;
            this.groupBox31.Controls.Add(this.btnRegexUrlSave);
            this.groupBox31.Controls.Add(this.rtbRegexURL);
            this.groupBox31.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox31.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox31.Location = new Point(8, 0x44);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new Size(0x225, 0x255);
            this.groupBox31.TabIndex = 0x24;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Danh s\x00e1ch URL";
            this.btnRegexUrlSave.BackColor = Color.Transparent;
            this.btnRegexUrlSave.Cursor = Cursors.Hand;
            this.btnRegexUrlSave.Image = Resources.smethod_7();
            this.btnRegexUrlSave.Location = new Point(0x1f2, 0x18);
            this.btnRegexUrlSave.Name = "btnRegexUrlSave";
            this.btnRegexUrlSave.Size = new Size(0x16, 0x16);
            this.btnRegexUrlSave.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnRegexUrlSave.TabIndex = 14;
            this.btnRegexUrlSave.TabStop = false;
            this.btnRegexUrlSave.Click += new EventHandler(this.btnRegexUrlSave_Click);
            this.rtbRegexURL.BorderStyle = BorderStyle.None;
            this.rtbRegexURL.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.rtbRegexURL.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.rtbRegexURL.Location = new Point(6, 15);
            this.rtbRegexURL.Name = "rtbRegexURL";
            this.rtbRegexURL.Size = new Size(0x219, 0x240);
            this.rtbRegexURL.TabIndex = 5;
            this.rtbRegexURL.Text = "";
            this.rtbRegexURL.LinkClicked += new LinkClickedEventHandler(this.rtbRegexURL_LinkClicked);
            this.groupBox7.Controls.Add(this.btnRegexGetSource);
            this.groupBox7.Controls.Add(this.btnRegexGetLink);
            this.groupBox7.Controls.Add(this.numericRegexTo);
            this.groupBox7.Controls.Add(this.numericRegexFrom);
            this.groupBox7.Controls.Add(this.txtRegexURL);
            this.groupBox7.Controls.Add(this.label76);
            this.groupBox7.Controls.Add(this.label69);
            this.groupBox7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox7.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox7.Location = new Point(8, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new Size(0x225, 0x3b);
            this.groupBox7.TabIndex = 0x20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tạo URL tăng dần";
            this.btnRegexGetSource.DialogResult = DialogResult.Cancel;
            this.btnRegexGetSource.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRegexGetSource.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRegexGetSource.Location = new Point(0x1cd, 0x13);
            this.btnRegexGetSource.Name = "btnRegexGetSource";
            this.btnRegexGetSource.Size = new Size(0x52, 0x1b);
            this.btnRegexGetSource.TabIndex = 4;
            this.btnRegexGetSource.Text = "Get Source";
            this.btnRegexGetSource.UseVisualStyleBackColor = true;
            this.btnRegexGetSource.Click += new EventHandler(this.btnRegexGetSource_Click);
            this.btnRegexGetLink.DialogResult = DialogResult.Cancel;
            this.btnRegexGetLink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRegexGetLink.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnRegexGetLink.Location = new Point(0x17d, 0x13);
            this.btnRegexGetLink.Name = "btnRegexGetLink";
            this.btnRegexGetLink.Size = new Size(0x4a, 0x1b);
            this.btnRegexGetLink.TabIndex = 4;
            this.btnRegexGetLink.Text = "Thực hiện";
            this.btnRegexGetLink.UseVisualStyleBackColor = true;
            this.btnRegexGetLink.Click += new EventHandler(this.btnRegexGetLink_Click);
            this.numericRegexTo.Location = new Point(0x14b, 0x15);
            this.numericRegexTo.Maximum = new decimal(new int[] { 0x186a0 });
            this.numericRegexTo.Name = "numericRegexTo";
            this.numericRegexTo.Size = new Size(0x2c, 0x16);
            this.numericRegexTo.TabIndex = 3;
            this.numericRegexTo.TextAlign = HorizontalAlignment.Center;
            this.numericRegexTo.Value = new decimal(new int[] { 2 });
            this.numericRegexFrom.Location = new Point(0x10f, 0x15);
            this.numericRegexFrom.Maximum = new decimal(new int[] { 0x186a0 });
            this.numericRegexFrom.Name = "numericRegexFrom";
            this.numericRegexFrom.Size = new Size(0x2c, 0x16);
            this.numericRegexFrom.TabIndex = 2;
            this.numericRegexFrom.TextAlign = HorizontalAlignment.Center;
            this.numericRegexFrom.Value = new decimal(new int[] { 1 });
            this.txtRegexURL.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtRegexURL.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtRegexURL.Location = new Point(0x29, 0x15);
            this.txtRegexURL.Name = "txtRegexURL";
            this.txtRegexURL.Size = new Size(0xe0, 0x17);
            this.txtRegexURL.TabIndex = 1;
            this.label76.AutoSize = true;
            this.label76.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label76.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label76.Location = new Point(0x13f, 0x19);
            this.label76.Name = "label76";
            this.label76.Size = new Size(13, 0x10);
            this.label76.TabIndex = 30;
            this.label76.Text = "-";
            this.label69.AutoSize = true;
            this.label69.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label69.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label69.Location = new Point(5, 0x18);
            this.label69.Name = "label69";
            this.label69.Size = new Size(30, 0x10);
            this.label69.TabIndex = 30;
            this.label69.Text = "URL";
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new Size(0x17, 0x17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(0x17, 0x17);
            this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
            this.notifyIcon_0.ContextMenuStrip = this.mnuHide;
            this.notifyIcon_0.Icon = (Icon) manager.GetObject("notiHide.Icon");
            this.notifyIcon_0.Text = "iSEO - Phần mềm SEO";
            this.notifyIcon_0.Visible = true;
            this.notifyIcon_0.BalloonTipClicked += new EventHandler(this.notifyIcon_0_BalloonTipClicked);
            this.notifyIcon_0.MouseDoubleClick += new MouseEventHandler(this.notifyIcon_0_MouseDoubleClick);
            toolStripItems = new ToolStripItem[] { this.btnNotiShow, this.toolStripSeparator1, this.btnNotiExit };
            this.mnuHide.Items.AddRange(toolStripItems);
            this.mnuHide.Name = "mnuHide";
            this.mnuHide.Size = new Size(0x7d, 0x36);
            this.btnNotiShow.Image = Resources.smethod_5();
            this.btnNotiShow.Name = "btnNotiShow";
            this.btnNotiShow.Size = new Size(0x7c, 0x16);
            this.btnNotiShow.Text = "Mở rộng";
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(0x79, 6);
            this.btnNotiExit.Image = Resources.smethod_4();
            this.btnNotiExit.Name = "btnNotiExit";
            this.btnNotiExit.Size = new Size(0x7c, 0x16);
            this.btnNotiExit.Text = "Tho\x00e1t";
            this.btnNotiExit.Click += new EventHandler(this.btnExit_Click);
            this.timer_2.Interval = 0x1388;
            this.timer_2.Tick += new EventHandler(this.timer_2_Tick);
            this.picLoader.BackColor = SystemColors.AppWorkspace;
            this.picLoader.Image = Resources.smethod_19();
            this.picLoader.Location = new Point(0x376, 2);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new Size(0xd3, 0x12);
            this.picLoader.SizeMode = PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 5;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            this.toolBar.BackColor = Color.SteelBlue;
            this.toolBar.BackgroundImage = Resources.smethod_20();
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            toolStripItems = new ToolStripItem[] { this.btnExit, this.btnHide, this.btnInfo, this.toolStripLabel3, this.toolStripSeparator2, this.lbSupport, this.toolStripSeparator3, this.lbUpdate };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x44c, 0x19);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolBar";
            this.toolBar.MouseDown += new MouseEventHandler(this.toolBar_MouseDown);
            this.toolBar.MouseMove += new MouseEventHandler(this.toolBar_MouseMove);
            this.toolBar.MouseUp += new MouseEventHandler(this.toolBar_MouseUp);
            this.btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = Resources.smethod_4();
            this.btnExit.ImageTransparentColor = Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x17, 0x16);
            this.btnExit.Text = "toolStripButton1";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnHide.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btnHide.Image = Resources.smethod_5();
            this.btnHide.ImageTransparentColor = Color.Magenta;
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new Size(0x17, 0x16);
            this.btnHide.Text = "toolStripButton1";
            this.btnHide.Click += new EventHandler(this.btnHide_Click);
            this.btnInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = Resources.smethod_13();
            this.btnInfo.ImageTransparentColor = Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new Size(0x17, 0x16);
            this.btnInfo.Text = "toolStripButton1";
            this.btnInfo.Click += new EventHandler(this.btnInfo_Click);
            this.toolStripLabel3.BackColor = Color.Transparent;
            this.toolStripLabel3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.toolStripLabel3.ForeColor = Color.White;
            this.toolStripLabel3.LinkColor = Color.FromArgb(0, 0, 0xff);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new Size(0xbb, 0x16);
            this.toolStripLabel3.Text = "Phần mềm SEO số 1 Việt Nam";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(6, 0x19);
            this.lbSupport.BackColor = Color.Transparent;
            this.lbSupport.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbSupport.ForeColor = Color.Yellow;
            this.lbSupport.IsLink = true;
            this.lbSupport.LinkColor = Color.Yellow;
            this.lbSupport.Name = "lbSupport";
            this.lbSupport.Size = new Size(0x69, 0x16);
            this.lbSupport.Text = "Video hướng dẫn";
            this.lbSupport.Click += new EventHandler(this.lbUpdate_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(6, 0x19);
            this.lbUpdate.BackColor = Color.Transparent;
            this.lbUpdate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbUpdate.ForeColor = Color.Yellow;
            this.lbUpdate.IsLink = true;
            this.lbUpdate.LinkColor = Color.Yellow;
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new Size(0x4a, 0x16);
            this.lbUpdate.Text = "04/10/2012";
            this.lbUpdate.Click += new EventHandler(this.lbUpdate_Click);
            this.timer_3.Interval = 0x3e8;
            this.timer_3.Tick += new EventHandler(this.timer_3_Tick);
            this.timer_4.Enabled = true;
            this.timer_4.Interval = 0x3e8;
            this.timer_4.Tick += new EventHandler(this.timer_4_Tick);
            this.timer_5.Interval = 0x3e8;
            this.timer_5.Tick += new EventHandler(this.timer_5_Tick);
            this.timer_6.Interval = 0x3e8;
            this.timer_6.Tick += new EventHandler(this.timer_6_Tick);
            this.label49.AutoSize = true;
            this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label49.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label49.Location = new Point(0x2bd, 0x19);
            this.label49.Name = "label49";
            this.label49.Size = new Size(0x1f, 0x10);
            this.label49.TabIndex = 0x2d;
            this.label49.Text = "gi\x00e2y";
            this.numAutoClick.Increment = new decimal(new int[] { 5 });
            this.numAutoClick.Location = new Point(0x293, 0x17);
            this.numAutoClick.Maximum = new decimal(new int[] { 0xe10 });
            this.numAutoClick.Name = "numAutoClick";
            this.numAutoClick.Size = new Size(0x24, 0x16);
            this.numAutoClick.TabIndex = 2;
            this.numAutoClick.TextAlign = HorizontalAlignment.Center;
            this.numAutoClick.Value = new decimal(new int[] { 1 });
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x44c, 760);
            base.Controls.Add(this.picLoader);
            base.Controls.Add(this.tbMain);
            base.Controls.Add(this.toolBar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmMain";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Phần mềm SEO số 1 Việt Nam";
            base.Load += new EventHandler(this.frmMain_Load);
            this.tbSeoTool.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((ISupportInitialize) this.btnCheckResultSave).EndInit();
            ((ISupportInitialize) this.dtvCheckResult).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((ISupportInitialize) this.dtvResultCheck).EndInit();
            ((ISupportInitialize) this.btnSaveCheck).EndInit();
            this.tbPingURL.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            ((ISupportInitialize) this.dtvPingProxy).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.numPingView.EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbKeyword.ResumeLayout(false);
            this.tbKeyword.PerformLayout();
            ((ISupportInitialize) this.btnKeyListSave).EndInit();
            ((ISupportInitialize) this.btnSavePosition).EndInit();
            ((ISupportInitialize) this.dtvKeyLogs).EndInit();
            this.mnuKey.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize) this.btnKeyCateAdd).EndInit();
            this.tbMain.ResumeLayout(false);
            this.tbKeyResearch.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((ISupportInitialize) this.dtvTags).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((ISupportInitialize) this.dtvSuggest).EndInit();
            this.mnuSuggest.ResumeLayout(false);
            ((ISupportInitialize) this.btnSaveSuggest).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tbKeywordTool.ResumeLayout(false);
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            ((ISupportInitialize) this.btnKTSave).EndInit();
            ((ISupportInitialize) this.dtvKTList).EndInit();
            this.mnuSuggest_1.ResumeLayout(false);
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.tbWebAnalytics.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize) this.btnAnalyticsLinkSave).EndInit();
            ((ISupportInitialize) this.dtvAnalytics).EndInit();
            ((ISupportInitialize) this.btnSaveAnalytics).EndInit();
            ((ISupportInitialize) this.dtvAnalyticsWord4).EndInit();
            ((ISupportInitialize) this.dtvAnalyticsWord3).EndInit();
            ((ISupportInitialize) this.dtvAnalyticsWord2).EndInit();
            ((ISupportInitialize) this.dtvAnalyticsWord1).EndInit();
            ((ISupportInitialize) this.dtvAnalyticsImage).EndInit();
            ((ISupportInitialize) this.dtvAnalyticsHeading).EndInit();
            ((ISupportInitialize) this.dtvAnalyticsLink).EndInit();
            this.tbCheckBacklink.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            ((ISupportInitialize) this.btnCheckBacklinkSave).EndInit();
            ((ISupportInitialize) this.dtvCheckBacklink).EndInit();
            this.tbSearchBL.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((ISupportInitialize) this.btnSearchBacklinkSave).EndInit();
            ((ISupportInitialize) this.dtvSearchBacklink).EndInit();
            this.tbSocial.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((ISupportInitialize) this.btnSocialClose).EndInit();
            this.tbAdword.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            ((ISupportInitialize) this.btnAdwordSearch).EndInit();
            ((ISupportInitialize) this.btnAdwordDelete).EndInit();
            ((ISupportInitialize) this.btnAdwordEdit).EndInit();
            ((ISupportInitialize) this.btnAdwordAdd).EndInit();
            ((ISupportInitialize) this.dtvAdword).EndInit();
            this.mnuArticle.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            ((ISupportInitialize) this.btnAdwordCateSearch).EndInit();
            ((ISupportInitialize) this.btnAdwordCateAdd).EndInit();
            ((ISupportInitialize) this.dtvAdwordCate).EndInit();
            this.tbView.ResumeLayout(false);
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.tbRival.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((ISupportInitialize) this.dtvRivalMonth2).EndInit();
            ((ISupportInitialize) this.dtvRivalMonth1).EndInit();
            ((ISupportInitialize) this.dtvRivalList).EndInit();
            ((ISupportInitialize) this.dtvRivalHigh).EndInit();
            ((ISupportInitialize) this.dtvRivalTop).EndInit();
            this.tbBacklink.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((ISupportInitialize) this.btnBacklinkSearch).EndInit();
            ((ISupportInitialize) this.btnBacklinkDelete).EndInit();
            ((ISupportInitialize) this.btnBacklinkEdit).EndInit();
            ((ISupportInitialize) this.btnBacklinkAdd).EndInit();
            ((ISupportInitialize) this.dtvBacklink).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((ISupportInitialize) this.btnBacklinkCateSearch).EndInit();
            ((ISupportInitialize) this.btnBacklinkCateAdd).EndInit();
            ((ISupportInitialize) this.dtvBacklinkCate).EndInit();
            this.tbNews.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            ((ISupportInitialize) this.dtvNews).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((ISupportInitialize) this.btnNewsCateSearch).EndInit();
            ((ISupportInitialize) this.btnNewsCateAdd).EndInit();
            ((ISupportInitialize) this.dtvNewsCate).EndInit();
            this.tbHTML.ResumeLayout(false);
            this.tbHTML.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.numericHTMLRandomContent.EndInit();
            ((ISupportInitialize) this.btnHTMLAddContent).EndInit();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            ((ISupportInitialize) this.btnHTMLAddAnchor).EndInit();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            ((ISupportInitialize) this.btnHTMLAddAccount).EndInit();
            this.tbSubmit.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((ISupportInitialize) this.btnSubmitGetSource).EndInit();
            ((ISupportInitialize) this.btnSubmitSave).EndInit();
            this.numSubmitTime.EndInit();
            ((ISupportInitialize) this.txtSubmitAdd).EndInit();
            ((ISupportInitialize) this.btnSubmitSearch).EndInit();
            ((ISupportInitialize) this.btnSubmitDelete).EndInit();
            ((ISupportInitialize) this.btnSubmitEdit).EndInit();
            ((ISupportInitialize) this.btnSubmitAdd).EndInit();
            ((ISupportInitialize) this.dtvSubmit).EndInit();
            ((ISupportInitialize) this.btnSubmitAttribute).EndInit();
            this.tbArticle.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((ISupportInitialize) this.btnArticleSearch).EndInit();
            this.numAuto.EndInit();
            ((ISupportInitialize) this.btnArticleDelete).EndInit();
            ((ISupportInitialize) this.btnArticleEdit).EndInit();
            ((ISupportInitialize) this.btnArticleAdd).EndInit();
            ((ISupportInitialize) this.dtvArticle).EndInit();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((ISupportInitialize) this.btnArticleCateSearch).EndInit();
            ((ISupportInitialize) this.btnArticleCateAdd).EndInit();
            ((ISupportInitialize) this.dtvArticleCate).EndInit();
            this.tbRegex.ResumeLayout(false);
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            ((ISupportInitialize) this.RegexResultSave).EndInit();
            this.numericRegexDelay.EndInit();
            this.groupBox31.ResumeLayout(false);
            ((ISupportInitialize) this.btnRegexUrlSave).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.numericRegexTo.EndInit();
            this.numericRegexFrom.EndInit();
            this.mnuHide.ResumeLayout(false);
            ((ISupportInitialize) this.picLoader).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.numAutoClick.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void lbUpdate_Click(object sender, EventArgs e)
        {
            Process.Start("http://igoo.vn/phanmemseo");
        }

        private void mbtnInsights_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrowser browser = new frmBrowser();
                string urlString = "http://www.google.com/insights/search/#q=" + HttpUtility.UrlEncode(this.dtvSuggest.CurrentRow.Cells[0].Value.ToString()) + "&cmpt=q&hl=" + this.txtLangSuggest.Text;
                browser.webBrowser.Navigate(urlString);
                browser.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void mbtnResearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbMain.SelectTab("tbKeywordTool");
                this.txtKTKey.Text = this.dtvSuggest.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrowser browser = new frmBrowser();
                browser.webBrowser.Navigate("http://www.google." + this.txtExtSuggest.Text.Trim() + "/search?hl=" + this.txtLangSuggest.Text.Trim() + "&q=" + HttpUtility.UrlEncode(this.dtvSuggest.CurrentRow.Cells[0].Value.ToString()) + "&adtest=on");
                browser.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void mbtnSERP_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtKeyResearch.Text = this.dtvSuggest.CurrentRow.Cells[0].Value.ToString();
                this.btnCheckSERP.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void mbtnTopGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbMain.SelectTab("tbKeyword");
                this.txtKeyword.Text = this.dtvSuggest.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_0(object object_0)
        {
            try
            {
                Class5 item = (Class5) object_0;
                item.string_0 = this.gclass4_0.method_38(item.string_0);
                lock (this.list_1)
                {
                    this.list_1.Add(item);
                }
                this.int_0--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_1()
        {
            try
            {
                Class21 class4 = new Class21 {
                    frmMain_0 = this,
                    int_0 = 0,
                    int_1 = 0,
                    int_2 = 0
                };
                this.int_0 = 0;
                class4.string_0 = string.Empty;
                string str2 = this.txtKeyword.Text.Trim();
                class4.string_1 = this.txtDomain.Text.Trim();
                string str3 = this.txtLang.Text.Trim();
                string str4 = this.txtExt.Text.Trim();
                string str5 = string.Empty;
                if (this.ckTopMobile.Checked)
                {
                    str5 = "&source=mobileproducts";
                }
                this.list_1 = new List<Class5>();
                int num = 10;
                int num2 = 1;
                while (true)
                {
                    string str;
                    if (num2 > num)
                    {
                        while (true)
                        {
                            if (this.int_0 <= 0)
                            {
                                class4.string_2 = this.gclass4_0.method_2(str2);
                                class4.string_3 = string.Empty;
                                List<string> list = this.txtWebCompare.Text.Trim().Split(new char[] { ',' }).ToList<string>();
                                class4.list_0 = new List<Class6>();
                                foreach (string str6 in list)
                                {
                                    if (!string.IsNullOrEmpty(str6))
                                    {
                                        Class6 item = new Class6();
                                        item.method_1(str6.Trim());
                                        item.method_3(0);
                                        class4.list_0.Add(item);
                                    }
                                }
                                if (func_0 == null)
                                {
                                    func_0 = new Func<Class5, int>(frmMain.smethod_0);
                                }
                                this.list_1 = this.list_1.OrderBy<Class5, int>(func_0).ToList<Class5>();
                                MethodInvoker method = new MethodInvoker(class4.method_0);
                                if (base.InvokeRequired)
                                {
                                    base.BeginInvoke(method);
                                }
                                else
                                {
                                    method();
                                }
                                if (func_1 == null)
                                {
                                    func_1 = new Func<Class6, int>(frmMain.smethod_1);
                                }
                                class4.list_0 = class4.list_0.OrderBy<Class6, int>(func_1).ToList<Class6>();
                                method = new MethodInvoker(class4.method_1);
                                if (base.InvokeRequired)
                                {
                                    base.BeginInvoke(method);
                                }
                                else
                                {
                                    method();
                                }
                                break;
                            }
                            Thread.Sleep(200);
                        }
                        break;
                    }
                    if (num2 == 1)
                    {
                        string[] strArray = new string[] { "http://www.google.", str4, "/search?hl=", str3, str5, "&q=", str2 };
                        str = string.Concat(strArray);
                    }
                    else
                    {
                        object[] objArray = new object[] { "http://www.google.", str4, "/search?hl=", str3, str5, "&q=", str2, "&start=", (num2 - 1) * 10 };
                        str = string.Concat(objArray);
                    }
                    Class5 parameter = new Class5 {
                        int_0 = num2,
                        string_0 = str
                    };
                    new Thread(new ParameterizedThreadStart(this.method_0)) { IsBackground = true }.Start(parameter);
                    this.int_0++;
                    num2++;
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_10()
        {
            MethodInvoker invoker2 = null;
            try
            {
                this.list_2 = new List<Class7>();
                string parameter = this.txtWebsiteCheck.Text.Trim();
                if (parameter.IndexOf("http") == 0)
                {
                    parameter = new Uri(this.txtWebsiteCheck.Text.Trim()).Host;
                }
                this.int_1 = 0;
                new Thread(new ParameterizedThreadStart(this.method_3)) { IsBackground = true }.Start(parameter);
                this.int_1++;
                new Thread(new ParameterizedThreadStart(this.method_4)) { IsBackground = true }.Start(parameter);
                this.int_1++;
                new Thread(new ParameterizedThreadStart(this.method_5)) { IsBackground = true }.Start(parameter);
                this.int_1++;
                new Thread(new ParameterizedThreadStart(this.method_6)) { IsBackground = true }.Start(parameter);
                this.int_1++;
                new Thread(new ParameterizedThreadStart(this.method_7)) { IsBackground = true }.Start(parameter);
                this.int_1++;
                new Thread(new ParameterizedThreadStart(this.method_8)) { IsBackground = true }.Start(parameter);
                this.int_1++;
                new Thread(new ParameterizedThreadStart(this.method_9)) { IsBackground = true }.Start(parameter);
                this.int_1++;
                while (true)
                {
                    if (this.int_1 <= 0)
                    {
                        invoker2 ??= new MethodInvoker(this.method_113);
                        MethodInvoker method = invoker2;
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(method);
                        }
                        else
                        {
                            method();
                        }
                        break;
                    }
                    Thread.Sleep(300);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_100()
        {
            Thread.Sleep(new Random().Next(0x1d4c0, 0x927c0));
            if (!this.iSEOSoapClient_0.Endpoint.Address.Uri.ToString().StartsWith("http://igoo.vn"))
            {
                Application.Exit();
            }
            this.infoSEO_0.CPUID = this.gclass4_0.method_29();
            string str2 = "<RSAKeyValue><Modulus>wFEjE5yiTXL3r8n9QQvpXgSbuEYwGQXxFpBZrLQct8ENPUInhxr/ywSjMj3UfUWow75qvE7ccIZN+DroPNDcIrr596PO2ztOVRxuPaikTpC1H0xldvpR3p3sLpfH+e9NMXS40ACh11irux5JTx1qbNiriucrT2BASPuNR2dmC4s=</Modulus><Exponent>AQAB</Exponent><P>/vvf9WSuOYwCfhd24ymEDBPzu28spX0Jq6UxeYVEa1EBWIRgjUCs3TuSluYSlJ7uShAhUTyZwdvuDbbCpl9Rbw==</P><Q>wRVU6INfs/198fjA2TusUg/QtFq8VmqJpTAUmPsqDanJlecW1g4CwHKzX1+KAWgkjBke3LVPHW/p3t0PNtzhpQ==</Q><DP>0kmlxXrYGQu4DoeJfAUEKvXVgBJLDtxVOmMNr3vSFnODGZ5rBnN9XSNBXQO39Swxt5Ef+SByaifYZyT/2TgpLw==</DP><DQ>a4/TnjfZb66Oo+a8oAezJn/y9xX5B3cQOPrA7rw0oCnux9hVi2eAtu7u5/mUKtZ2TamM3M0QRsjakzG40QpZlQ==</DQ><InverseQ>pAOfuf0RikJ1vIyTIfGBVTP9vxl6DNavbqd/0g7UCz38bH/qeEmhdZhCSlUFswG95do6snWexpobyLsmoEeYpg==</InverseQ><D>gX7g0Jbazq3ITC0Fg6QiqnUN6cIRJvhSQzBFwb2xzKWIZaRC+31ZmflwbicmCog6QDvaoRu04Wv92lTIBhNY9jgdPPGHHNzt2YqK8RAH3CyOpZEAiVczearZ7w23hBfTGkf6kt20nX8Spa2g97ikVHp2Axy/ot7YObysitHSpXk=</D></RSAKeyValue>";
            string str3 = "<RSAKeyValue><Modulus>keuFw++iHf6aXfHGpvEJ9ReFx1GTmbppEk2YehoUFU8W3zAjk8BjpM2e+t6FG9fDv+skvr/j2q+SjjKUvK1rXAEYLVt56SHE1PD8UxP8QP0N/vQd2eddEqp1BBqynLp1c8EWze7nI9NSfMQSHghZZVI6WjhZmbzw/JWMULBtbKs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            this.infoSEO_0.Password = this.gclass18_0.method_0(this.infoSEO_0.Password, 0x400, str3);
            this.infoSEO_0 = this.iSEOSoapClient_0.CheckLoginISEO(this.infoSEO_0);
            this.infoSEO_0.Password = this.gclass18_0.method_2(this.infoSEO_0.Password, 0x400, str2);
            if (!string.IsNullOrEmpty(this.infoSEO_0.Permission))
            {
                this.infoSEO_0.Permission = this.gclass18_0.method_2(this.infoSEO_0.Permission, 0x400, str2);
            }
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission) && string.IsNullOrEmpty(this.infoSEO_0.Permission))
            {
                Application.Exit();
            }
        }

        public Bitmap method_101(string string_7)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(string_7);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                Bitmap bitmap = new Bitmap(response.GetResponseStream());
                response.Close();
                return bitmap;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void method_102()
        {
            this.method_33(this.dtvCheckResult, true);
            MethodInvoker method = new MethodInvoker(this.method_141);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_103()
        {
            MethodInvoker invoker3 = null;
            try
            {
                Class45 class5 = new Class45 {
                    frmMain_0 = this,
                    string_0 = string.Empty,
                    string_1 = string.Empty
                };
                MethodInvoker method = new MethodInvoker(class5.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                Thread.Sleep(100);
                string str = string.Empty;
                DataTable table = new DataTable();
                DataTable table2 = new DataTable();
                if (!string.IsNullOrEmpty(class5.string_0))
                {
                    str = "SELECT [Key], [ListUrl] FROM Anchor WHERE [CategoryID] = '" + class5.string_0 + "' ORDER BY [LengthKey]";
                    table = this.gclass4_0.method_40(str);
                }
                if (!string.IsNullOrEmpty(class5.string_1))
                {
                    str = "SELECT [Content] FROM Contents WHERE [CategoryID]='" + class5.string_1 + "'";
                    table2 = this.gclass4_0.method_40(str);
                }
                using (IEnumerator enumerator = this.dtvNews.SelectedRows.GetEnumerator())
                {
                    MethodInvoker invoker2 = null;
                    Class46 class4 = new Class46 {
                        class45_0 = class5
                    };
                    while (enumerator.MoveNext())
                    {
                        class4.dataGridViewRow_0 = (DataGridViewRow) enumerator.Current;
                        Class47 class3 = new Class47 {
                            class46_0 = class4,
                            class45_0 = class5
                        };
                        string str2 = this.gclass4_0.method_50(class4.dataGridViewRow_0.Cells[4].Value.ToString());
                        str2 = HttpUtility.HtmlDecode(this.gclass4_0.method_35(str2));
                        string str3 = class4.dataGridViewRow_0.Cells[1].Value.ToString();
                        string str4 = class4.dataGridViewRow_0.Cells[2].Value.ToString();
                        str4 = "<p>Nguồn: " + str4 + "</p>";
                        string str5 = class4.dataGridViewRow_0.Cells[6].Value.ToString();
                        string str6 = this.txtHTMLKeyword.Text.Trim();
                        str2 = "<strong>" + str5 + "</strong>" + str2;
                        if (this.ckNewsAuto3.Checked && !string.IsNullOrEmpty(class5.string_0))
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                if (!row["Key"].ToString().StartsWith("http"))
                                {
                                    str2 = this.gclass4_0.method_32(str2, row["Key"].ToString(), row["ListUrl"].ToString(), 1);
                                }
                            }
                            foreach (DataRow row2 in table.Rows)
                            {
                                if (row2["Key"].ToString().StartsWith("http"))
                                {
                                    str2 = this.gclass4_0.method_32(str2, row2["Key"].ToString(), row2["ListUrl"].ToString(), 1);
                                }
                            }
                        }
                        if (this.ckNewsAuto1.Checked && !string.IsNullOrEmpty(str6))
                        {
                            str3 = str3 + " | " + str6;
                        }
                        if (this.ckNewsAuto2.Checked && !string.IsNullOrEmpty(str6))
                        {
                            foreach (string str7 in Regex.Split(str6, ","))
                            {
                                str2 = this.gclass4_0.method_31(str2, str7);
                            }
                        }
                        if (this.ckNewsAuto4.Checked && !string.IsNullOrEmpty(class5.string_1))
                        {
                            int count;
                            List<string> list = new List<string>();
                            foreach (DataRow row3 in table2.Rows)
                            {
                                list.Add(row3["Content"].ToString());
                            }
                            list = this.gclass4_0.method_23<string>(list);
                            if (((int) this.numericHTMLRandomContent.Value) > list.Count)
                            {
                                count = list.Count;
                            }
                            string str8 = string.Empty;
                            foreach (string str9 in list)
                            {
                                str8 = str8 + str9;
                                count--;
                                if (count == 0)
                                {
                                    break;
                                }
                            }
                            str2 = str2 + str8;
                            str2 = this.gclass4_0.method_21(str2);
                        }
                        str2 = str2.Replace("<div", "<p").Replace("</div>", "</p>") + str4;
                        class3.string_0 = null;
                        method = new MethodInvoker(class3.method_0);
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(method);
                        }
                        else
                        {
                            method();
                        }
                        if (!this.timer_4.Enabled || (this.timer_4.Interval > 0x5265c00))
                        {
                            this.timer_4.Interval = 0xea60;
                            this.timer_4.Enabled = true;
                        }
                        Thread.Sleep(100);
                        GClass6 class2 = new GClass6();
                        string[] strArray2 = this.listHTMLCategory.Tag.ToString().Split(new char[] { ';' });
                        string host = new Uri(strArray2[0]).Host;
                        if (!this.gclass4_0.method_18(Application.StartupPath + @"\Logs\" + host + ".iseo", str3))
                        {
                            if (this.cbHTMLAccount.Tag.ToString().Equals("Blogger"))
                            {
                                class2.method_1(strArray2[0], strArray2[1], strArray2[2], strArray2[3], str3, str2, class3.string_0);
                            }
                            else if (this.cbHTMLAccount.Tag.ToString().Equals("Wordpress"))
                            {
                                class2.method_0(strArray2[0], strArray2[1], strArray2[2], str3, str2, this.txtHTMLTags.Text.Trim(), class3.string_0);
                            }
                        }
                        invoker2 ??= new MethodInvoker(class4.method_0);
                        method = invoker2;
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(method);
                        }
                        else
                        {
                            method();
                        }
                    }
                }
                invoker3 ??= new MethodInvoker(this.method_142);
                method = invoker3;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "2 -Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_104()
        {
            try
            {
                Class48 class6 = new Class48 {
                    frmMain_0 = this,
                    string_0 = string.Empty
                };
                MethodInvoker method = new MethodInvoker(class6.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                Thread.Sleep(100);
                if (!string.IsNullOrEmpty(class6.string_0))
                {
                    GClass19 class2 = new GClass19 {
                        gclass4_0 = this.gclass4_0
                    };
                    List<Class19> list = new List<Class19>();
                    class2.method_1("http://www.baomoi.com/Home/" + class6.string_0);
                    using (IEnumerator<GStruct3> enumerator = class2.method_8().GetEnumerator())
                    {
                        Predicate<Class19> match = null;
                        Class49 class4 = new Class49 {
                            class48_0 = class6
                        };
                        while (enumerator.MoveNext())
                        {
                            class4.gstruct3_0 = enumerator.Current;
                            string str = class4.gstruct3_0.string_4.Substring(class4.gstruct3_0.string_4.LastIndexOf("/"));
                            string str2 = class4.gstruct3_0.string_4.Substring(0, class4.gstruct3_0.string_4.LastIndexOf("/"));
                            string str3 = str2.Substring(str2.LastIndexOf("/"));
                            string str4 = string.Empty;
                            if ("Unresolvable".Equals(class4.gstruct3_0.string_2))
                            {
                                str4 = "/55";
                            }
                            else
                            {
                                str2 = class4.gstruct3_0.string_2.Substring(0, class4.gstruct3_0.string_2.LastIndexOf("/"));
                                str4 = str2.Substring(str2.LastIndexOf("/"));
                            }
                            if (match == null)
                            {
                                match = new Predicate<Class19>(class4.method_0);
                            }
                            if (list.FindIndex(match) < 0)
                            {
                                Class19 item = new Class19();
                                item.method_1(class4.gstruct3_0.string_0);
                                item.method_3(class4.gstruct3_0.string_3);
                                item.method_9(class4.gstruct3_0.string_1);
                                item.method_11(class4.gstruct3_0.string_2.Replace("http://www.baomoi.com/", ""));
                                item.method_5(new Uri(class4.gstruct3_0.string_1).Host);
                                item.method_7(str3 + str4 + str.Substring(0, str.Length - 4));
                                list.Add(item);
                            }
                        }
                    }
                    foreach (Class19 class5 in list)
                    {
                        try
                        {
                            string str5 = "INSERT INTO NewsLogs ([NewsLogID], [CategoryID], [Title], [Unique], [Source], [Link], [Url], [Image], [Desc], [Status], [Created]) VALUES('" + Guid.NewGuid() + "', @CategoryID, @Title, @Unique, @Source, @Link, @Url, @Image, @Desc, @Status, @Created)";
                            object[] objArray = new object[] { "@CategoryID", class6.string_0, "@Title", class5.method_0(), "@Unique", class6.string_0 + class5.method_0(), "@Source", class5.method_4(), "@Link" };
                            objArray[9] = class5.method_8();
                            objArray[10] = "@Url";
                            objArray[11] = class5.method_6();
                            objArray[12] = "@Image";
                            objArray[13] = class5.method_10();
                            objArray[14] = "@Desc";
                            objArray[15] = class5.method_2();
                            objArray[0x10] = "@Status";
                            objArray[0x11] = false;
                            objArray[0x12] = "@Created";
                            objArray[0x13] = DateTime.Now.ToString();
                            this.gclass4_0.method_43(str5, CommandType.Text, objArray);
                        }
                        catch
                        {
                        }
                    }
                    method = new MethodInvoker(class6.method_1);
                    if (base.InvokeRequired)
                    {
                        base.BeginInvoke(method);
                    }
                    else
                    {
                        method();
                    }
                }
            }
            catch
            {
            }
        }

        private void method_105(string string_7)
        {
            string str = "SELECT [NewsLogID], [CategoryID], [Title], [Source], [Link], [Url], [Image], [Desc], switch([Status] = 0, 'false', 1, 'true', -1, 'false') AS [isPosted] FROM NewsLogs WHERE CategoryID='" + string_7 + "' ORDER BY Created DESC";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvNews.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["NewsLogID"].ToString(), row["Title"].ToString(), row["Source"].ToString(), row["Link"].ToString(), "http://www.baomoi.com" + row["Url"].ToString() + ".epi", "http://www.baomoi.com/" + row["Image"].ToString(), row["Desc"].ToString(), Convert.ToBoolean(row["isPosted"].ToString()) };
                this.dtvNews.Rows.Add(values);
            }
        }

        private void method_106()
        {
            this.method_33(this.dtvSubmit, true);
            MethodInvoker method = new MethodInvoker(this.method_143);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_107()
        {
            Class50 class2 = new Class50 {
                frmMain_0 = this
            };
            this.gclass4_0.string_0 = "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";
            class2.string_0 = this.gclass4_0.method_38(this.txtRegexURL.Text.Trim());
            this.gclass4_0.string_0 = this.gclass4_0.string_1;
            MethodInvoker method = new MethodInvoker(class2.method_0);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_108()
        {
            this.method_33(this.dtvAnalyticsLink, true);
            MethodInvoker method = new MethodInvoker(this.method_144);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_109()
        {
            this.method_33(this.dtvSearchBacklink, true);
            MethodInvoker method = new MethodInvoker(this.method_145);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_11()
        {
            try
            {
                Class23 class5 = new Class23 {
                    frmMain_0 = this,
                    list_0 = new List<Class7>()
                };
                string hostNameOrAddress = this.txtWebsiteCheck.Text.Trim();
                if (hostNameOrAddress.IndexOf("http") == 0)
                {
                    hostNameOrAddress = new Uri(this.txtWebsiteCheck.Text.Trim()).Host;
                }
                Class7 item = new Class7("[" + hostNameOrAddress + "]", "");
                class5.list_0.Add(item);
                item = new Class7("=>IP: " + Dns.GetHostAddresses(hostNameOrAddress)[0].ToString(), "");
                class5.list_0.Add(item);
                item = new Class7("=>File Robots: " + this.gclass4_0.method_24("http://" + hostNameOrAddress + "/robots.txt"), "http://" + hostNameOrAddress + "/robots.txt");
                class5.list_0.Add(item);
                item = new Class7("=>File Sitemap.xml: " + this.gclass4_0.method_24("http://" + hostNameOrAddress + "/sitemap.xml"), "http://" + hostNameOrAddress + "/sitemap.xml");
                class5.list_0.Add(item);
                GClass15 class3 = new GClass15();
                item = new Class7("[RageRank]", "");
                class5.list_0.Add(item);
                item = new Class7("=>Goolge PageRank: " + class3.method_3(hostNameOrAddress).ToString() + "/10", "");
                class5.list_0.Add(item);
                item = new Class7("[Backlinks]", "http://www.google.com/search?hl=vi&q=link:" + hostNameOrAddress);
                class5.list_0.Add(item);
                item = new Class7("=>Google Links: " + this.gclass4_0.method_7(this.gclass4_0.method_38("http://www.google.com/search?hl=vi&q=link:" + hostNameOrAddress)), "");
                class5.list_0.Add(item);
                Match match = new Regex("hiển thị v\x00e0o (?<Cache>.*?). <a", RegexOptions.Singleline).Match(this.gclass4_0.method_38("http://www.google.com/search?hl=vi&q=site:" + hostNameOrAddress));
                item = new Class7("[Pages Indexed]", "");
                class5.list_0.Add(item);
                item = new Class7("=>Google Indexed: " + this.gclass4_0.method_7(this.gclass4_0.method_38("http://www.google.com/search?hl=vi&q=site:" + hostNameOrAddress)), "http://www.google.com/search?hl=vi&q=site:" + hostNameOrAddress);
                class5.list_0.Add(item);
                match = new Regex("<span class=\"sb_count\" id=\"count\">(?<Page>.*?) of (?<Content>.*?)</span>", RegexOptions.Singleline).Match(this.gclass4_0.method_38("http://www.bing.com/search?q=site:" + hostNameOrAddress));
                item = new Class7("=>Bing.com Indexed: " + match.Groups["Content"].Value, "http://www.bing.com/search?q=site:" + hostNameOrAddress);
                class5.list_0.Add(item);
                XmlDocument document = new XmlDocument();
                document.LoadXml(this.gclass4_0.method_38("http://lightapi.majesticseo.com/getdomainstats.php?apikey=A42C68F9D&url=" + hostNameOrAddress));
                foreach (XmlNode node in document.SelectNodes("//Result"))
                {
                    XElement element = XElement.Parse(node.OuterXml.ToString());
                    item = new Class7("[MajesticSEO.com]", element.Attribute("LinkBackURL").Value);
                    class5.list_0.Add(item);
                    item = new Class7("=>Domain li\x00ean kết: " + element.Attribute("StatsRefDomains").Value, "");
                    class5.list_0.Add(item);
                    item = new Class7("=>External Backlinks: " + element.Attribute("StatsExternalBackLinks").Value, "");
                    class5.list_0.Add(item);
                    item = new Class7("=>MajesticSEO Index: " + element.Attribute("StatsIndexedURLs").Value, "");
                    class5.list_0.Add(item);
                }
                item = new Class7("[Alexa.com]", "http://www.alexa.com/siteinfo/" + hostNameOrAddress);
                class5.list_0.Add(item);
                string input = this.gclass4_0.method_38("http://www.alexa.com/siteinfo/" + hostNameOrAddress);
                match = new Regex("margin-bottom:-2px;\"/>(?<Global>.*?)</div>", RegexOptions.Singleline).Match(input);
                item = new Class7("=>Alexa Global Rank: " + match.Groups["Global"].Value.Trim(), "");
                class5.list_0.Add(item);
                match = new Regex("Vietnam Flag\"/>(?<VN>.*?)</div>", RegexOptions.Singleline).Match(input);
                item = new Class7("=>Alexa VN Rank: " + match.Groups["VN"].Value.Trim(), "");
                class5.list_0.Add(item);
                match = new Regex("href=\"/site/linksin/" + this.txtWebsiteCheck.Text.Trim() + "\">(?<Backlink>.*?)</a>", RegexOptions.Singleline).Match(input);
                item = new Class7("=>Alexa Backlink: " + match.Groups["Backlink"].Value.Trim(), "");
                class5.list_0.Add(item);
                match = new Regex(hostNameOrAddress + "/\">(?<Day>.*?)</a>", RegexOptions.Singleline).Match(this.gclass4_0.method_38("http://wayback.archive.org/web/*/" + hostNameOrAddress));
                item = new Class7("[Age]", "http://wayback.archive.org/web/*/" + hostNameOrAddress);
                class5.list_0.Add(item);
                item = new Class7("=>Website Age: " + match.Groups["Day"].Value, "");
                class5.list_0.Add(item);
                string text = this.gclass4_0.method_38("http://seoquake.publicapi.semrush.com/info.php?url=" + hostNameOrAddress);
                if (text.IndexOf("<status>notfound</status>") < 0)
                {
                    if (func_3 == null)
                    {
                        func_3 = new Func<XElement, Class64<string, string, string, string>>(frmMain.smethod_5);
                    }
                    foreach (Class64<string, string, string, string> class4 in XDocument.Parse(text).Descendants("data").Select<XElement, Class64<string, string, string, string>>(func_3))
                    {
                        item = new Class7("[SEMRush.com]", "http://www.semrush.com/search.php?q=" + hostNameOrAddress);
                        class5.list_0.Add(item);
                        item = new Class7("=>Rank: " + class4.method_0(), "");
                        class5.list_0.Add(item);
                        item = new Class7("=>Keywords: " + class4.method_1(), "");
                        class5.list_0.Add(item);
                        item = new Class7("=>Traffic: " + class4.method_2(), "");
                        class5.list_0.Add(item);
                        item = new Class7("=>Costs: " + class4.method_3(), "");
                        class5.list_0.Add(item);
                    }
                }
                MethodInvoker method = new MethodInvoker(class5.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_110()
        {
            this.method_33(this.dtvCheckBacklink, true);
            MethodInvoker method = new MethodInvoker(this.method_146);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_111()
        {
            string str = this.dtvCheckResult.CurrentRow.Cells[1].Value.ToString();
            this.gclass4_0.string_0 = "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";
            string str2 = this.gclass4_0.method_38(str);
            this.gclass4_0.string_0 = this.gclass4_0.string_1;
            List<GClass9> list = this.gclass4_0.method_10(str2.ToLower(), str, string.Empty);
            list_0 = new List<string>();
            foreach (GClass9 class2 in list)
            {
                if (class2.method_12() == "Internal")
                {
                    list_0.Add(class2.method_4());
                }
            }
            list_0 = list_0.Distinct<string>().ToList<string>();
            MethodInvoker method = new MethodInvoker(this.method_147);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        [CompilerGenerated]
        private void method_112()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_113()
        {
            this.dtvResultCheck.Rows.Clear();
            foreach (Class7 class2 in this.list_2)
            {
                object[] values = new object[] { class2.method_0(), class2.method_2() };
                this.dtvResultCheck.Rows.Add(values);
            }
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_114()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_115()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_116()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_117()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private bool method_118(Class11 class11_0) => 
            class11_0.method_0().Contains(this.txtKeyFilter.Text.Trim());

        [CompilerGenerated]
        private void method_119()
        {
            this.picLoader.Hide();
        }

        private void method_12()
        {
            MethodInvoker invoker2 = null;
            try
            {
                MethodInvoker invoker;
                Regex regex = new Regex("class=\"V1\">(?<Content>.*?)</div>", RegexOptions.Singleline);
                foreach (string str in list_0)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        Class24 class2 = new Class24 {
                            frmMain_0 = this,
                            string_0 = str.Trim()
                        };
                        class2.string_1 = this.gclass4_0.method_16(regex, this.gclass4_0.method_38("https://plusone.google.com/u/0/_/+1/fastbutton?url=" + class2.string_0)) + " +1";
                        class2.string_1 = class2.string_1 + " | " + this.gclass4_0.method_15("pluginCountTextConnected\">(?<Content>.*?)</span>", this.gclass4_0.method_38("https://www.facebook.com/plugins/like.php?layout=button_count&href=" + class2.string_0)) + " Like";
                        invoker = new MethodInvoker(class2.method_0);
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(invoker);
                            continue;
                        }
                        invoker();
                    }
                }
                invoker2 ??= new MethodInvoker(this.method_114);
                invoker = invoker2;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(invoker);
                }
                else
                {
                    invoker();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error list Link", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        [CompilerGenerated]
        private void method_120()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_121()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_122()
        {
            this.method_42();
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_123()
        {
            this.method_26();
            MessageBox.Show("Cập nhật vị tr\x00ed từ kho\x00e1 th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_124()
        {
            this.dtvAnalyticsLink.Rows.Clear();
            foreach (GClass9 class2 in this.list_8)
            {
                object[] values = new object[] { class2.method_0(), class2.method_10(), class2.method_2(), class2.method_4(), class2.method_6(), class2.method_8(), class2.method_14(), class2.method_12(), class2.method_16() };
                this.dtvAnalyticsLink.Rows.Add(values);
            }
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_125()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_126()
        {
            MessageBox.Show("Kiểm tra nội dung ho\x00e0n tất!", "Result!");
            this.method_46();
            this.gclass4_0.string_0 = this.gclass4_0.string_1;
            this.picLoader.Hide();
            this.bool_4 = false;
        }

        [CompilerGenerated]
        private void method_127()
        {
            this.method_46();
            if (this.bool_2)
            {
                this.notifyIcon_0.BalloonTipTitle = "Th\x00f4ng b\x00e1o b\x00e0i viết!";
                this.notifyIcon_0.BalloonTipText = "C\x00f3 " + this.int_8.ToString() + " phản hồi mới!";
                this.notifyIcon_0.ShowBalloonTip(0x1388);
            }
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_128()
        {
            if ((this.list_10.Count % 10) == 0)
            {
                this.dtvSearchBacklink.Rows.Clear();
                foreach (Class16 class2 in this.list_10)
                {
                    object[] values = new object[] { "http://" + class2.method_0(), Path.GetExtension(class2.method_0()), class2.method_2(), class2.method_4() };
                    this.dtvSearchBacklink.Rows.Add(values);
                }
            }
        }

        [CompilerGenerated]
        private void method_129()
        {
            this.dtvSearchBacklink.Rows.Clear();
            foreach (Class16 class2 in this.list_10)
            {
                object[] values = new object[] { "http://" + class2.method_0(), Path.GetExtension(class2.method_0()), class2.method_2(), class2.method_4() };
                this.dtvSearchBacklink.Rows.Add(values);
            }
            this.picLoader.Hide();
        }

        private void method_13()
        {
            MethodInvoker invoker2 = null;
            try
            {
                string str2 = "http://www.google.com/webmasters/sitemaps/ping?sitemap=" + this.txtLinkSitemap.Text;
                string[] strArray = new string[] { string.Empty, "[", this.gclass4_0.method_24(str2), "] ", str2 };
                string str = string.Concat(strArray);
                methodInvoker_2 ??= new MethodInvoker(frmMain.smethod_6);
                MethodInvoker method = methodInvoker_2;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                str2 = "http://search.yahooapis.com/SiteExplorerService/V1/updateNotification?appid=YahooDemo&url=" + this.txtLinkSitemap.Text;
                string[] strArray2 = new string[] { str, "\n[", this.gclass4_0.method_24(str2), "] ", str2 };
                str = string.Concat(strArray2);
                methodInvoker_3 ??= new MethodInvoker(frmMain.smethod_7);
                method = methodInvoker_3;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                str2 = "http://www.bing.com/webmaster/ping.aspx?siteMap=sitemap=" + this.txtLinkSitemap.Text;
                string[] strArray3 = new string[] { str, "\n[", this.gclass4_0.method_24(str2), "] ", str2 };
                str = string.Concat(strArray3);
                methodInvoker_4 ??= new MethodInvoker(frmMain.smethod_8);
                method = methodInvoker_4;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                str2 = "http://submissions.ask.com/ping?sitemap=" + this.txtLinkSitemap.Text;
                string[] strArray4 = new string[] { str, "\n[", this.gclass4_0.method_24(str2), "] ", str2 };
                str = string.Concat(strArray4);
                methodInvoker_5 ??= new MethodInvoker(frmMain.smethod_9);
                method = methodInvoker_5;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                invoker2 ??= new MethodInvoker(this.method_115);
                method = invoker2;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        [CompilerGenerated]
        private void method_130()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_131()
        {
            this.dtvCheckBacklink.Rows.Clear();
            foreach (Class17 class2 in this.list_11)
            {
                object[] values = new object[] { class2.method_2(), class2.method_6(), class2.method_0(), class2.method_4() };
                this.dtvCheckBacklink.Rows.Add(values);
            }
        }

        [CompilerGenerated]
        private void method_132()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_133()
        {
            this.method_71();
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_134()
        {
            this.dtvPingProxy.Rows.Clear();
            foreach (string str in this.list_13)
            {
                object[] values = new object[] { str };
                this.dtvPingProxy.Rows.Add(values);
            }
            MessageBox.Show("Check Proxy ho\x00e0n tất!", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_135()
        {
            this.rtbRegexResult.Text = this.string_5;
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_136()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_137()
        {
            this.dtvKTList.Rows.Clear();
            foreach (GClass13 class2 in this.list_14)
            {
                object[] values = new object[] { class2.string_0, class2.int_0, class2.long_0, class2.long_1, class2.decimal_0, class2.decimal_1, class2.decimal_2 };
                this.dtvKTList.Rows.Add(values);
            }
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private bool method_138(GClass13 gclass13_0) => 
            gclass13_0.string_0.Contains(this.txtKTKeyFilter.Text.Trim());

        [CompilerGenerated]
        private void method_139()
        {
            this.picLoader.Hide();
            MessageBox.Show(this.string_6, "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.gclass4_0.int_0 = 0;
        }

        private void method_14(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnPingSitemap.PerformClick();
            }
        }

        [CompilerGenerated]
        private void method_140()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_141()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_142()
        {
            string str = this.dtvNews.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(str))
            {
                this.gclass4_0.method_42("UPDATE NewsLogs SET [Status]=true WHERE NewsLogID='" + str + "'");
            }
            this.dtvNews.CurrentRow.Cells[7].Value = true;
            this.dtvNews.ClearSelection();
            MessageBox.Show("Th\x00eam b\x00e0i th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_143()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_144()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_145()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_146()
        {
            this.picLoader.Hide();
        }

        [CompilerGenerated]
        private void method_147()
        {
            this.btnCheckPR.PerformClick();
            this.picLoader.Hide();
        }

        private void method_15(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnPing.PerformClick();
            }
        }

        private void method_16()
        {
            try
            {
                Class25 class7 = new Class25 {
                    frmMain_0 = this,
                    string_0 = string.Empty,
                    string_1 = string.Empty,
                    string_2 = this.txtKeywordAnalytics.Text.Trim(),
                    list_0 = new List<Class10>()
                };
                if (this.radioURL1.Checked)
                {
                    class7.string_0 = this.txtWebsiteUrl.Text.Trim();
                }
                else if (this.radioURL2.Checked)
                {
                    class7.string_0 = this.txtWebsiteUrl2.Text.Trim();
                }
                if (class7.string_0.IndexOf("http") < 0)
                {
                    class7.string_0 = "http://" + class7.string_0;
                }
                class7.string_1 = this.gclass4_0.method_38(class7.string_0).ToLower();
                this.gclass4_0.method_13(class7.string_0);
                class7.string_3 = this.gclass4_0.method_33(class7.string_1);
                Class10 item = new Class10 {
                    string_0 = "Đường dẫn",
                    string_1 = class7.string_0 + "(Độ d\x00e0i: " + class7.string_0.Length.ToString() + ")"
                };
                class7.list_0.Add(item);
                item = new Class10 {
                    string_0 = "Goolge PageRank",
                    string_1 = new GClass15().method_3(class7.string_0).ToString() + "/10"
                };
                class7.list_0.Add(item);
                item = new Class10 {
                    string_0 = "Google™ Analytics",
                    string_1 = (class7.string_1.IndexOf("google-analytics.com") < 0) ? "Kh\x00f4ng" : "C\x00f3"
                };
                class7.list_0.Add(item);
                if (!string.IsNullOrEmpty(class7.string_2))
                {
                    int num = this.gclass4_0.method_28(class7.string_3, class7.string_2);
                    item = new Class10 {
                        string_0 = "To\x00e0n trang",
                        string_2 = class7.string_2,
                        string_3 = num.ToString()
                    };
                    class7.list_0.Add(item);
                    item = new Class10 {
                        string_0 = "Keyword Density của từ kho\x00e1",
                        string_2 = class7.string_2,
                        string_3 = Math.Round((decimal) (((num * this.gclass4_0.method_27(class7.string_2)) * 100) / this.gclass4_0.method_27(class7.string_3)), 2, MidpointRounding.AwayFromZero).ToString() + "% (1-1.5% l\x00e0 hợp l\x00fd)"
                    };
                    class7.list_0.Add(item);
                }
                Match match = new Regex("<title>(?<Content>.*?)</title>", RegexOptions.Singleline).Match(class7.string_1);
                item = new Class10 {
                    string_0 = "Ti\x00eau đề (Độ d\x00e0i: " + match.Groups["Content"].Value.Length.ToString() + ")",
                    string_1 = match.Groups["Content"].Value
                };
                if (!string.IsNullOrEmpty(class7.string_2))
                {
                    item.string_2 = class7.string_2;
                    item.string_3 = this.gclass4_0.method_28(match.Groups["Content"].Value.ToString(), class7.string_2).ToString();
                }
                class7.list_0.Add(item);
                match = new Regex("name=\"description\" content=\"(?<Content>.*?)\"", RegexOptions.Singleline).Match(class7.string_1);
                item = new Class10 {
                    string_0 = "M\x00f4 tả: (Độ d\x00e0i: " + match.Groups["Content"].Value.Length.ToString() + ")",
                    string_1 = match.Groups["Content"].Value
                };
                if (!string.IsNullOrEmpty(class7.string_2))
                {
                    item.string_2 = class7.string_2;
                    item.string_3 = this.gclass4_0.method_28(match.Groups["Content"].Value.ToString(), class7.string_2).ToString();
                }
                class7.list_0.Add(item);
                match = new Regex("name=\"keywords\" content=\"(?<Content>.*?)\"", RegexOptions.Singleline).Match(class7.string_1);
                item = new Class10 {
                    string_0 = "Từ kh\x00f3a: (Độ d\x00e0i: " + match.Groups["Content"].Value.Length.ToString() + ")",
                    string_1 = match.Groups["Content"].Value
                };
                if (!string.IsNullOrEmpty(class7.string_2))
                {
                    item.string_2 = class7.string_2;
                    item.string_3 = this.gclass4_0.method_28(match.Groups["Content"].Value.ToString(), class7.string_2).ToString();
                }
                class7.list_0.Add(item);
                class7.list_1 = new List<Class9>();
                int num3 = 1;
                while (true)
                {
                    MatchCollection matchs;
                    if (num3 > 6)
                    {
                        matchs = new Regex("<strong(?<Content>.*?)</strong>", RegexOptions.Singleline).Matches(class7.string_1);
                        int num7 = 0;
                        int num8 = 0;
                        while (true)
                        {
                            if (num8 >= matchs.Count)
                            {
                                item = new Class10 {
                                    string_0 = "Số thẻ in đậm <strong>",
                                    string_1 = matchs.Count.ToString()
                                };
                                if (!string.IsNullOrEmpty(class7.string_2))
                                {
                                    item.string_2 = class7.string_2;
                                    item.string_3 = num7.ToString();
                                }
                                class7.list_0.Add(item);
                                matchs = new Regex("<em(?<Content>.*?)</em>", RegexOptions.Singleline).Matches(class7.string_1);
                                num7 = 0;
                                item = new Class10 {
                                    string_0 = "Số thẻ in nghi\x00eang <em>",
                                    string_1 = matchs.Count.ToString()
                                };
                                int num9 = 0;
                                while (true)
                                {
                                    if (num9 >= matchs.Count)
                                    {
                                        if (!string.IsNullOrEmpty(class7.string_2))
                                        {
                                            item.string_2 = class7.string_2;
                                            item.string_3 = num7.ToString();
                                        }
                                        class7.list_0.Add(item);
                                        item = new Class10 {
                                            string_0 = "Số thẻ <iframe>",
                                            string_1 = new Regex("<iframe(?<Content>.*?)</iframe>", RegexOptions.Singleline).Matches(class7.string_1).Count.ToString()
                                        };
                                        class7.list_0.Add(item);
                                        matchs = new Regex("<img(?<Content>.*?)>", RegexOptions.Singleline).Matches(class7.string_1);
                                        int num10 = 0;
                                        num7 = 0;
                                        Regex regex2 = new Regex("src=[\"|'](?<Content>.*?)[\"|']", RegexOptions.Singleline);
                                        Regex regex3 = new Regex("alt=[\"|'](?<Content>.*?)[\"|']", RegexOptions.Singleline);
                                        class7.list_2 = new List<Class8>();
                                        int num11 = 0;
                                        while (true)
                                        {
                                            if (num11 >= matchs.Count)
                                            {
                                                this.list_8 = this.gclass4_0.method_10(class7.string_1, class7.string_0, class7.string_2);
                                                int num13 = 0;
                                                int num14 = 0;
                                                int num15 = 0;
                                                int num16 = 0;
                                                int num17 = 0;
                                                num7 = 0;
                                                item = new Class10 {
                                                    string_0 = "Số thẻ li\x00ean kết <a>",
                                                    string_1 = this.list_8.Count.ToString()
                                                };
                                                foreach (GClass9 class6 in this.list_8)
                                                {
                                                    if (class6.method_8().IndexOf("nofollow") >= 0)
                                                    {
                                                        if (class6.method_12() == "External")
                                                        {
                                                            num17++;
                                                        }
                                                        else
                                                        {
                                                            num15++;
                                                        }
                                                    }
                                                    else if (class6.method_12() == "External")
                                                    {
                                                        num16++;
                                                    }
                                                    else
                                                    {
                                                        num14++;
                                                    }
                                                    if (string.IsNullOrEmpty(class6.method_6()))
                                                    {
                                                        num13++;
                                                    }
                                                    if (!string.IsNullOrEmpty(class7.string_2))
                                                    {
                                                        num7 += this.gclass4_0.method_28(class6.method_10(), class7.string_2);
                                                    }
                                                }
                                                if (!string.IsNullOrEmpty(class7.string_2))
                                                {
                                                    item.string_2 = class7.string_2;
                                                    item.string_3 = num7.ToString();
                                                }
                                                class7.list_0.Add(item);
                                                item = new Class10 {
                                                    string_0 = "Li\x00ean kết nội Follow (Internal Link)",
                                                    string_1 = num14.ToString()
                                                };
                                                class7.list_0.Add(item);
                                                item = new Class10 {
                                                    string_0 = "Li\x00ean kết nội Nofollow",
                                                    string_1 = num15.ToString()
                                                };
                                                class7.list_0.Add(item);
                                                item = new Class10 {
                                                    string_0 = "Li\x00ean kết ra ngo\x00e0i Follow (External Link - OBL)",
                                                    string_1 = num16.ToString()
                                                };
                                                class7.list_0.Add(item);
                                                item = new Class10 {
                                                    string_0 = "Li\x00ean kết ra ngo\x00e0i Nofollow",
                                                    string_1 = num17.ToString()
                                                };
                                                class7.list_0.Add(item);
                                                item = new Class10 {
                                                    string_0 = "Số li\x00ean kết kh\x00f4ng c\x00f3 thuộc t\x00ednh [Title]",
                                                    string_1 = num13.ToString()
                                                };
                                                class7.list_0.Add(item);
                                                MethodInvoker method = new MethodInvoker(class7.method_0);
                                                if (base.InvokeRequired)
                                                {
                                                    base.BeginInvoke(method);
                                                }
                                                else
                                                {
                                                    method();
                                                }
                                                break;
                                            }
                                            string str3 = matchs[num11].ToString();
                                            int num12 = this.gclass4_0.method_28(str3, class7.string_2);
                                            Class8 class5 = new Class8();
                                            class5.method_1(num11 + 1);
                                            class5.method_3(num12);
                                            class5.method_5(this.gclass4_0.method_16(regex2, str3));
                                            class5.method_7(this.gclass4_0.method_16(regex3, str3));
                                            class7.list_2.Add(class5);
                                            if (str3.IndexOf("alt=") >= 0)
                                            {
                                                num10++;
                                            }
                                            if (!string.IsNullOrEmpty(class7.string_2))
                                            {
                                                num7 += this.gclass4_0.method_28(str3, class7.string_2);
                                            }
                                            num11++;
                                        }
                                        break;
                                    }
                                    if (!string.IsNullOrEmpty(class7.string_2))
                                    {
                                        num7 += this.gclass4_0.method_28(matchs[num9].Groups["Content"].ToString(), class7.string_2);
                                    }
                                    num9++;
                                }
                                break;
                            }
                            if (!string.IsNullOrEmpty(class7.string_2))
                            {
                                num7 += this.gclass4_0.method_28(matchs[num8].Groups["Content"].ToString(), class7.string_2);
                            }
                            num8++;
                        }
                        break;
                    }
                    int num4 = 0;
                    string[] strArray = new string[] { "<h", num3.ToString(), "(?<Content>.*?)</h", num3.ToString(), ">" };
                    string pattern = string.Concat(strArray);
                    matchs = new Regex(pattern, RegexOptions.Singleline).Matches(class7.string_1);
                    item = new Class10 {
                        string_0 = "Số thẻ [H" + num3.ToString() + "]"
                    };
                    item.string_1 = matchs.Count.ToString();
                    int num5 = 0;
                    while (true)
                    {
                        if (num5 >= matchs.Count)
                        {
                            if (!string.IsNullOrEmpty(class7.string_2))
                            {
                                string[] strArray2 = new string[] { "\"", class7.string_2, "\" trong thẻ [H", num3.ToString(), "]" };
                                item.string_2 = string.Concat(strArray2);
                                item.string_3 = num4.ToString();
                            }
                            class7.list_0.Add(item);
                            num3++;
                            break;
                        }
                        string str2 = this.gclass4_0.method_33(matchs[num5].ToString());
                        int num6 = this.gclass4_0.method_28(str2, class7.string_2);
                        Class9 class4 = new Class9();
                        class4.method_1(num5 + 1);
                        class4.method_3(num6);
                        class4.method_5(str2.Trim());
                        class4.method_7("H" + num3.ToString());
                        class7.list_1.Add(class4);
                        num4 += this.gclass4_0.method_28(str2, class7.string_2);
                        num5++;
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_17()
        {
            this.dtvAnalyticsLink.Rows.Clear();
            List<GClass9> source = this.list_8;
            int num = 0;
            if (this.ckAnchorTitle.Checked)
            {
                if (func_4 == null)
                {
                    func_4 = new Func<GClass9, bool>(frmMain.smethod_10);
                }
                source = source.Where<GClass9>(func_4).ToList<GClass9>();
            }
            if (this.ckAnchorNofollow.Checked)
            {
                if (func_5 == null)
                {
                    func_5 = new Func<GClass9, bool>(frmMain.smethod_11);
                }
                source = source.Where<GClass9>(func_5).ToList<GClass9>();
            }
            if (this.ckAnchorError.Checked)
            {
                if (func_6 == null)
                {
                    func_6 = new Func<GClass9, bool>(frmMain.smethod_12);
                }
                source = source.Where<GClass9>(func_6).ToList<GClass9>();
            }
            if (this.ckAnchorExternal.Checked)
            {
                if (func_7 == null)
                {
                    func_7 = new Func<GClass9, bool>(frmMain.smethod_13);
                }
                source = source.Where<GClass9>(func_7).ToList<GClass9>();
            }
            if (this.ckAnchorImage.Checked)
            {
                if (func_8 == null)
                {
                    func_8 = new Func<GClass9, bool>(frmMain.smethod_14);
                }
                source = source.Where<GClass9>(func_8).ToList<GClass9>();
            }
            int num2 = 0;
            if (!this.ckAnchorTitle.Checked && (!this.ckAnchorNofollow.Checked && (!this.ckAnchorError.Checked && (!this.ckAnchorExternal.Checked && !this.ckAnchorImage.Checked))))
            {
                foreach (GClass9 class2 in this.list_8)
                {
                    num++;
                    num2 += class2.method_2();
                    object[] values = new object[] { class2.method_0(), class2.method_10(), class2.method_2(), class2.method_4(), class2.method_6(), class2.method_8(), class2.method_14(), class2.method_12(), class2.method_16() };
                    this.dtvAnalyticsLink.Rows.Add(values);
                }
            }
            else
            {
                foreach (GClass9 class3 in source)
                {
                    num++;
                    num2 += class3.method_2();
                    object[] values = new object[] { class3.method_0(), class3.method_10(), class3.method_2(), class3.method_4(), class3.method_6(), class3.method_8(), class3.method_14(), class3.method_12(), class3.method_16() };
                    this.dtvAnalyticsLink.Rows.Add(values);
                }
            }
            string[] strArray = new string[] { num.ToString(), " Li\x00ean kết - Từ kho\x00e1 lặp \"", this.txtKeywordAnalytics.Text.Trim(), "\": ", num2.ToString() };
            this.lbAnalyticsAnchor.Text = string.Concat(strArray);
        }

        private void method_18(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_19(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_2()
        {
            MethodInvoker invoker2 = null;
            try
            {
                string path = string.Empty;
                string str2 = string.Empty;
                StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                StreamWriter writer = new StreamWriter(path + "_LIVE.txt");
                StreamWriter writer2 = new StreamWriter(path + "_DIE.txt");
                methodInvoker_0 ??= new MethodInvoker(frmMain.smethod_2);
                MethodInvoker method = methodInvoker_0;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                string str4 = string.Empty;
                int num = 0;
                while (true)
                {
                    if (reader.Peek() < 0)
                    {
                        writer.Close();
                        writer2.Close();
                        reader.Close();
                        invoker2 ??= new MethodInvoker(this.method_112);
                        method = invoker2;
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(method);
                        }
                        else
                        {
                            method();
                        }
                        break;
                    }
                    string str3 = reader.ReadLine().Replace("$domain$", str2.Trim());
                    string str5 = this.gclass4_0.method_24(str3);
                    string str6 = str4;
                    string[] strArray = new string[] { str6, str5, " - ", str3, "\n" };
                    str4 = string.Concat(strArray);
                    if (str5.Equals("OK!"))
                    {
                        writer.WriteLine(str3);
                        writer.Flush();
                    }
                    else
                    {
                        writer2.WriteLine(str3);
                        writer2.Flush();
                    }
                    num++;
                    methodInvoker_1 ??= new MethodInvoker(frmMain.smethod_3);
                    method = methodInvoker_1;
                    if (base.InvokeRequired)
                    {
                        base.BeginInvoke(method);
                    }
                    else
                    {
                        method();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file!", "File Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void method_20(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_21(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_22(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_23(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_24(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_25(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void method_26()
        {
            if (this.cbKeyCate.SelectedValue != null)
            {
                this.dtvKeyLogs.Rows.Clear();
                foreach (DataRow row in this.gclass4_0.method_40("SELECT * FROM Keywords WHERE CategoryID = '" + this.cbKeyCate.SelectedValue + "' ORDER BY [Key]").Rows)
                {
                    object[] values = new object[] { row["KeywordID"].ToString(), row["Key"].ToString(), row["Website"].ToString(), row["SERP"].ToString(), row["Top"].ToString(), row["TopOld"].ToString(), row["Lang"].ToString(), row["Ext"].ToString(), row["Compare"].ToString() };
                    int num = this.dtvKeyLogs.Rows.Add(values);
                    this.dtvKeyLogs.Rows[num].Tag = row;
                }
            }
        }

        private void method_27()
        {
            this.method_33(this.dtvResultCheck, true);
            MethodInvoker method = new MethodInvoker(this.method_116);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_28(string string_7)
        {
            try
            {
                Stream stream;
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "Text Files (*.txt)|*.txt",
                    Title = "Type File"
                };
                string[] strArray = string_7.Split(new char[] { '\n' });
                if ((dialog.ShowDialog() == DialogResult.OK) && ((stream = dialog.OpenFile()) != null))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    string[] strArray2 = strArray;
                    int index = 0;
                    while (true)
                    {
                        if (index >= strArray2.Length)
                        {
                            writer.Flush();
                            stream.Close();
                            MessageBox.Show("Ghi File th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            break;
                        }
                        string str = strArray2[index];
                        writer.WriteLine(str);
                        index++;
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_29(string string_7)
        {
            try
            {
                Stream stream;
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "Web HTML Files (*.html)|*.html",
                    Title = "Type File"
                };
                if ((dialog.ShowDialog() == DialogResult.OK) && ((stream = dialog.OpenFile()) != null))
                {
                    new StreamWriter(stream, Encoding.UTF8).Write(string_7);
                    stream.Close();
                    MessageBox.Show("Ghi File th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_3(object object_0)
        {
            try
            {
                string hostNameOrAddress = object_0.ToString();
                List<Class7> collection = new List<Class7> {
                    new Class7("[" + hostNameOrAddress + "]", ""),
                    new Class7("->IP: " + Dns.GetHostAddresses(hostNameOrAddress)[0].ToString(), ""),
                    new Class7("->File Robots: " + this.gclass4_0.method_24("http://" + hostNameOrAddress + "/robots.txt"), "http://" + hostNameOrAddress + "/robots.txt"),
                    new Class7("->File Sitemap.xml: " + this.gclass4_0.method_24("http://" + hostNameOrAddress + "/sitemap.xml"), "http://" + hostNameOrAddress + "/sitemap.xml")
                };
                lock (this.list_2)
                {
                    this.list_2.AddRange(collection);
                }
                this.int_1--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_30()
        {
            this.method_33(this.dtvAnalytics, true);
            MethodInvoker method = new MethodInvoker(this.method_117);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_31(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.picLoader.Hide();
        }

        private void method_32()
        {
            this.method_33(this.dtvSuggest, true);
            MethodInvoker method = new MethodInvoker(this.method_119);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_33(DataGridView dataGridView_0, bool bool_9)
        {
            string[] strArray = new string[dataGridView_0.ColumnCount];
            string[] strArray2 = new string[dataGridView_0.ColumnCount];
            int num = 0;
            int index = 0;
            try
            {
                index = 0;
                while (true)
                {
                    if (index > (dataGridView_0.ColumnCount - 1))
                    {
                        object obj7;
                        object[] objArray;
                        object target = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
                        object obj4 = target.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, target, null);
                        object obj3 = obj4.GetType().InvokeMember("Add", BindingFlags.InvokeMethod, null, obj4, null);
                        object obj5 = obj3.GetType().InvokeMember("Worksheets", BindingFlags.GetProperty, null, obj3, null);
                        object obj6 = obj5.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, obj5, new object[] { 1 });
                        if (bool_9)
                        {
                            index = 0;
                            while (index <= (dataGridView_0.ColumnCount - 1))
                            {
                                objArray = new object[] { strArray2[index] + "1", Missing.Value };
                                obj7 = obj6.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, obj6, objArray);
                                obj7.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, obj7, new object[] { strArray[index] });
                                index++;
                            }
                        }
                        num = 0;
                        while (true)
                        {
                            if (num >= dataGridView_0.RowCount)
                            {
                                objArray = new object[] { true };
                                target.GetType().InvokeMember("Visible", BindingFlags.SetProperty, null, target, objArray);
                                target.GetType().InvokeMember("UserControl", BindingFlags.SetProperty, null, target, objArray);
                                break;
                            }
                            index = 0;
                            while (true)
                            {
                                if (index > (dataGridView_0.ColumnCount - 1))
                                {
                                    num++;
                                    break;
                                }
                                objArray = new object[] { strArray2[index] + Convert.ToString((int) (num + 2)), Missing.Value };
                                obj7 = obj6.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, obj6, objArray);
                                obj7.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, obj7, new object[] { dataGridView_0.Rows[num].Cells[strArray[index]].Value.ToString() });
                                index++;
                            }
                        }
                        break;
                    }
                    strArray[index] = dataGridView_0.Rows[0].Cells[index].OwningColumn.Name.ToString();
                    if (index < 0x1a)
                    {
                        strArray2[index] = Convert.ToString((char) (index + 0x41));
                    }
                    else
                    {
                        num = (index % 0x1a) + 0x41;
                        strArray2[index] = Convert.ToString((char) (((index / 0x1a) - 1) + 0x41)) + Convert.ToString((char) num);
                    }
                    index++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(("Error: " + exception.Message) + " Line: " + exception.Source, "Error");
            }
        }

        private void method_34()
        {
            try
            {
                MethodInvoker invoker;
                Class26 class3 = new Class26 {
                    frmMain_0 = this
                };
                string str = this.txtKeyResearch.Text.Trim();
                string str2 = this.txtLangSuggest.Text.Trim();
                string str3 = this.txtExtSuggest.Text.Trim();
                string str4 = "<p>Từ kho\x00e1 Google Search</p>";
                string str5 = this.gclass4_0.method_38("http://www.google." + str3 + "/search?hl=" + str2 + "+&q=" + str);
                string str6 = this.gclass4_0.method_15("<div id=\"botstuff\">(?<Content>.*?)</div></div>", str5);
                foreach (string str7 in this.gclass4_0.method_20("<p>(?<Content>.*?)</p>", str6))
                {
                    str4 = str4 + str7.Replace("<a href=\"/search", "<a target=\"_blank\" href=\"http://www.google." + str3 + "/search");
                }
                string str8 = this.gclass4_0.method_38("http://clients1.google.com/complete/search?client=youtube&hl=" + str2 + "&q=" + str);
                str4 = str4 + "<p>Từ kho\x00e1 YouTube</p>";
                Regex regex = new Regex("\"(?<Content>.*?)\"", RegexOptions.Singleline);
                foreach (string str9 in this.gclass4_0.method_20("\\[\"(?<Content>.*?)\"", str8))
                {
                    string str10 = this.gclass4_0.method_16(regex, str9);
                    string str11 = str4;
                    string[] strArray2 = new string[] { str11, "<p><a target=\"_blank\" href=\"http://www.youtube.com/results?hl=", str2, "&search_query=", str10, "\">", str10, "</a><p>" };
                    str4 = string.Concat(strArray2);
                }
                this.webKeyRelated.DocumentText = "<html><head>\r\n                    <style>\r\n                    body{font-family:Arial, Helvetica, sans-serif; font-size:13px;}\r\n                    p{padding:2px 0; margin:0;}\r\n                    </style>\r\n                    </head><body>" + str4 + "</body></html>";
                str4 = string.Empty;
                this.list_3 = new List<Class11>();
                this.int_2 = -1;
                string[] strArray3 = new string[] { "http://www.google.", str3, "/complete/search?hl=", str2, "&output=toolbar&q=", str };
                this.string_3 = string.Concat(strArray3);
                this.method_35();
                if (this.int_2 != 0x194)
                {
                    this.int_2 = 0;
                    int num = 0;
                    while (true)
                    {
                        if (num < 10)
                        {
                            new Thread(new ThreadStart(this.method_35)) { IsBackground = true }.Start();
                            num++;
                            continue;
                        }
                        while (true)
                        {
                            if (this.int_2 < this.string_4.Length)
                            {
                                Thread.Sleep(0x3e8);
                                continue;
                            }
                            class3.int_0 = 1;
                            invoker = new MethodInvoker(class3.method_0);
                            if (base.InvokeRequired)
                            {
                                base.BeginInvoke(invoker);
                            }
                            else
                            {
                                invoker();
                            }
                            Thread.Sleep(100);
                            if (class3.int_0 != 2)
                            {
                                goto TR_000B;
                            }
                            else
                            {
                                this.list_4 = new List<Class11>();
                                foreach (Class11 class2 in this.list_3)
                                {
                                    this.list_4.Add(class2);
                                }
                                this.int_2 = -2;
                                this.int_3 = 0;
                                string[] strArray4 = new string[] { "http://www.google.", str3, "/complete/search?hl=", str2, "&output=toolbar&q=" };
                                this.string_3 = string.Concat(strArray4);
                                int num2 = 0;
                                while (true)
                                {
                                    if (num2 >= this.list_4.Count)
                                    {
                                        break;
                                    }
                                    int num3 = 0;
                                    while (true)
                                    {
                                        if ((num3 < 10) && (this.int_2 != 0x194))
                                        {
                                            new Thread(new ThreadStart(this.method_35)) { IsBackground = true }.Start();
                                            if ((num2 + 1) < this.list_4.Count)
                                            {
                                                num3++;
                                                continue;
                                            }
                                        }
                                        if (this.int_2 != 0x194)
                                        {
                                            while (((this.int_3 % 10) != 0) && (num2 < this.list_4.Count))
                                            {
                                                Thread.Sleep(100);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Lượng truy cập qu\x00e1 nhiều! H\x00e3y tạm dừng 1 ph\x00fat rồi thử lại!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                            break;
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                        break;
                    }
                    goto TR_000F;
                }
                else
                {
                    MessageBox.Show("Lượng truy cập qu\x00e1 nhiều! H\x00e3y tạm dừng 1 ph\x00fat rồi thử lại!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return;
            TR_000B:
                if (func_10 == null)
                {
                    func_10 = new Func<Class11, short>(frmMain.smethod_16);
                }
                func_11 ??= new Func<Class11, long>(frmMain.smethod_17);
                this.list_3 = this.list_3.OrderBy<Class11, short>(func_10).OrderByDescending<Class11, long>(func_11).ToList<Class11>();
                class3.list_0 = new List<Class12>();
                func_12 ??= new Func<Class12, short>(frmMain.smethod_18);
                class3.list_0 = class3.list_0.OrderByDescending<Class12, short>(func_12).ToList<Class12>();
                invoker = new MethodInvoker(class3.method_1);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(invoker);
                }
                else
                {
                    invoker();
                }
                return;
            TR_000F:
                while ((this.int_3 < this.list_4.Count) && (this.int_2 != 0x194))
                {
                    Thread.Sleep(0x3e8);
                }
                goto TR_000B;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_35()
        {
            while (true)
            {
                while (true)
                {
                    string str;
                    lock (this.string_4)
                    {
                        if (this.int_2 == -1)
                        {
                            str = this.string_3;
                        }
                        else if (this.int_2 == -2)
                        {
                            str = this.string_3 + " " + this.list_4[this.int_3].method_0();
                            this.int_3++;
                        }
                        else
                        {
                            str = this.string_3 + " " + this.string_4[this.int_2];
                            this.int_2++;
                        }
                    }
                    try
                    {
                        XmlDocument document = new XmlDocument();
                        string str2 = this.gclass4_0.method_38(str);
                        if (!string.IsNullOrEmpty(str2))
                        {
                            document.LoadXml(str2.Replace("&", "&amp;"));
                            short num = 1;
                            using (IEnumerator enumerator = document.SelectNodes("//CompleteSuggestion").GetEnumerator())
                            {
                                Predicate<Class11> match = null;
                                Class29 class3 = new Class29();
                                while (enumerator.MoveNext())
                                {
                                    class3.xmlNode_0 = (XmlNode) enumerator.Current;
                                    lock (this.list_3)
                                    {
                                        if (match == null)
                                        {
                                            match = new Predicate<Class11>(class3.method_0);
                                        }
                                        int num2 = this.list_3.FindIndex(match);
                                        if (num2 >= 0)
                                        {
                                            Class11 local1 = this.list_3[num2];
                                            local1.method_5((short) (local1.method_4() + 1));
                                        }
                                        else
                                        {
                                            Class11 item = new Class11();
                                            item.method_1(class3.xmlNode_0.SelectSingleNode("suggestion/@data").InnerText);
                                            item.method_3((class3.xmlNode_0.SelectSingleNode("num_queries/@int") != null) ? Convert.ToInt64(class3.xmlNode_0.SelectSingleNode("num_queries/@int").InnerText) : 0L);
                                            item.method_7(num);
                                            this.list_3.Add(item);
                                            num = (short) (num + 1);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            this.int_2 = 0x194;
                            return;
                        }
                    }
                    catch
                    {
                    }
                    break;
                }
                if ((this.int_2 <= -1) || (this.int_2 >= this.string_4.Length))
                {
                    return;
                }
            }
        }

        private void method_36()
        {
            while (this.int_4 > 0)
            {
                Thread.Sleep(0x3e8);
            }
            MessageBox.Show("Ping Index th\x00e0nh c\x00f4ng! Xin h\x00e3y đợt trong v\x00e0i ph\x00fat!", "Ping result!");
            MethodInvoker method = new MethodInvoker(this.method_120);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_37()
        {
            while (this.int_5 < this.list_5.Count)
            {
                string str = "";
                lock (this.list_5)
                {
                    int num;
                    this.int_5 = (num = this.int_5) + 1;
                    str = this.list_5[num];
                }
                GClass17 class2 = new GClass17();
                WebProxy proxy = null;
                List<string> list = this.txtPingProxy.Text.Trim().Split(new char[] { ':' }).ToList<string>();
                if (list.Count == 2)
                {
                    proxy = new WebProxy(list[0], Convert.ToInt32(list[1]));
                }
                GClass16 class3 = new GClass16();
                foreach (string str2 in this.list_6)
                {
                    if (!string.IsNullOrEmpty(str2))
                    {
                        class3.method_1(str, this.txtPingTitle.Text.Trim(), str2, proxy);
                        class2.method_1(str2);
                        class2.method_3(str2);
                        class3.method_3(class2);
                    }
                }
            }
            this.int_4--;
        }

        private void method_38()
        {
            MethodInvoker invoker2 = null;
            try
            {
                MethodInvoker invoker;
                GClass15 class2 = new GClass15 {
                    webProxy_0 = this.gclass4_0.webProxy_0
                };
                foreach (string str in list_0)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        Class30 class3 = new Class30 {
                            frmMain_0 = this,
                            string_0 = str.Trim()
                        };
                        class3.int_0 = class2.method_3(class3.string_0);
                        invoker = new MethodInvoker(class3.method_0);
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(invoker);
                            continue;
                        }
                        invoker();
                    }
                }
                invoker2 ??= new MethodInvoker(this.method_121);
                invoker = invoker2;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(invoker);
                }
                else
                {
                    invoker();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error list Link", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void method_39(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.method_99();
            WebBrowser browser = sender as WebBrowser;
            string str = browser.Url.ToString();
            HtmlDocument document = browser.Document;
            if (str.IndexOf("plus.google.com") > 0)
            {
                foreach (HtmlElement element2 in document.GetElementsByTagName("div"))
                {
                    if ((element2.OuterHtml.IndexOf("sharebutton") > 0) && (element2.OuterHtml.LastIndexOf("<div>") == 0))
                    {
                        element2.InvokeMember("click");
                    }
                }
            }
            else
            {
                HtmlElement elementById;
                if (str.IndexOf("linkhay.com") > 0)
                {
                    elementById = document.GetElementById("channels");
                    if (elementById != null)
                    {
                        elementById.SetAttribute("value", "10");
                    }
                }
                if (str.IndexOf("stumbleupon.com") > 0)
                {
                    elementById = document.GetElementById("tags");
                    if (elementById != null)
                    {
                        elementById.SetAttribute("value", "Weblogs");
                    }
                    elementById = document.GetElementById("nsfw");
                    if (elementById != null)
                    {
                        elementById.SetAttribute("checked", "checked");
                    }
                    foreach (HtmlElement element3 in document.GetElementsByTagName("button"))
                    {
                        if (element3.OuterHtml.IndexOf("type=submit") > 0)
                        {
                            element3.InvokeMember("click");
                        }
                    }
                }
                else if (str.IndexOf("tumblr.com") > 0)
                {
                    foreach (HtmlElement element4 in document.GetElementsByTagName("input"))
                    {
                        if (element4.OuterHtml.IndexOf("type=submit") > 0)
                        {
                            element4.InvokeMember("click");
                        }
                    }
                }
                else if (str.IndexOf("delicious.com") > 0)
                {
                    foreach (HtmlElement element5 in document.GetElementsByTagName("a"))
                    {
                        if (element5.OuterHtml.IndexOf("green-txt") > 0)
                        {
                            element5.InvokeMember("click");
                        }
                    }
                }
                else if (str.IndexOf("diigo.com") > 0)
                {
                    foreach (HtmlElement element6 in document.GetElementsByTagName("a"))
                    {
                        if (element6.OuterHtml.IndexOf("promptButton") > 0)
                        {
                            element6.InvokeMember("click");
                        }
                    }
                }
                else if (str.IndexOf("linkedin.com") > 0)
                {
                    foreach (HtmlElement element7 in document.GetElementsByTagName("input"))
                    {
                        if (element7.OuterHtml.IndexOf("type=submit") > 0)
                        {
                            element7.InvokeMember("click");
                        }
                    }
                }
                else
                {
                    foreach (HtmlElement element8 in browser.Document.GetElementsByTagName("input"))
                    {
                        if (element8.GetAttribute("name").Equals("share") || (element8.GetAttribute("value").Equals("Tweet") || (element8.GetAttribute("name").Equals("link_submit") || element8.GetAttribute("name").Equals("Button"))))
                        {
                            element8.InvokeMember("click");
                        }
                    }
                }
            }
        }

        private void method_4(object object_0)
        {
            try
            {
                GClass15 class2 = new GClass15();
                List<Class7> collection = new List<Class7> {
                    new Class7("[RageRank]", ""),
                    new Class7("->Goolge PageRank: " + class2.method_3(object_0.ToString()).ToString() + "/10", "")
                };
                lock (this.list_2)
                {
                    this.list_2.AddRange(collection);
                }
                this.int_1--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_40()
        {
            DataTable table = this.gclass4_0.method_40("SELECT CategoryID, Name FROM Categories WHERE Code = 'KEY' ORDER BY Name");
            this.cbKeyCate.DataSource = table;
            this.cbKeyCate.ValueMember = "CategoryID";
            this.cbKeyCate.DisplayMember = "Name";
        }

        private void method_41()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'BACKLINK' AND Name LIKE '%" + this.txtBacklinkCate.Text.Trim() + "%' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvBacklinkCate.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["CategoryID"].ToString(), row["Name"].ToString() };
                int num = this.dtvBacklinkCate.Rows.Add(values);
                this.dtvBacklinkCate.Rows[num].Tag = row;
            }
        }

        private void method_42()
        {
            try
            {
                string str = "SELECT * FROM Backlinks WHERE CategoryID='" + this.dtvBacklinkCate.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY BacklinkID DESC";
                if (this.bool_3)
                {
                    string[] strArray = new string[] { "SELECT * FROM Backlinks WHERE CategoryID='", this.dtvBacklinkCate.CurrentRow.Cells[0].Value.ToString(), "' AND Url AND LIKE '%", this.txtBacklinkUrl.Text.Trim(), "%' AND Weblink LIKE '%", this.txtBacklinkWeblink.Text.Trim(), "%' ORDER BY BacklinkID DESC" };
                    str = string.Concat(strArray);
                }
                DataTable table = this.gclass4_0.method_40(str);
                this.dtvBacklink.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    object[] values = new object[] { row["BacklinkID"].ToString(), row["AName"].ToString(), row["ATitle"].ToString(), row["Url"].ToString(), row["Weblink"].ToString(), row["PR"].ToString(), row["Rel"].ToString(), row["Compare"].ToString(), row["Index"].ToString() };
                    int num = this.dtvBacklink.Rows.Add(values);
                    this.dtvBacklink.Rows[num].Tag = row;
                }
            }
            catch
            {
            }
        }

        private void method_43()
        {
            while (this.int_7 > 0)
            {
                Thread.Sleep(0x3e8);
            }
            MethodInvoker method = new MethodInvoker(this.method_122);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_44()
        {
            try
            {
                while (this.list_7.Count > this.int_6)
                {
                    Class14 class2;
                    lock (this.list_7)
                    {
                        int num5;
                        this.int_6 = (num5 = this.int_6) + 1;
                        class2 = this.list_7[num5];
                    }
                    string str = this.gclass4_0.method_38(class2.method_4());
                    string input = this.gclass4_0.method_38(class2.method_6());
                    int num = 0;
                    string str3 = string.Empty;
                    string str4 = string.Empty;
                    string str5 = string.Empty;
                    MatchCollection matchs = new Regex("<a(?<Content>.*?)/a>", RegexOptions.Singleline).Matches(input);
                    GClass15 class3 = new GClass15();
                    Regex regex2 = new Regex("rel=\"(?<Content>.*?)\"", RegexOptions.Singleline);
                    Regex regex3 = new Regex(">(?<Content>.*?)<", RegexOptions.Singleline);
                    Regex regex4 = new Regex("title=\"(?<Content>.*?)\"", RegexOptions.Singleline);
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 >= matchs.Count)
                        {
                            decimal num3;
                            string[] strArray = new string[] { "http://www.google.com/search?hl=vi&q=site:", class2.method_6(), " %2B %22", str4, "%22" };
                            string str8 = string.Concat(strArray);
                            num3 = num3 = this.gclass4_0.method_7(this.gclass4_0.method_38(str8));
                            if (new Regex("<meta([ \\w\\d\"=,']*)(nofollow)+([ \\w\\d\"=,']*)/>", RegexOptions.Singleline).Matches(input).Count > 0)
                            {
                                str5 = "nofollow";
                            }
                            decimal num4 = this.gclass4_0.method_45(this.gclass4_0.method_33(str), this.gclass4_0.method_33(input));
                            object[] objArray = new object[] { "UPDATE Backlinks SET PR=", class3.method_3(class2.method_6()), ", AName='", str4, "',ATitle='", str3, "',Rel='", str5, "', [Index]=" };
                            objArray[9] = num3.ToString();
                            objArray[10] = ", [Compare]=";
                            objArray[11] = num4.ToString();
                            objArray[12] = ",loop=";
                            objArray[13] = num.ToString();
                            objArray[14] = " WHERE BacklinkID='";
                            objArray[15] = class2.method_0();
                            objArray[0x10] = "'";
                            this.gclass4_0.method_42(string.Concat(objArray));
                            break;
                        }
                        string str7 = matchs[num2].Groups["Content"].ToString();
                        if (str7.IndexOf(class2.method_4()) > 0)
                        {
                            str5 = (this.gclass4_0.method_16(regex2, str7).IndexOf("nofollow") <= 0) ? "follow" : "nofollow";
                            str4 = this.gclass4_0.method_16(regex3, str7);
                            str3 = this.gclass4_0.method_16(regex4, str7);
                            num++;
                        }
                        num2++;
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.int_7--;
        }

        private void method_45()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'ARTICLE' AND Name LIKE '%" + this.txtArticleCate.Text.Trim() + "%' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvArticleCate.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["CategoryID"].ToString(), row["Name"].ToString() };
                int num = this.dtvArticleCate.Rows.Add(values);
                this.dtvArticleCate.Rows[num].Tag = row;
            }
        }

        private void method_46()
        {
            try
            {
                this.dtvArticle.Rows.Clear();
                string str = "SELECT * FROM Articles WHERE CategoryID='" + this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY ArticleID DESC";
                if (this.ckFollow.Checked)
                {
                    str = "SELECT * FROM Articles WHERE CategoryID='" + this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString() + "' AND Follow=True ORDER BY ArticleID DESC";
                }
                if (this.bool_3 && this.ckFollow.Checked)
                {
                    string[] strArray = new string[] { "SELECT * FROM Articles WHERE CategoryID='", this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString(), "' AND Follow=True AND Url LIKE '%", this.txtArticleLink.Text.Trim(), "%' ORDER BY ArticleID DESC" };
                    str = string.Concat(strArray);
                }
                else if (this.bool_3)
                {
                    string[] strArray2 = new string[] { "SELECT * FROM Articles WHERE CategoryID='", this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString(), "' AND Url LIKE '%", this.txtArticleLink.Text.Trim(), "%' ORDER BY ArticleID DESC" };
                    str = string.Concat(strArray2);
                }
                foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
                {
                    object[] values = new object[] { row["ArticleID"].ToString(), row["Url"].ToString() };
                    values[2] = row["Current"].ToString().Equals(row["Before"].ToString()) ? Resources.smethod_17() : Resources.smethod_16();
                    values[3] = row["Current"].ToString();
                    values[4] = row["Before"].ToString();
                    values[5] = row["Follow"].ToString();
                    int num = this.dtvArticle.Rows.Add(values);
                    this.dtvArticle.Rows[num].Tag = row;
                    if (!row["Current"].ToString().Equals(row["Before"].ToString()))
                    {
                        this.bool_2 = true;
                        this.int_8++;
                    }
                }
            }
            catch
            {
            }
        }

        private void method_47(object object_0)
        {
            DataRow row = (DataRow) object_0;
            string str = string.Empty;
            if (this.ckTopMobile.Checked)
            {
                str = "&source=mobileproducts";
            }
            GClass14 class2 = this.gclass4_0.method_12(row["Key"].ToString(), row["Website"].ToString(), row["Lang"].ToString(), row["Ext"].ToString(), str);
            this.gclass4_0.method_42("UPDATE Keywords SET TopOld=[Top], [Top]=" + class2.int_0.ToString() + ", [SERP]=" + class2.decimal_0.ToString() + " WHERE KeywordID ='" + row["KeywordID"].ToString() + "'");
            this.int_9--;
        }

        private void method_48()
        {
            // Invalid method body.
        }

        private void method_49()
        {
            Thread.Sleep(new Random().Next(0x927c0, 0x36ee80));
            this.infoSEO_0.CPUID = this.gclass4_0.method_29();
            string str = "<RSAKeyValue><Modulus>wFEjE5yiTXL3r8n9QQvpXgSbuEYwGQXxFpBZrLQct8ENPUInhxr/ywSjMj3UfUWow75qvE7ccIZN+DroPNDcIrr596PO2ztOVRxuPaikTpC1H0xldvpR3p3sLpfH+e9NMXS40ACh11irux5JTx1qbNiriucrT2BASPuNR2dmC4s=</Modulus><Exponent>AQAB</Exponent><P>/vvf9WSuOYwCfhd24ymEDBPzu28spX0Jq6UxeYVEa1EBWIRgjUCs3TuSluYSlJ7uShAhUTyZwdvuDbbCpl9Rbw==</P><Q>wRVU6INfs/198fjA2TusUg/QtFq8VmqJpTAUmPsqDanJlecW1g4CwHKzX1+KAWgkjBke3LVPHW/p3t0PNtzhpQ==</Q><DP>0kmlxXrYGQu4DoeJfAUEKvXVgBJLDtxVOmMNr3vSFnODGZ5rBnN9XSNBXQO39Swxt5Ef+SByaifYZyT/2TgpLw==</DP><DQ>a4/TnjfZb66Oo+a8oAezJn/y9xX5B3cQOPrA7rw0oCnux9hVi2eAtu7u5/mUKtZ2TamM3M0QRsjakzG40QpZlQ==</DQ><InverseQ>pAOfuf0RikJ1vIyTIfGBVTP9vxl6DNavbqd/0g7UCz38bH/qeEmhdZhCSlUFswG95do6snWexpobyLsmoEeYpg==</InverseQ><D>gX7g0Jbazq3ITC0Fg6QiqnUN6cIRJvhSQzBFwb2xzKWIZaRC+31ZmflwbicmCog6QDvaoRu04Wv92lTIBhNY9jgdPPGHHNzt2YqK8RAH3CyOpZEAiVczearZ7w23hBfTGkf6kt20nX8Spa2g97ikVHp2Axy/ot7YObysitHSpXk=</D></RSAKeyValue>";
            string str2 = "<RSAKeyValue><Modulus>keuFw++iHf6aXfHGpvEJ9ReFx1GTmbppEk2YehoUFU8W3zAjk8BjpM2e+t6FG9fDv+skvr/j2q+SjjKUvK1rXAEYLVt56SHE1PD8UxP8QP0N/vQd2eddEqp1BBqynLp1c8EWze7nI9NSfMQSHghZZVI6WjhZmbzw/JWMULBtbKs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            this.infoSEO_0.Password = this.gclass18_0.method_0(this.infoSEO_0.Password, 0x400, str2);
            this.infoSEO_0 = this.iSEOSoapClient_0.CheckLoginISEO(this.infoSEO_0);
            this.infoSEO_0.Password = this.gclass18_0.method_2(this.infoSEO_0.Password, 0x400, str);
            if (!string.IsNullOrEmpty(this.infoSEO_0.Permission))
            {
                this.infoSEO_0.Permission = this.gclass18_0.method_2(this.infoSEO_0.Permission, 0x400, str);
            }
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission) && string.IsNullOrEmpty(this.infoSEO_0.Permission))
            {
                Application.Exit();
            }
        }

        private void method_5(object object_0)
        {
            try
            {
                string str = object_0.ToString();
                List<Class7> collection = new List<Class7> {
                    new Class7("[GoogleLinks]", "http://www.google.com/search?hl=vi&q=link:" + str),
                    new Class7("->Google Links: " + this.gclass4_0.method_7(this.gclass4_0.method_38("http://www.google.com/search?hl=vi&q=link:" + str)), "")
                };
                lock (this.list_2)
                {
                    this.list_2.AddRange(collection);
                }
                this.int_1--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_50()
        {
            while (this.int_10 < this.list_8.Count)
            {
                int num;
                lock (this.list_8)
                {
                    int num2;
                    this.int_10 = (num2 = this.int_10) + 1;
                    num = num2;
                }
                if ("OK!".Equals(this.gclass4_0.method_24(this.list_8[num].method_4())))
                {
                    this.list_8[num].method_15("OK!");
                }
                else
                {
                    this.list_8[num].method_15("Error!");
                }
            }
            this.int_11--;
        }

        private void method_51()
        {
            while (this.int_11 > 0)
            {
                Thread.Sleep(0x3e8);
            }
            MethodInvoker method = new MethodInvoker(this.method_124);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_52(object sender, EventArgs e)
        {
            try
            {
                frmBrowser browser = new frmBrowser();
                browser.webBrowser.Navigate("http://www.google.com/search?hl=" + this.txtLang.Text.Trim() + "&q=" + HttpUtility.UrlEncode(this.txtKeyword.Text.Trim()) + "&adtest=on");
                browser.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn h\x00e3y lựa chọn từ kh\x00f3a!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void method_53()
        {
            Class32 class2 = new Class32 {
                frmMain_0 = this
            };
            string str2 = this.gclass4_0.method_38("http://www.alexa.com/siteinfo/" + this.txtRivalDomain.Text.Trim());
            List<string> list = this.gclass4_0.method_20("<tr>(?<Content>.*?)</tr>", str2);
            class2.list_0 = this.gclass4_0.method_49(list, "p=\"rkey\"", "<td(?<Content>.*?)</td>");
            class2.list_1 = this.gclass4_0.method_49(list, "class=\"number positive\"", "<td(?<Content>.*?)</td>");
            class2.list_2 = this.gclass4_0.method_49(list, "class=\"number negative\"", "<td(?<Content>.*?)</td>");
            class2.list_3 = this.gclass4_0.method_49(list, "p=\"sempromokey\"", "<td(?<Content>.*?)</td>");
            class2.list_4 = this.gclass4_0.method_48(list, "class=\"alignright\"", "<td(?<Content>.*?)</td>");
            MethodInvoker method = new MethodInvoker(class2.method_0);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        public void method_54()
        {
            MethodInvoker invoker2 = null;
            try
            {
                string str = this.txtWebsiteUrl.Text.Trim();
                string str2 = this.txtWebsiteUrl2.Text.Trim();
                if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("H\x00e3y nhập đường dẫn URL1 v\x00e0 URL2!", "Error!");
                }
                else
                {
                    if (str.IndexOf("http") < 0)
                    {
                        str = "http://" + str;
                    }
                    if (str2.IndexOf("http") < 0)
                    {
                        str2 = "http://" + str2;
                    }
                    string str3 = this.gclass4_0.method_33(this.gclass4_0.method_38(str).ToLower());
                    MessageBox.Show("Nội dung URL1 so với URL2 l\x00e0: " + this.gclass4_0.method_45(str3, this.gclass4_0.method_33(this.gclass4_0.method_38(str2).ToLower())).ToString() + "%", "Result!");
                }
                invoker2 ??= new MethodInvoker(this.method_125);
                MethodInvoker method = invoker2;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_55()
        {
            try
            {
                while (this.list_9.Count > this.int_12)
                {
                    Class15 class2;
                    lock (this.list_9)
                    {
                        int num2;
                        this.int_12 = (num2 = this.int_12) + 1;
                        class2 = this.list_9[num2];
                    }
                    int num = this.gclass4_0.method_1(class2.method_4());
                    if (num > 0)
                    {
                        object[] objArray = new object[] { "UPDATE Articles SET [Current]=", num, ", [Before]=IIF([Current]=", num, ", [Before],[Current]) WHERE ArticleID='", class2.method_0(), "'" };
                        string str = string.Concat(objArray);
                        this.gclass4_0.method_42(str);
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.int_13--;
        }

        private void method_56()
        {
            while (this.int_13 > 0)
            {
                Thread.Sleep(0x3e8);
            }
            MethodInvoker method = new MethodInvoker(this.method_126);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_57()
        {
            while (this.int_13 > 0)
            {
                Thread.Sleep(0x3e8);
            }
            MethodInvoker method = new MethodInvoker(this.method_127);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_58()
        {
            DataTable table = this.gclass4_0.method_40("SELECT AttributeID, Name FROM Attributes ORDER BY Name");
            this.cbAttributeCate.DataSource = table;
            this.cbAttributeCate.ValueMember = "AttributeID";
            this.cbAttributeCate.DisplayMember = "Name";
        }

        private void method_59()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'SUBMIT' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.cbSubmitCate.DataSource = table;
            this.cbSubmitCate.ValueMember = "CategoryID";
            this.cbSubmitCate.DisplayMember = "Name";
        }

        private void method_6(object object_0)
        {
            try
            {
                string str = object_0.ToString();
                Match match = new Regex("hiển thị v\x00e0o (?<Cache>.*?). <a", RegexOptions.Singleline).Match(this.gclass4_0.method_38("http://www.google.com/search?hl=vi&q=site:" + str));
                List<Class7> collection = new List<Class7> {
                    new Class7("[Pages Indexed]", ""),
                    new Class7("->Google Indexed: " + this.gclass4_0.method_7(this.gclass4_0.method_38("http://www.google.com/search?hl=vi&q=site:" + str)), "http://www.google.com/search?hl=vi&q=site:" + str)
                };
                match = new Regex("<span class=\"sb_count\" id=\"count\">(?<Content>.*?)</span>", RegexOptions.Singleline).Match(this.gclass4_0.method_38("http://www.bing.com/search?q=site:" + str));
                collection.Add(new Class7("->Bing.com Indexed: " + match.Groups["Content"].Value, "http://www.bing.com/search?q=site:" + str));
                lock (this.list_2)
                {
                    this.list_2.AddRange(collection);
                }
                this.int_1--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_60()
        {
            try
            {
                this.dtvSubmit.Rows.Clear();
                string str = "SELECT * FROM Submits WHERE CategoryID='" + this.cbSubmitCate.SelectedValue + "' ORDER BY SubmitID DESC";
                if (this.bool_3)
                {
                    object[] objArray = new object[] { "SELECT * FROM Submits WHERE CategoryID='", this.cbSubmitCate.SelectedValue, "' AND Url LIKE '%", this.txtArticleLink.Text.Trim(), "%' AND AttributeID = '", this.cbAttributeCate.SelectedValue, "' ORDER BY SubmitID DESC" };
                    str = string.Concat(objArray);
                }
                foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
                {
                    object[] values = new object[] { row["SubmitID"].ToString(), row["Url"].ToString(), row["AttributeID"].ToString() };
                    int num = this.dtvSubmit.Rows.Add(values);
                    this.dtvSubmit.Rows[num].Tag = row;
                }
            }
            catch
            {
            }
        }

        private void method_61(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.method_60();
            }
            catch
            {
            }
        }

        private void method_62()
        {
            MethodInvoker invoker2 = null;
            Class33 class6 = new Class33 {
                frmMain_0 = this,
                string_0 = string.Empty
            };
            MethodInvoker method = new MethodInvoker(class6.method_0);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
            Thread.Sleep(100);
            if (!string.IsNullOrEmpty(this.txtSearchBLExt.Text.Trim()))
            {
                class6.string_0 = class6.string_0 + " site:" + this.txtSearchBLExt.Text.Trim();
            }
            class6.string_0 = "\"" + this.txtSearchBLKey.Text.Trim() + "\" " + class6.string_0;
            class6.string_0 = class6.string_0.Trim();
            GClass15 class2 = new GClass15();
            int num = 10;
            if (!this.gclass4_0.method_37(this.string_2).Equals(this.infoSEO_0.Permission))
            {
                num = 1;
            }
            this.list_10 = new List<Class16>();
            for (int i = 1; i <= num; i++)
            {
                string str;
                if (i == 1)
                {
                    string[] strArray = new string[] { "http://www.google.", this.txtSearchBLGExt.Text.Trim(), "/search?hl=", this.txtSearchBLLang.Text.Trim(), "&q=", class6.string_0 };
                    str = string.Concat(strArray);
                }
                else
                {
                    object[] objArray = new object[] { "http://www.google.", this.txtSearchBLGExt.Text.Trim(), "/search?hl=", this.txtSearchBLLang.Text.Trim(), "&q=", class6.string_0, "&start=", (i - 1) * 10 };
                    str = string.Concat(objArray);
                }
                string str2 = this.gclass4_0.method_38(str);
                if (string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("Lượng truy cập qu\x00e1 nhiều! H\x00e3y Reset lại IP của bạn!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                }
                foreach (GClass8 class3 in this.gclass4_0.method_4(str2))
                {
                    Predicate<Class16> match = null;
                    Class34 class5 = new Class34 {
                        class33_0 = class6,
                        string_0 = class3.method_0()
                    };
                    try
                    {
                        class5.string_0 = new Uri(class5.string_0).Host;
                    }
                    catch
                    {
                        class5.string_0 = string.Empty;
                    }
                    if (!string.IsNullOrEmpty(class5.string_0))
                    {
                        if (match == null)
                        {
                            match = new Predicate<Class16>(class5.method_0);
                        }
                        int num3 = this.list_10.FindIndex(match);
                        if (num3 >= 0)
                        {
                            Class16 local2 = this.list_10[num3];
                            local2.method_5(local2.method_4() + 1);
                        }
                        else
                        {
                            Class16 item = new Class16();
                            item.method_1(class5.string_0);
                            item.method_3(class2.method_3(class5.string_0));
                            item.method_5(1);
                            this.list_10.Add(item);
                        }
                        if (func_13 == null)
                        {
                            func_13 = new Func<Class16, int>(frmMain.smethod_19);
                        }
                        this.list_10 = this.list_10.OrderByDescending<Class16, int>(func_13).ToList<Class16>();
                        if (invoker2 == null)
                        {
                            invoker2 = new MethodInvoker(this.method_128);
                        }
                        method = invoker2;
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(method);
                        }
                        else
                        {
                            method();
                        }
                    }
                }
                Thread.Sleep(100);
            }
            if (func_14 == null)
            {
                func_14 = new Func<Class16, int>(frmMain.smethod_20);
            }
            this.list_10 = this.list_10.OrderByDescending<Class16, int>(func_14).ToList<Class16>();
            method = new MethodInvoker(this.method_129);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_63(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvSearchBacklink.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvSearchBacklink[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void method_64()
        {
            this.method_33(this.dtvSearchBacklink, true);
            MethodInvoker method = new MethodInvoker(this.method_130);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_65(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSearchBacklink.PerformClick();
            }
        }

        private void method_66()
        {
            HtmlDocument document = this.webSubmit.Document;
            string str = document.Url.ToString();
            if (str.IndexOf("draft.blogger.com") <= 0)
            {
                HtmlElement elementById;
                string str2 = "SELECT * FROM Attributes WHERE AttributeID='" + this.cbAttributeCate.SelectedValue + "'";
                DataTable table = this.gclass4_0.method_40(str2);
                if (str.IndexOf("accounts.google.com") <= 0)
                {
                    string str13 = this.gclass4_0.method_21(this.txtHTMLTitle.Text.Trim());
                    string str14 = this.gclass4_0.method_21(this.txtHTMLDesc.Text.Trim());
                    string newValue = this.txtHTMLTags.Text.Trim();
                    string str17 = this.txtHTMLKeyword.Text.Trim();
                    string str15 = this.gclass4_0.method_21(this.method_76("GetContents", new object[0]).ToString()).Replace("$title$", this.gclass4_0.method_21(str13)).Replace("$description$", this.gclass4_0.method_21(str14)).Replace("$keyword$", this.gclass4_0.method_21(str17));
                    foreach (DataRow row2 in table.Rows)
                    {
                        try
                        {
                            foreach (string str18 in Regex.Split(row2["Value"].ToString(), "\n"))
                            {
                                string str19 = string.Empty;
                                string str20 = string.Empty;
                                string str21 = str18.Trim();
                                if (str21.LastIndexOf("//") > 0)
                                {
                                    str21 = str21.Substring(0, str21.LastIndexOf("//")).Trim();
                                }
                                int index = str21.IndexOf(":");
                                if (str21.IndexOf(":") > 0)
                                {
                                    str19 = str21.Substring(0, index).Trim();
                                    str20 = str21.Substring(index + 1, (str21.Length - index) - 1).Trim();
                                }
                                if (!string.IsNullOrEmpty(str19) && !string.IsNullOrEmpty(str20))
                                {
                                    elementById = document.GetElementById(str19);
                                    if (elementById != null)
                                    {
                                        if (str20.Equals("$checked$"))
                                        {
                                            elementById.SetAttribute("checked", "checked");
                                        }
                                        else if ((str20.IndexOf("$content$") < 0) && ((str20.IndexOf("$title$") < 0) && ((str20.IndexOf("$tags$") < 0) && ((str20.IndexOf("$description$") < 0) && (str20.IndexOf("$keyword$") < 0)))))
                                        {
                                            elementById.SetAttribute("value", str20);
                                        }
                                        else
                                        {
                                            elementById.SetAttribute("value", str20.Replace("$content$", str15).Replace("$title$", str13).Replace("$tags$", newValue).Replace("$description$", str14).Replace("$keyword$", str17));
                                        }
                                    }
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    string str3 = "LastName";
                    string str4 = "FirstName";
                    string str5 = "taikhoangmailcuaban";
                    string str6 = "qweqwe123123";
                    string str7 = "84989999999";
                    string str8 = "igoovn@gmail.com";
                    foreach (DataRow row in table.Rows)
                    {
                        try
                        {
                            foreach (string str9 in Regex.Split(row["Value"].ToString(), "\n"))
                            {
                                string str10 = string.Empty;
                                string str11 = string.Empty;
                                string str12 = str9.Trim();
                                if (str12.LastIndexOf("//") > 0)
                                {
                                    str12 = str12.Substring(0, str12.LastIndexOf("//")).Trim();
                                }
                                int index = str12.IndexOf(":");
                                if (str12.IndexOf(":") > 0)
                                {
                                    str10 = str12.Substring(0, index).Trim();
                                    str11 = str12.Substring(index + 1, (str12.Length - index) - 1).Trim();
                                }
                                if (!string.IsNullOrEmpty(str10) && !string.IsNullOrEmpty(str11))
                                {
                                    if (str10 == "LastName")
                                    {
                                        str3 = str11;
                                    }
                                    else if (str10 == "FirstName")
                                    {
                                        str4 = str11;
                                    }
                                    else if (str10 == "Account")
                                    {
                                        str5 = str11;
                                    }
                                    else if (str10 == "Password")
                                    {
                                        str6 = str11;
                                    }
                                    else if (str10 == "Mobile")
                                    {
                                        str7 = str11;
                                    }
                                    else if (str10 == "EmailRecovery")
                                    {
                                        str8 = str11;
                                    }
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                    elementById = document.GetElementById("LastName");
                    if (elementById != null)
                    {
                        elementById.InnerText = str3;
                    }
                    elementById = document.GetElementById("lastname-placeholder");
                    if (elementById != null)
                    {
                        elementById.InnerText = "";
                    }
                    elementById = document.GetElementById("firstname-placeholder");
                    if (elementById != null)
                    {
                        elementById.InnerText = "";
                    }
                    elementById = document.GetElementById("FirstName");
                    if (elementById != null)
                    {
                        elementById.InnerText = str4;
                        elementById.InvokeMember("onblur");
                    }
                    elementById = document.GetElementById("GmailAddress");
                    if (elementById != null)
                    {
                        elementById.InnerText = str5;
                        elementById.InvokeMember("onblur");
                        elementById.InvokeMember("onChange");
                        elementById.InvokeMember("onFocus");
                    }
                    elementById = document.GetElementById("Passwd");
                    if (elementById != null)
                    {
                        elementById.InnerText = str6;
                        elementById.InvokeMember("onFocus");
                        elementById.InvokeMember("onblur");
                        elementById.InvokeMember("onChange");
                    }
                    elementById = document.GetElementById("PasswdAgain");
                    if (elementById != null)
                    {
                        elementById.InnerText = str6;
                        elementById.InvokeMember("onFocus");
                        elementById.InvokeMember("onblur");
                        elementById.InvokeMember("onChange");
                    }
                    elementById = document.GetElementById("birthday-placeholder");
                    if (elementById != null)
                    {
                        elementById.InnerText = "";
                    }
                    elementById = document.GetElementById("BirthDay");
                    if (elementById != null)
                    {
                        elementById.InnerText = "14";
                        elementById.InvokeMember("onblur");
                    }
                    elementById = document.GetElementById("BirthMonth");
                    if (elementById != null)
                    {
                        elementById.SetAttribute("SelectedIndex", "2");
                        elementById.InvokeMember("onblur");
                    }
                    elementById = document.GetElementById("HiddenBirthMonth");
                    if (elementById != null)
                    {
                        elementById.InnerText = "02";
                    }
                    elementById = document.GetElementById("birthYear-placeholder");
                    if (elementById != null)
                    {
                        elementById.InnerText = "";
                    }
                    elementById = document.GetElementById("BirthYear");
                    if (elementById != null)
                    {
                        elementById.InnerText = "1986";
                        elementById.InvokeMember("onblur");
                    }
                    elementById = document.GetElementById("Gender");
                    if (elementById != null)
                    {
                        elementById.SetAttribute("SelectedIndex", "1");
                        elementById.InvokeMember("onblur");
                    }
                    elementById = document.GetElementById("HiddenGender");
                    if (elementById != null)
                    {
                        elementById.InnerText = "FEMALE";
                        elementById.SetAttribute("value", "FEMALE");
                        elementById.InvokeMember("onblur");
                    }
                    document.GetElementById("RecoveryPhoneNumber").InnerText = str7;
                    document.GetElementById("RecoveryEmailAddress").InnerText = str8;
                    elementById = document.GetElementById("TermsOfService");
                    if (elementById != null)
                    {
                        elementById.SetAttribute("checked", "true");
                        elementById.InvokeMember("onblur");
                    }
                    elementById = document.GetElementById("HomepageSet");
                    if (elementById != null)
                    {
                        elementById.SetAttribute("checked", "");
                        elementById.InvokeMember("onblur");
                    }
                }
            }
        }

        private void method_67()
        {
            try
            {
                HtmlDocument document = this.webSubmit.Document;
                if (document.Url.ToString().IndexOf("facebook.com/messages") > 0)
                {
                    HtmlElementCollection elementsByTagName = document.GetElementsByTagName("input");
                    foreach (HtmlElement element in elementsByTagName)
                    {
                        if ((element.OuterHtml.IndexOf("value=Gửi") > 0) || ((element.OuterHtml.IndexOf("value=Send") > 0) || ((element.OuterHtml.IndexOf("value=Trả lời") > 0) || (element.OuterHtml.IndexOf("value=Reply") > 0))))
                        {
                            element.InvokeMember("click");
                            this.bool_8 = false;
                            this.bool_6 = false;
                            break;
                        }
                    }
                    if (!this.bool_8)
                    {
                        return;
                    }
                }
                string str2 = "SELECT * FROM Attributes WHERE AttributeID='" + this.cbAttributeCate.SelectedValue + "'";
                foreach (DataRow row in this.gclass4_0.method_40(str2).Rows)
                {
                    try
                    {
                        int num = 0;
                        string[] strArray2 = Regex.Split(row["Value"].ToString(), "\n");
                        int index = 0;
                        while (true)
                        {
                            if (index >= strArray2.Length)
                            {
                                if (num == 1)
                                {
                                    this.bool_6 = false;
                                }
                                break;
                            }
                            string str4 = strArray2[index];
                            if (str4.IndexOf("//") > 0)
                            {
                                str4 = str4.Substring(0, str4.IndexOf("//")).Trim();
                            }
                            int startIndex = str4.IndexOf("click$");
                            if (startIndex > 0)
                            {
                                num++;
                                startIndex += 6;
                                string str6 = str4.Substring(startIndex, str4.Length - startIndex).Trim();
                                foreach (HtmlElement element2 in document.GetElementsByTagName(str4.Substring(0, startIndex).Replace("click$", "").Replace("$", "")))
                                {
                                    if ((element2.OuterHtml.IndexOf(str6) > 0) || (element2.OuterHtml.IndexOf(str6.Replace("\"", "")) > 0))
                                    {
                                        element2.InvokeMember("click");
                                        this.bool_8 = false;
                                    }
                                }
                            }
                            index++;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
        }

        private void method_68(object object_0)
        {
            try
            {
                string uriString = "http://" + this.gclass4_0.method_15("<p>(?<Content>.*?)<br/>", object_0.ToString());
                string host = string.Empty;
                try
                {
                    host = new Uri(uriString).Host;
                }
                catch
                {
                }
                Class17 item = new Class17();
                item.method_1(uriString);
                item.method_3(host);
                item.method_7(this.gclass15_0.method_3(host));
                item.method_5(this.gclass4_0.method_6(this.txtCheckBLUrl.Text.Trim(), uriString));
                this.list_11.Add(item);
                this.int_14--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_69()
        {
            // Invalid method body.
        }

        private void method_7(object object_0)
        {
            try
            {
                List<Class7> collection = new List<Class7>();
                XmlDocument document = new XmlDocument();
                document.LoadXml(this.gclass4_0.method_38("http://lightapi.majesticseo.com/getdomainstats.php?apikey=A42C68F9D&url=" + object_0.ToString()));
                foreach (XmlNode node in document.SelectNodes("//Result"))
                {
                    XElement element = XElement.Parse(node.OuterXml.ToString());
                    collection.Add(new Class7("[MajesticSEO.com]", element.Attribute("LinkBackURL").Value));
                    collection.Add(new Class7("->Domain li\x00ean kết: " + element.Attribute("StatsRefDomains").Value, ""));
                    collection.Add(new Class7("->External Backlinks: " + element.Attribute("StatsExternalBackLinks").Value, ""));
                    Class7 item = new Class7("->MajesticSEO Index: " + element.Attribute("StatsIndexedURLs").Value, "");
                    collection.Add(item);
                }
                lock (this.list_2)
                {
                    this.list_2.AddRange(collection);
                }
                this.int_1--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_70()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'ADWORD' AND Name LIKE '%" + this.txtAdwordCate.Text.Trim() + "%' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvAdwordCate.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["CategoryID"].ToString(), row["Name"].ToString() };
                int num = this.dtvAdwordCate.Rows.Add(values);
                this.dtvAdwordCate.Rows[num].Tag = row;
            }
        }

        private void method_71()
        {
            try
            {
                this.dtvAdword.Rows.Clear();
                string str = "SELECT * FROM Adwords WHERE CategoryID='" + this.dtvAdwordCate.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY AdwordID DESC";
                if (this.bool_3)
                {
                    string[] strArray = new string[] { "SELECT * FROM Adwords WHERE CategoryID='", this.dtvAdwordCate.CurrentRow.Cells[0].Value.ToString(), "' AND Key LIKE '%", this.txtAdwordKey.Text.Trim(), "%' AND Website LIKE '%", this.txtAdwordWeb.Text.Trim(), "%' ORDER BY AdwordID DESC" };
                    str = string.Concat(strArray);
                }
                foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
                {
                    object[] values = new object[] { row["AdwordID"].ToString(), row["Key"].ToString(), row["Website"].ToString(), row["TOP3"].ToString(), row["TOP10"].ToString(), row["BTOP3"].ToString(), row["Ext"].ToString(), row["Lang"].ToString() };
                    int num = this.dtvAdword.Rows.Add(values);
                    this.dtvAdword.Rows[num].Tag = row;
                }
            }
            catch
            {
            }
        }

        private void method_72(object object_0)
        {
            DataRow row = (DataRow) object_0;
            string[] strArray = new string[] { "http://www.google.", row["Ext"].ToString(), "/search?hl=", row["Lang"].ToString(), "&q=", row["Key"].ToString() };
            string str = string.Concat(strArray);
            string str2 = this.gclass4_0.method_38(str);
            string str3 = this.gclass4_0.method_15("<ol onmouseover=\"return true\"(?<Content>.*?)</ol>", str2);
            List<string> list = this.gclass4_0.method_20("<a id=(?<Content>.*?)</a>", str3);
            int num = 0;
            int num2 = 0;
            while (true)
            {
                if (num2 < list.Count)
                {
                    if (list[num2].IndexOf(row["Website"].ToString()) <= 0)
                    {
                        num2++;
                        continue;
                    }
                    num = num2 + 1;
                }
                string str4 = this.gclass4_0.method_15("<div id=\"bottomads\">(?<Content>.*?)</div><div class=\"med\"", str2);
                List<string> list2 = this.gclass4_0.method_20("<a id=(?<Content>.*?)</a>", str4);
                int num3 = 0;
                int num4 = 0;
                while (true)
                {
                    if (num4 < list2.Count)
                    {
                        if (list2[num4].IndexOf(row["Website"].ToString()) <= 0)
                        {
                            num4++;
                            continue;
                        }
                        num3 = num4 + 1;
                    }
                    string str5 = this.gclass4_0.method_15("<td class=\"std\">(?<Content>.*?)</td>", str2);
                    List<string> list3 = this.gclass4_0.method_20("<a id=(?<Content>.*?)</a>", str5);
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 < list3.Count)
                        {
                            if (list3[num6].IndexOf(row["Website"].ToString()) <= 0)
                            {
                                num6++;
                                continue;
                            }
                            num5 = num6 + 1;
                        }
                        this.gclass4_0.method_42("UPDATE Adwords SET Top3=" + num.ToString() + ",BTop3=" + num3.ToString() + ",Top10=" + num5.ToString() + " WHERE AdwordID='" + row["AdwordID"].ToString() + "'");
                        this.int_15--;
                        return;
                    }
                }
            }
        }

        private void method_73()
        {
            // Invalid method body.
        }

        private void method_74()
        {
            try
            {
                Class35 class5 = new Class35 {
                    frmMain_0 = this
                };
                int num = 1;
                int num2 = 2;
                class5.string_0 = this.txtKeyResearch.Text.Trim();
                string str2 = this.txtExtSuggest.Text.Trim();
                string str3 = this.txtLangSuggest.Text.Trim();
                this.list_12 = new List<Class18>();
                GClass15 class2 = new GClass15();
                class5.string_1 = string.Empty;
                int num3 = 1;
                while (true)
                {
                    string str;
                    if (num3 > num2)
                    {
                        MethodInvoker method = new MethodInvoker(class5.method_0);
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(method);
                        }
                        else
                        {
                            method();
                        }
                        break;
                    }
                    if (num3 == 1)
                    {
                        string[] strArray = new string[] { "http://www.google.", str2, "/search?hl=", str3, "&q=", class5.string_0 };
                        str = string.Concat(strArray);
                    }
                    else
                    {
                        object[] objArray = new object[] { "http://www.google.", str2, "/search?hl=", str3, "&q=", class5.string_0, "&start=", (num3 - 1) * 10 };
                        str = string.Concat(objArray);
                    }
                    string str4 = this.gclass4_0.method_38(str);
                    if (num3 == 1)
                    {
                        class5.string_1 = str4;
                    }
                    foreach (GClass8 class3 in this.gclass4_0.method_4(str4))
                    {
                        Class18 item = new Class18();
                        item.method_1(num);
                        item.method_3(class3.method_0());
                        item.method_5(this.gclass4_0.method_33(class3.method_2()));
                        item.method_7(class2.method_3(class3.method_0()));
                        this.list_12.Add(item);
                        num++;
                    }
                    num3++;
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_75()
        {
            Class36 class2 = new Class36 {
                frmMain_0 = this,
                int_0 = 0,
                htmlDocument_0 = null,
                string_0 = string.Empty
            };
            MethodInvoker method = new MethodInvoker(class2.method_0);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
            Thread.Sleep(100);
            if (class2.string_0.Equals("LIKE_FB"))
            {
                foreach (HtmlElement element in class2.htmlDocument_0.GetElementsByTagName("a"))
                {
                    string str = element.OuterHtml.ToLower();
                    if ((str.IndexOf(">th\x00edch</a>") > 0) || (str.IndexOf(">like</a>") > 0))
                    {
                        element.InvokeMember("click");
                        class2.int_0++;
                        Thread.Sleep((int) (((int) this.numAutoClick.Value) * 0x3e8));
                    }
                }
            }
            if (class2.string_0.Equals("GOOGLE_LIKE"))
            {
                foreach (HtmlElement element2 in class2.htmlDocument_0.GetElementsByTagName("span"))
                {
                    if (element2.OuterHtml.IndexOf("sr ew") > 0)
                    {
                        element2.InvokeMember("click");
                        class2.int_0++;
                    }
                }
            }
            else if (class2.string_0.Equals("CHECK_FB"))
            {
                foreach (HtmlElement element3 in class2.htmlDocument_0.GetElementsByTagName("input"))
                {
                    if (element3.GetAttribute("name").StartsWith("checkableitems"))
                    {
                        element3.SetAttribute("checked", "checked");
                        class2.int_0++;
                    }
                }
            }
            else if (class2.string_0.Equals("THANKS_VBB"))
            {
                foreach (HtmlElement element4 in class2.htmlDocument_0.GetElementsByTagName("a"))
                {
                    if (element4.GetAttribute("id").IndexOf("post_thanks_button") == 0)
                    {
                        element4.InvokeMember("click");
                        class2.int_0++;
                    }
                }
            }
            else if (class2.string_0.Equals("THANKS_XF"))
            {
                foreach (HtmlElement element5 in class2.htmlDocument_0.GetElementsByTagName("a"))
                {
                    if (element5.GetAttribute("href").EndsWith("/like"))
                    {
                        element5.InvokeMember("click");
                        class2.int_0++;
                    }
                }
            }
            else if (class2.string_0.Equals("THANKS_MUARE"))
            {
                foreach (HtmlElement element6 in class2.htmlDocument_0.GetElementsByTagName("a"))
                {
                    if (element6.GetAttribute("id").StartsWith("post_thanks_button"))
                    {
                        element6.InvokeMember("click");
                        class2.int_0++;
                    }
                }
            }
            method = new MethodInvoker(class2.method_1);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private object method_76(string string_7, params object[] object_0) => 
            this.webEditor.Document.InvokeScript(string_7, object_0);

        private void method_77()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'NEWS' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvNewsCate.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["CategoryID"].ToString(), row["Name"].ToString() };
                int num = this.dtvNewsCate.Rows.Add(values);
                this.dtvNewsCate.Rows[num].Tag = row;
            }
        }

        private void method_78()
        {
            Class37 class2 = new Class37 {
                frmMain_0 = this,
                string_0 = this.gclass4_0.method_50(this.dtvNews.CurrentRow.Cells[4].Value.ToString()),
                string_1 = this.dtvNews.CurrentRow.Cells[2].Value.ToString()
            };
            class2.string_1 = "<p>Nguồn: " + class2.string_1 + "</p>";
            class2.string_0 = this.gclass4_0.method_35(class2.string_0);
            MethodInvoker method = new MethodInvoker(class2.method_0);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_79(object object_0)
        {
            try
            {
                Class38 class5 = new Class38 {
                    frmMain_0 = this,
                    bool_0 = (bool) object_0
                };
                List<string> list = this.txtNewsCate.Text.Trim().Split(new char[] { ',' }).ToList<string>();
                class5.string_0 = "";
                if (class5.bool_0)
                {
                    class5.string_0 = this.dtvNewsCate.CurrentRow.Cells[0].Value.ToString();
                }
                GClass19 class2 = new GClass19 {
                    gclass4_0 = this.gclass4_0
                };
                class5.list_0 = new List<Class19>();
                foreach (string str in list)
                {
                    class2.method_1("http://www.baomoi.com/Rss/RssFeed.ashx?t=3&ph=" + str.Trim() + "&zoneid=-1");
                    using (IEnumerator<GStruct3> enumerator2 = class2.method_8().GetEnumerator())
                    {
                        Predicate<Class19> match = null;
                        Class39 class4 = new Class39 {
                            class38_0 = class5
                        };
                        while (enumerator2.MoveNext())
                        {
                            class4.gstruct3_0 = enumerator2.Current;
                            string str2 = class4.gstruct3_0.string_4.Substring(class4.gstruct3_0.string_4.LastIndexOf("/"));
                            string str3 = class4.gstruct3_0.string_4.Substring(0, class4.gstruct3_0.string_4.LastIndexOf("/"));
                            string str4 = str3.Substring(str3.LastIndexOf("/"));
                            string str5 = string.Empty;
                            if ("Unresolvable".Equals(class4.gstruct3_0.string_2))
                            {
                                str5 = "/55";
                            }
                            else
                            {
                                str3 = class4.gstruct3_0.string_2.Substring(0, class4.gstruct3_0.string_2.LastIndexOf("/"));
                                str5 = str3.Substring(str3.LastIndexOf("/"));
                            }
                            if (match == null)
                            {
                                match = new Predicate<Class19>(class4.method_0);
                            }
                            if (class5.list_0.FindIndex(match) < 0)
                            {
                                Class19 item = new Class19();
                                item.method_1(class4.gstruct3_0.string_0);
                                item.method_3(class4.gstruct3_0.string_3);
                                item.method_9(class4.gstruct3_0.string_1);
                                item.method_11(class4.gstruct3_0.string_2.Replace("http://www.baomoi.com/", ""));
                                item.method_5(new Uri(class4.gstruct3_0.string_1).Host);
                                item.method_7(str4 + str5 + str2.Substring(0, str2.Length - 4));
                                class5.list_0.Add(item);
                            }
                        }
                    }
                }
                MethodInvoker method = new MethodInvoker(class5.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch
            {
            }
        }

        private void method_8(object object_0)
        {
            try
            {
                string str = object_0.ToString();
                List<Class7> collection = new List<Class7> {
                    new Class7("[Alexa.com]", "http://www.alexa.com/siteinfo/" + str)
                };
                string input = this.gclass4_0.method_38("http://www.alexa.com/siteinfo/" + str);
                Match match = new Regex("margin-bottom:-2px;\"/>(?<Global>.*?)</div>", RegexOptions.Singleline).Match(input);
                collection.Add(new Class7("->Alexa Global Rank: " + match.Groups["Global"].Value.Trim(), ""));
                match = new Regex("Vietnam Flag\"/>(?<VN>.*?)</div>", RegexOptions.Singleline).Match(input);
                collection.Add(new Class7("->Alexa VN Rank: " + match.Groups["VN"].Value.Trim(), ""));
                match = new Regex("href=\"/site/linksin/" + this.txtWebsiteCheck.Text.Trim() + "\">(?<Backlink>.*?)</a>", RegexOptions.Singleline).Match(input);
                collection.Add(new Class7("->Alexa Backlink: " + match.Groups["Backlink"].Value.Trim(), ""));
                lock (this.list_2)
                {
                    this.list_2.AddRange(collection);
                }
                this.int_1--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_80(object object_0)
        {
            Class13 class2 = (Class13) object_0;
            if (this.gclass4_0.method_25(class2.method_0(), class2.method_2()))
            {
                lock (this.list_13)
                {
                    this.list_13.Add(class2.method_0() + ":" + class2.method_2());
                }
            }
            this.int_16--;
        }

        private void method_81(object object_0)
        {
            // Invalid method body.
        }

        private void method_82()
        {
            string str = "SELECT [AccountID], [Name] FROM Accounts ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.cbHTMLAccount.DataSource = table;
            this.cbHTMLAccount.ValueMember = "AccountID";
            this.cbHTMLAccount.DisplayMember = "Name";
        }

        private void method_83()
        {
            try
            {
                Class40 class3 = new Class40 {
                    frmMain_0 = this,
                    string_0 = string.Empty,
                    string_1 = string.Empty,
                    string_2 = null
                };
                MethodInvoker method = new MethodInvoker(class3.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                Thread.Sleep(100);
                string str = this.txtHTMLTitle.Text.Trim();
                string str2 = this.txtHTMLTags.Text.Trim();
                string str3 = this.txtHTMLKeyword.Text.Trim();
                class3.string_0 = class3.string_0.Replace("$title$", this.gclass4_0.method_21(str));
                class3.string_0 = class3.string_0.Replace("$description$", this.gclass4_0.method_21(class3.string_1));
                class3.string_0 = class3.string_0.Replace("$keyword$", this.gclass4_0.method_21(str3));
                str = this.gclass4_0.method_21(str);
                if (this.ckNewsAuto1.Checked && !string.IsNullOrEmpty(str3))
                {
                    str = str + " | " + str3;
                }
                GClass6 class2 = new GClass6();
                string[] strArray = this.listHTMLCategory.Tag.ToString().Split(new char[] { ';' });
                string host = new Uri(strArray[0]).Host;
                class3.bool_0 = false;
                class3.bool_1 = this.gclass4_0.method_18(Application.StartupPath + @"\Logs\" + host + ".iseo", str);
                if (!class3.bool_1)
                {
                    if (this.cbHTMLAccount.Tag.ToString().Equals("Blogger"))
                    {
                        class3.bool_0 = class2.method_1(strArray[0], strArray[1], strArray[2], strArray[3], str, class3.string_0, class3.string_2);
                    }
                    else if (this.cbHTMLAccount.Tag.ToString().Equals("Wordpress"))
                    {
                        class3.bool_0 = class2.method_0(strArray[0], strArray[1], strArray[2], str, class3.string_0, str2, class3.string_2);
                    }
                }
                method = new MethodInvoker(class3.method_1);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_84()
        {
            if (this.cbHTMLAccount.SelectedValue != null)
            {
                string str = "SELECT [Type], [Connect], [Label] FROM Accounts WHERE [AccountID]='" + this.cbHTMLAccount.SelectedValue.ToString() + "'";
                DataTable table = this.gclass4_0.method_40(str);
                if (table.Rows.Count > 0)
                {
                    DataTable table2 = new DataTable();
                    table2.Columns.Add("Value", typeof(string));
                    table2.Columns.Add("Name", typeof(string));
                    object[] values = new object[2];
                    string[] strArray2 = table.Rows[0]["Label"].ToString().Split(new char[] { ',' });
                    int index = 0;
                    while (true)
                    {
                        if (index >= strArray2.Length)
                        {
                            this.listHTMLCategory.DataSource = table2;
                            this.listHTMLCategory.ValueMember = "Value";
                            this.listHTMLCategory.DisplayMember = "Name";
                            this.listHTMLCategory.Tag = table.Rows[0]["Connect"].ToString();
                            this.cbHTMLAccount.Tag = table.Rows[0]["Type"].ToString();
                            break;
                        }
                        string str2 = strArray2[index];
                        if (!string.IsNullOrEmpty(str2))
                        {
                            values[0] = str2;
                            values[1] = str2;
                            table2.Rows.Add(values);
                        }
                        index++;
                    }
                }
            }
        }

        private void method_85()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'ANCHOR' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.cbHTMLAnchor.DataSource = table;
            this.cbHTMLAnchor.ValueMember = "CategoryID";
            this.cbHTMLAnchor.DisplayMember = "Name";
        }

        private void method_86()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'CONTENT' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.cbHTMLContent.DataSource = table;
            this.cbHTMLContent.ValueMember = "CategoryID";
            this.cbHTMLContent.DisplayMember = "Name";
        }

        private void method_87()
        {
            string str = "SELECT [ContentID], [Title] FROM Contents WHERE [CategoryID]='" + this.cbHTMLContent.SelectedValue + "'";
            DataTable table = this.gclass4_0.method_40(str);
            this.cbHTMLTitle.DataSource = table;
            this.cbHTMLTitle.ValueMember = "ContentID";
            this.cbHTMLTitle.DisplayMember = "Title";
        }

        private void method_88(object object_0)
        {
            MethodInvoker invoker2 = null;
            Class41 class3 = new Class41 {
                frmMain_0 = this
            };
            Class20 class2 = (Class20) object_0;
            List<string> list = new List<string>();
            class3.string_0 = "";
            if (string.IsNullOrEmpty(class2.string_0))
            {
                invoker2 ??= new MethodInvoker(class3.method_0);
                MethodInvoker method = invoker2;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                Thread.Sleep(0xbb8);
                list = this.gclass4_0.method_17(class2.string_1, class3.string_0);
            }
            else if (!class2.bool_0)
            {
                class3.string_0 = this.gclass4_0.method_36(this.gclass4_0.method_38(class2.string_0));
                list = this.gclass4_0.method_17(class2.string_1, class3.string_0);
            }
            else
            {
                this.gclass4_0.string_0 = "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";
                class3.string_0 = this.gclass4_0.method_38(class2.string_0);
                this.gclass4_0.string_0 = this.gclass4_0.string_1;
                list = this.gclass4_0.method_20(class2.string_1, class3.string_0);
            }
            string str = "";
            foreach (string str2 in list)
            {
                str = !class2.bool_1 ? (str + str2 + "\n") : (str + class2.string_2.Replace("$Content$", str2) + "\n");
            }
            this.string_5 = this.string_5 + str;
        }

        private void method_89(object object_0)
        {
            Class42 class3 = new Class42 {
                frmMain_0 = this
            };
            bool flag = (bool) object_0;
            bool flag2 = false;
            string str = this.txtReplaceContent.Text.Trim().Replace("$$", "$Content$");
            if (!string.IsNullOrEmpty(str) && (str.IndexOf("$Content$") > 0))
            {
                flag2 = true;
            }
            class3.string_0 = new string[] { string.Empty };
            MethodInvoker method = new MethodInvoker(class3.method_0);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
            Thread.Sleep(100);
            string str2 = !flag ? this.txtRegexRegex.Text.Trim().Replace("$$", "(?<Content>.*?)") : @"[a-zA-Z0-9]+[a-zA-Z0-9_.-]*@[\w.-]+(\.)[a-z]{2,4}";
            int millisecondsTimeout = (int) this.numericRegexDelay.Value;
            for (int i = 0; i < class3.string_0.Length; i++)
            {
                Class20 class2 = new Class20 {
                    string_0 = class3.string_0[i],
                    string_1 = str2,
                    string_2 = str,
                    bool_0 = flag,
                    bool_1 = flag2
                };
                this.method_88(class2);
                Thread.Sleep(millisecondsTimeout);
            }
            method = new MethodInvoker(this.method_135);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_9(object object_0)
        {
            try
            {
                string str = object_0.ToString();
                List<Class7> collection = new List<Class7>();
                string text = this.gclass4_0.method_38("http://seoquake.publicapi.semrush.com/info.php?url=" + str);
                if (text.IndexOf("<status>notfound</status>") < 0)
                {
                    if (func_2 == null)
                    {
                        func_2 = new Func<XElement, Class64<string, string, string, string>>(frmMain.smethod_4);
                    }
                    foreach (Class64<string, string, string, string> class2 in XDocument.Parse(text).Descendants("data").Select<XElement, Class64<string, string, string, string>>(func_2))
                    {
                        collection.Add(new Class7("[SEMRush.com]", "http://www.semrush.com/search.php?q=" + str));
                        collection.Add(new Class7("->Rank: " + class2.method_0(), ""));
                        collection.Add(new Class7("->Keywords: " + class2.method_1(), ""));
                        collection.Add(new Class7("->Traffic: " + class2.method_2(), ""));
                        Class7 item = new Class7("->Costs: " + class2.method_3(), "");
                        collection.Add(item);
                    }
                }
                lock (this.list_2)
                {
                    this.list_2.AddRange(collection);
                }
                this.int_1--;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_90()
        {
            this.method_33(this.dtvKTList, true);
            MethodInvoker method = new MethodInvoker(this.method_136);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_91()
        {
            Class43 class2 = new Class43 {
                frmMain_0 = this,
                list_0 = this.iSEOSoapClient_0.GetProxy().Split(new char[] { '\n' }).ToList<string>(),
                list_1 = new List<string>()
            };
            MethodInvoker method = new MethodInvoker(class2.method_0);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private decimal method_92(long long_0, decimal decimal_0)
        {
            if (decimal_0 == 0M)
            {
                decimal_0 = 1M;
            }
            decimal num = long_0 / 30.5M;
            return Math.Round((decimal) ((num * num) / decimal_0), 3);
        }

        private void method_93(object object_0)
        {
            int num = (int) object_0;
            GClass13 class2 = this.list_14[num];
            decimal num2 = this.gclass4_0.method_7(this.gclass4_0.method_38("http://www.google.com.vn/search?q=" + class2.string_0));
            class2.decimal_0 = num2;
            class2.decimal_1 = this.method_92(class2.long_0, num2);
            class2.decimal_2 = this.method_92(class2.long_1, num2);
            this.list_14[num] = class2;
            this.int_17--;
        }

        private void method_94()
        {
            this.int_17 = 0;
            int parameter = 0;
            while (parameter < this.list_14.Count)
            {
                new Thread(new ParameterizedThreadStart(this.method_93)) { IsBackground = true }.Start(parameter);
                this.int_17++;
                while (true)
                {
                    if (this.int_17 < 10)
                    {
                        parameter++;
                        break;
                    }
                    Thread.Sleep(500);
                }
            }
            while (this.int_17 > 0)
            {
                Thread.Sleep(500);
            }
            MethodInvoker method = new MethodInvoker(this.method_137);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_95(object object_0)
        {
            string str = this.gclass4_0.method_38("http://www.matbao.net/Domain.ashx?domain=" + object_0 + "&Type=1");
            this.string_6 = ("True".Equals(str) || string.IsNullOrEmpty(str)) ? (this.string_6 + object_0 + "\tĐ\x00e3 đăng k\x00fd") : (this.string_6 + object_0 + "\tChưa đăng k\x00fd");
            this.string_6 = this.string_6 + "\n";
            this.int_18--;
        }

        private void method_96()
        {
            string str = this.txtKTDomain.Text.Trim();
            string[] strArray = Regex.Split(this.txtKTExt.Text.Trim(), ",");
            this.string_6 = "";
            this.int_18 = 0;
            this.gclass4_0.int_0 = 0x2710;
            foreach (string str2 in strArray)
            {
                new Thread(new ParameterizedThreadStart(this.method_95)) { IsBackground = true }.Start(str + "." + str2);
                this.int_18++;
            }
            while (this.int_18 > 0)
            {
                Thread.Sleep(500);
            }
            MethodInvoker method = new MethodInvoker(this.method_139);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        private void method_97()
        {
            this.method_33(this.dtvKeyLogs, true);
            MethodInvoker method = new MethodInvoker(this.method_140);
            if (base.InvokeRequired)
            {
                base.BeginInvoke(method);
            }
            else
            {
                method();
            }
        }

        public List<GClass5> method_98()
        {
            InfoSEO info = new InfoSEO {
                Email = this.infoSEO_0.Email
            };
            List<GClass5> list = new List<GClass5>();
            foreach (InfoSEO oseo2 in this.iSEOSoapClient_0.GetSite(info))
            {
                if (!oseo2.Website.StartsWith("http"))
                {
                    oseo2.Website = "http://" + oseo2.Website;
                }
                GClass5 item = new GClass5 {
                    string_0 = oseo2.UserID,
                    string_1 = oseo2.Website
                };
                list.Add(item);
            }
            return list;
        }

        private void method_99()
        {
            SetProcessWorkingSetSize(this.intptr_0, -1, -1);
            GC.Collect(0);
        }

        private void notifyIcon_0_BalloonTipClicked(object sender, EventArgs e)
        {
            base.Show();
            base.WindowState = FormWindowState.Normal;
            this.tbMain.SelectTab("tbArticle");
            this.btnArticleFollow.PerformClick();
        }

        private void notifyIcon_0_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.Show();
            base.WindowState = FormWindowState.Normal;
        }

        private void RegexResultSave_Click(object sender, EventArgs e)
        {
            this.method_28(this.rtbRegexResult.Text);
        }

        private void rtbRegexResult_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void rtbRegexURL_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        [DllImport("KERNEL32.DLL", CallingConvention=CallingConvention.StdCall, SetLastError=true)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr intptr_1, int int_21, int int_22);
        [CompilerGenerated]
        private static int smethod_0(Class5 class5_0) => 
            class5_0.int_0;

        [CompilerGenerated]
        private static int smethod_1(Class6 class6_0) => 
            class6_0.method_2();

        [CompilerGenerated]
        private static bool smethod_10(GClass9 gclass9_0) => 
            string.IsNullOrEmpty(gclass9_0.method_6());

        [CompilerGenerated]
        private static bool smethod_11(GClass9 gclass9_0) => 
            gclass9_0.method_8().IndexOf("nofollow") >= 0;

        [CompilerGenerated]
        private static bool smethod_12(GClass9 gclass9_0) => 
            gclass9_0.method_14() == "Error!";

        [CompilerGenerated]
        private static bool smethod_13(GClass9 gclass9_0) => 
            gclass9_0.method_12() == "External";

        [CompilerGenerated]
        private static bool smethod_14(GClass9 gclass9_0) => 
            gclass9_0.method_16() == "Image";

        [CompilerGenerated]
        private static short smethod_15(Class11 class11_0) => 
            class11_0.method_4();

        [CompilerGenerated]
        private static short smethod_16(Class11 class11_0) => 
            class11_0.method_6();

        [CompilerGenerated]
        private static long smethod_17(Class11 class11_0) => 
            class11_0.method_2();

        [CompilerGenerated]
        private static short smethod_18(Class12 class12_0) => 
            class12_0.method_2();

        [CompilerGenerated]
        private static int smethod_19(Class16 class16_0) => 
            class16_0.method_2();

        [CompilerGenerated]
        private static void smethod_2()
        {
        }

        [CompilerGenerated]
        private static int smethod_20(Class16 class16_0) => 
            class16_0.method_2();

        [CompilerGenerated]
        private static int smethod_21(Class17 class17_0) => 
            class17_0.method_6();

        [CompilerGenerated]
        private static int smethod_22(Class17 class17_0) => 
            class17_0.method_6();

        [CompilerGenerated]
        private static void smethod_3()
        {
        }

        [CompilerGenerated]
        private static Class64<string, string, string, string> smethod_4(XElement xelement_0) => 
            new Class64<string, string, string, string>(xelement_0.Element("rank").Value, xelement_0.Element("keywords").Value, xelement_0.Element("traffic").Value, xelement_0.Element("costs").Value);

        [CompilerGenerated]
        private static Class64<string, string, string, string> smethod_5(XElement xelement_0) => 
            new Class64<string, string, string, string>(xelement_0.Element("rank").Value, xelement_0.Element("keywords").Value, xelement_0.Element("traffic").Value, xelement_0.Element("costs").Value);

        [CompilerGenerated]
        private static void smethod_6()
        {
        }

        [CompilerGenerated]
        private static void smethod_7()
        {
        }

        [CompilerGenerated]
        private static void smethod_8()
        {
        }

        [CompilerGenerated]
        private static void smethod_9()
        {
        }

        private void tbAdword_Enter(object sender, EventArgs e)
        {
            try
            {
                this.method_70();
                this.method_71();
            }
            catch
            {
            }
        }

        private void tbArticle_Enter(object sender, EventArgs e)
        {
            try
            {
                this.method_45();
                this.method_46();
            }
            catch
            {
            }
        }

        private void tbBacklink_Enter(object sender, EventArgs e)
        {
            try
            {
                this.method_41();
                this.method_42();
            }
            catch
            {
            }
        }

        private void tbHTML_Enter(object sender, EventArgs e)
        {
            if (this.cbHTMLAccount.SelectedValue == null)
            {
                this.method_82();
            }
            if ((this.cbHTMLAccount.SelectedValue != null) && (this.listHTMLCategory.SelectedValue == null))
            {
                this.method_84();
            }
            if (this.cbHTMLAnchor.SelectedValue == null)
            {
                this.method_85();
            }
            if (this.cbHTMLContent.SelectedValue == null)
            {
                this.method_86();
            }
            if ((this.cbHTMLContent.SelectedValue != null) && (this.cbHTMLTitle.SelectedValue == null))
            {
                this.method_87();
            }
        }

        private void tbKeyResearch_Enter(object sender, EventArgs e)
        {
            this.cbDepthKey.SelectedIndex = 0;
        }

        private void tbKeyword_Enter(object sender, EventArgs e)
        {
            try
            {
                this.method_40();
                this.method_26();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void tbKeywordTool_Enter(object sender, EventArgs e)
        {
            if (this.webBrowser_0 == null)
            {
                foreach (DataRow row in this.gclass4_0.method_40("SELECT * FROM Users WHERE Code = 'ADWORD'").Rows)
                {
                    this.txtKTEmail.Text = row["UserName"].ToString();
                    this.txtKTPass.Text = row["Password"].ToString();
                }
                if (this.cbKTBrowser.SelectedValue == null)
                {
                    DataTable table = new DataTable();
                    table = new DataTable("Type");
                    table.Columns.Add("Value", typeof(string));
                    table.Columns.Add("Name", typeof(string));
                    object[] values = new object[] { "Thiết bị m\x00e1y t\x00ednh để b\x00e0n v\x00e0 m\x00e1y t\x00ednh x\x00e1ch tay", "M\x00e1y t\x00ednh" };
                    table.Rows.Add(values);
                    values[0] = "Tất cả c\x00e1c thiết bị di động";
                    values[1] = "Điện thoại";
                    table.Rows.Add(values);
                    values[0] = "Thiết bị WAP tr\x00ean điện thoại di động";
                    values[1] = "Chỉ WAP";
                    table.Rows.Add(values);
                    values[0] = "Thiết bị di động c\x00f3 tr\x00ecnh duyệt internet ho\x00e0n chỉnh";
                    values[1] = "Smartphone";
                    table.Rows.Add(values);
                    this.cbKTBrowser.DataSource = table;
                    this.cbKTBrowser.ValueMember = "Value";
                    this.cbKTBrowser.DisplayMember = "Name";
                }
                this.picLoader.Show();
                string urlString = "https://adwords.google.com.vn/o/Targeting/Explorer";
                this.webBrowser_0 = new WebBrowser();
                this.webBrowser_0.Navigate(urlString);
                this.webBrowser_0.ScriptErrorsSuppressed = true;
                this.webBrowser_0.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowser_0_DocumentCompleted);
                while (this.webBrowser_0.ReadyState != WebBrowserReadyState.Complete)
                {
                    Thread.Sleep(100);
                    Application.DoEvents();
                }
                this.picLoader.Hide();
            }
        }

        private void tbNews_Enter(object sender, EventArgs e)
        {
            if (this.dtvNewsCate.Rows.Count == 0)
            {
                this.method_77();
                this.gclass4_0.method_42("DELETE FROM NewsLogs WHERE Created <= Date() - 10");
            }
            DataTable table = new DataTable();
            table = new DataTable("Type");
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("Name", typeof(string));
            object[] values = new object[2];
            if (this.cbNewsCate.SelectedValue == null)
            {
                values[0] = "";
                values[1] = "Chọn theo danh mục Tin";
                table.Rows.Add(values);
                values[0] = "TheGioi.rss";
                values[1] = "Quốc Tế";
                table.Rows.Add(values);
                values[0] = "XaHoi.rss";
                values[1] = "X\x00e3 Hội";
                table.Rows.Add(values);
                values[0] = "VanHoa.rss";
                values[1] = "Văn Ho\x00e1";
                table.Rows.Add(values);
                values[0] = "KinhTe.rss";
                values[1] = "Kinh Tế";
                table.Rows.Add(values);
                values[0] = "KHCN.rss";
                values[1] = "C\x00f4ng Nghệ Th\x00f4ng Tin";
                table.Rows.Add(values);
                values[0] = "TheThao.rss";
                values[1] = "Thể Thao";
                table.Rows.Add(values);
                values[0] = "GiaiTri.rss";
                values[1] = "Giải Tr\x00ed";
                table.Rows.Add(values);
                values[0] = "PhapLuat.rss";
                values[1] = "Ph\x00e1p Luật";
                table.Rows.Add(values);
                values[0] = "GiaoDuc.rss";
                values[1] = "Gi\x00e1o Dục";
                table.Rows.Add(values);
                values[0] = "SucKhoe.rss";
                values[1] = "Sức Khoẻ";
                table.Rows.Add(values);
                values[0] = "OtoXemay.rss";
                values[1] = "\x00d4t\x00f4 - Xe M\x00e1y";
                table.Rows.Add(values);
                values[0] = "NhaDat.rss";
                values[1] = "Nh\x00e0 Đất";
                table.Rows.Add(values);
                this.cbNewsCate.DataSource = table;
                this.cbNewsCate.ValueMember = "Value";
                this.cbNewsCate.DisplayMember = "Name";
            }
        }

        private void tbRegex_Enter(object sender, EventArgs e)
        {
            this.cbRegexType.Text = "Regex";
        }

        private void tbSearchBL_Enter(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = new DataTable("Type");
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("Name", typeof(string));
            object[] values = new object[] { "\"forumdisplay.php\"|\"diendan\"|\"forum\"", "T\x00ecm diễn đ\x00e0n" };
            table.Rows.Add(values);
            values[0] = "\"Leave a Reply\" \"Required fields are marked\"";
            values[1] = "T\x00ecm WordPress";
            table.Rows.Add(values);
            values[0] = "\"blogspot.com\"";
            values[1] = "T\x00ecm Blogspot.com";
            table.Rows.Add(values);
            values[0] = "\"wordpress.com\"";
            values[1] = "T\x00ecm Wordpress.com";
            table.Rows.Add(values);
            this.cbSearchBLFilter.DataSource = table;
            this.cbSearchBLFilter.ValueMember = "Value";
            this.cbSearchBLFilter.DisplayMember = "Name";
        }

        private void tbSeoTool_Enter(object sender, EventArgs e)
        {
            DataTable table = new DataTable("Url");
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("Name", typeof(string));
            object[] values = new object[] { "", "Lựa chọn c\x00e1c c\x00f4ng cụ SEO!" };
            table.Rows.Add(values);
            values[0] = "https://adwords.google.com/select/KeywordToolExternal?hl=vi";
            values[1] = "Ph\x00e2n t\x00edch từ kh\x00f3a - Google Keyword Research Tool";
            table.Rows.Add(values);
            values[0] = "https://www.google.com/webmasters/tools/removals?hl=vi";
            values[1] = "Xo\x00e1 Index Url khỏi Google";
            table.Rows.Add(values);
            values[0] = "http://www.backlinkwatch.com";
            values[1] = "Check Backlink";
            table.Rows.Add(values);
            values[0] = "http://ahrefs.com";
            values[1] = "Ahrefs Site Explorer";
            table.Rows.Add(values);
            this.cbSEOOther.DataSource = table;
            this.cbSEOOther.ValueMember = "Value";
            this.cbSEOOther.DisplayMember = "Name";
            table = new DataTable("Url");
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("Name", typeof(string));
            values = new object[2];
            values = new object[] { "", "C\x00f4ng cụ ph\x00e2n t\x00edch của Google!" };
            table.Rows.Add(values);
            values[0] = "http://www.google.com.vn/addurl?hl=vi";
            values[1] = "Khai b\x00e1o Website với Google";
            table.Rows.Add(values);
            values[0] = "http://www.google.com/intl/vi/analytics";
            values[1] = "Ph\x00e2n t\x00edch Website - Google Analytics";
            table.Rows.Add(values);
            values[0] = "http://www.google.com/webmasters/tools/home?hl=vi";
            values[1] = "Quản l\x00fd Website - Webmaster Tools";
            table.Rows.Add(values);
            values[0] = "https://adwords.google.com/select/KeywordToolExternal?hl=vi";
            values[1] = "C\x00f4ng cụ từ kh\x00f3a - Google Keyword Tool";
            table.Rows.Add(values);
            values[0] = "http://www.google.com/intl/vi/webmasters/+1/button";
            values[1] = "Th\x00eam n\x00fat G+1 v\x00e0o Website";
            table.Rows.Add(values);
            values[0] = "http://www.google.com/insights/search/?hl=vi";
            values[1] = "Google Insights for Search";
            table.Rows.Add(values);
            values[0] = "https://adwords.google.com/select/TrafficEstimatorSandbox?hl=vi";
            values[1] = "Google Traffic Estimator";
            table.Rows.Add(values);
            values[0] = "http://adwords.google.com.vn";
            values[1] = "Google AdWords";
            table.Rows.Add(values);
            values[0] = "http://www.google.com/adsense/?hl=vi";
            values[1] = "Google AdSense";
            table.Rows.Add(values);
            this.cbGoogleTool.DataSource = table;
            this.cbGoogleTool.ValueMember = "Value";
            this.cbGoogleTool.DisplayMember = "Name";
            table = new DataTable("Url");
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("Name", typeof(string));
            values = new object[] { "http://www.google.com.vn/safebrowsing/diagnostic?site=$domain$", "Kiểm tra lỗi Google" };
            table.Rows.Add(values);
            values[0] = "http://validator.w3.org/check?uri=$domain$";
            values[1] = "Kiểm tra lỗi XHTML";
            table.Rows.Add(values);
            values[0] = "http://jigsaw.w3.org/css-validator/validator?uri=$domain$";
            values[1] = "Kiểm tra lỗi CSS";
            table.Rows.Add(values);
            values[0] = "http://checkdomain.matbao.vn/?domain=$domain$&Type=3";
            values[1] = "Kiểm tra th\x00f4ng tin t\x00ean miền";
            table.Rows.Add(values);
            values[0] = "https://developers.google.com/speed/pagespeed/insights#url=$domain$&mobile=false&rule=____critical__path";
            values[1] = "Kiểm tra tốc độ tải Website";
            table.Rows.Add(values);
            values[0] = "http://www.google.com/webmasters/tools/richsnippets?url=$domain$&html=&hl=vi";
            values[1] = "Check Rich Snippets Testing Tool";
            table.Rows.Add(values);
            this.cbWebReport.DataSource = table;
            this.cbWebReport.ValueMember = "Value";
            this.cbWebReport.DisplayMember = "Name";
        }

        private void tbSocial_Enter(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable("Url");
                table.Columns.Add("Value", typeof(string));
                table.Columns.Add("Name", typeof(string));
                object[] values = new object[] { "https://plus.google.com/share?url=$url$", "Google+" };
                table.Rows.Add(values);
                values[0] = "http://www.facebook.com/share.php?u=$url$";
                values[1] = "Facebook.com";
                table.Rows.Add(values);
                values[0] = "http://twitter.com/home?status=$url$";
                values[1] = "Twitter.com";
                table.Rows.Add(values);
                values[0] = "http://linkhay.com/submit?link_url=$url$";
                values[1] = "LinkHay.com";
                table.Rows.Add(values);
                values[0] = "http://link.apps.zing.vn/share?url=$url$";
                values[1] = "Zing.vn";
                values[0] = "http://del.icio.us/post?url=$url$";
                values[1] = "Del.icio.us";
                table.Rows.Add(values);
                values[0] = "http://www.diigo.com/post?url=$url$&title=$url$";
                values[1] = "Diigo.com";
                table.Rows.Add(values);
                values[0] = "http://www.linkedin.com/shareArticle?url=$url$";
                values[1] = "LinkedIn.com";
                table.Rows.Add(values);
                values[0] = "http://digg.com/submit?url=$url$";
                values[1] = "Digg.com";
                table.Rows.Add(values);
                values[0] = "http://www.stumbleupon.com/submit?url=$url$";
                values[1] = "StumbleUpon.com";
                table.Rows.Add(values);
                values[0] = "http://www.tumblr.com/share?v=3&u=$url$";
                values[1] = "Tumblr.com";
                table.Rows.Add(values);
                this.listSocial.DataSource = table;
                this.listSocial.ValueMember = "Value";
                this.listSocial.DisplayMember = "Name";
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void tbSubmit_Enter(object sender, EventArgs e)
        {
            try
            {
                if (this.cbAttributeCate.SelectedValue == null)
                {
                    this.method_58();
                }
                if (this.cbSubmitCate.SelectedValue == null)
                {
                    this.method_59();
                    this.method_60();
                }
                DataTable table = new DataTable();
                table.Columns.Add("Value", typeof(string));
                table.Columns.Add("Name", typeof(string));
                object[] values = new object[] { "LIKE_FB", "Like Facebook" };
                table.Rows.Add(values);
                values[0] = "GOOGLE_LIKE";
                values[1] = "+1 Google Plus";
                table.Rows.Add(values);
                values[0] = "CHECK_FB";
                values[1] = "Tags Facebook";
                table.Rows.Add(values);
                values[0] = "THANKS_XF";
                values[1] = "Thanks diễn đ\x00e0n XenForo";
                table.Rows.Add(values);
                values[0] = "THANKS_VBB";
                values[1] = "Thanks diễn đ\x00e0n VBB";
                table.Rows.Add(values);
                values[0] = "THANKS_MUARE";
                values[1] = "Thanks Muare.vn";
                table.Rows.Add(values);
                this.cbAuto.DataSource = table;
                this.cbAuto.ValueMember = "Value";
                this.cbAuto.DisplayMember = "Name";
            }
            catch
            {
            }
        }

        private void tbView_Enter(object sender, EventArgs e)
        {
            this.txtViewWebsite.Text = this.infoSEO_0.Website;
            this.lbViewCoin.Text = this.infoSEO_0.iCoin.ToString();
            this.lbViewClick.Text = this.infoSEO_0.Click.ToString();
            if (this.infoSEO_0.ClickStatus == 0)
            {
                this.rdViewDisable.Checked = true;
            }
            else
            {
                this.rdViewEnable.Checked = true;
            }
            if ((this.list_15 == null) || (this.list_15.Count < 1))
            {
                this.list_15 = this.method_98();
            }
            this.int_19 = 10;
            this.lbViewTime.Text = this.int_19.ToString();
        }

        private void timer_1_Tick(object sender, EventArgs e)
        {
            this.bool_2 = false;
            this.int_8 = 0;
            this.list_9 = new List<Class15>();
            string str = "SELECT * FROM Articles WHERE CategoryID='" + this.dtvArticleCate.CurrentRow.Cells[0].Value.ToString() + "' AND Follow=True ORDER BY ArticleID DESC";
            foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
            {
                Class15 item = new Class15();
                item.method_1(row["ArticleID"].ToString());
                item.method_5(row["Url"].ToString());
                this.list_9.Add(item);
            }
            int count = this.list_9.Count;
            if (count > 10)
            {
                count = 10;
            }
            this.int_12 = 0;
            this.int_13 = count;
            for (int i = 0; i < count; i++)
            {
                new Thread(new ThreadStart(this.method_55)) { IsBackground = true }.Start();
                Thread.Sleep(50);
            }
            new Thread(new ThreadStart(this.method_57)) { IsBackground = true }.Start();
        }

        private void timer_2_Tick(object sender, EventArgs e)
        {
            string outerHtml = this.webBrowser_0.Document.Body.OuterHtml;
            this.list_14 = this.gclass4_0.method_5(outerHtml);
            this.dtvKTList.Rows.Clear();
            foreach (GClass13 class2 in this.list_14)
            {
                object[] values = new object[] { class2.string_0, class2.int_0, class2.long_0, class2.long_1, "", "", "" };
                this.dtvKTList.Rows.Add(values);
            }
            this.picLoader.Hide();
            this.timer_2.Enabled = false;
        }

        private void timer_3_Tick(object sender, EventArgs e)
        {
            this.lbViewTime.Text = this.int_19.ToString();
            if (this.int_19 == 0)
            {
                this.picLoader.Hide();
                this.timer_3.Enabled = false;
            }
            this.int_19--;
        }

        private void timer_4_Tick(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.method_100)) { IsBackground = true }.Start();
            this.timer_4.Interval = 0x5265c00;
        }

        private void timer_5_Tick(object sender, EventArgs e)
        {
            this.bool_8 = true;
            int index = this.dtvSubmit.CurrentRow.Index;
            if (index >= (this.dtvSubmit.Rows.Count - 1))
            {
                MessageBox.Show("Auto Submit ho\x00e0n tất!", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.timer_5.Enabled = false;
                this.timer_5.Stop();
                this.bool_8 = false;
                this.btnSubmitAuto.Text = "Bắt Đầu";
            }
            else
            {
                index++;
                this.dtvSubmit.Rows[index].Selected = true;
                this.dtvSubmit.Rows[index].Cells[1].Selected = true;
                this.dtvSubmit.FirstDisplayedScrollingRowIndex = index;
                this.txtSubmitAddress.Text = this.dtvSubmit.CurrentRow.Cells[1].Value.ToString();
                this.cbAttributeCate.SelectedValue = this.dtvSubmit.CurrentRow.Cells[2].Value.ToString();
                this.btnSubmitView.PerformClick();
            }
        }

        private void timer_6_Tick(object sender, EventArgs e)
        {
            int index = this.dtvPingProxy.CurrentRow.Index;
            if (index >= (this.dtvPingProxy.Rows.Count - 1))
            {
                MessageBox.Show("Auto Ping View ho\x00e0n tất!", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.timer_6.Enabled = false;
                this.timer_6.Stop();
                this.btnPingViewAuto.Text = "Bắt Đầu";
            }
            else
            {
                index++;
                this.dtvPingProxy.Rows[index].Selected = true;
                this.dtvPingProxy.Rows[index].Cells[0].Selected = true;
                this.dtvPingProxy.FirstDisplayedScrollingRowIndex = index;
                this.btnPingWebView.PerformClick();
            }
        }

        private void toolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                this.bool_0 = false;
            }
            else
            {
                this.bool_0 = true;
                this.point_0 = new Point(e.X, e.Y);
            }
        }

        private void toolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.bool_0)
            {
                Point point = base.PointToScreen(new Point(e.X, e.Y));
                point.Offset(-this.point_0.X, -this.point_0.Y);
                base.Location = point;
            }
        }

        private void toolBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.bool_0 = false;
        }

        private void txtCheckBLUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnCheckBLOK.PerformClick();
            }
        }

        private void txtCheckIndexKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnCheckGoogleIndex.PerformClick();
            }
        }

        private void txtDomain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnCheck.PerformClick();
            }
        }

        private void txtKeyFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnKeyFilter.PerformClick();
            }
        }

        private void txtKeyResearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSuggest.PerformClick();
            }
        }

        private void txtKTDomain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnKTCheckDomain.PerformClick();
            }
        }

        private void txtKTEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnKTLogin.PerformClick();
            }
        }

        private void txtKTKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnKTSend.PerformClick();
            }
        }

        private void txtKTKeyFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnKTFilter.PerformClick();
            }
        }

        private void txtNewsCate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    this.picLoader.Show();
                    new Thread(new ParameterizedThreadStart(this.method_79)) { IsBackground = true }.Start(false);
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void txtPingUrl_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void txtRivalDomain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnRivalCheck.PerformClick();
            }
        }

        private void txtSearchBLExt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSearchBacklink.PerformClick();
            }
        }

        private void txtSearchBLGExt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSearchBacklink.PerformClick();
            }
        }

        private void txtSearchBLKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSearchBacklink.PerformClick();
            }
        }

        private void txtSearchBLLang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSearchBacklink.PerformClick();
            }
        }

        private void txtSocialUrl_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void txtSubmitAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { string_0 = "SUBMIT" }.ShowDialog();
            this.method_59();
        }

        private void txtSubmitAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSubmitView.PerformClick();
            }
        }

        private void txtWebReport_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnCheckWeb.PerformClick();
            }
        }

        private void txtWebsiteCheck_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnCheckIndex.PerformClick();
            }
        }

        private void txtWebsiteUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnAnalytics.PerformClick();
            }
        }

        private void webBrowser_0_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.method_99();
            HtmlDocument document = (sender as WebBrowser).Document;
            if (document.Body.OuterHtml.IndexOf("\x00dd tưởng từ kh\x00f3a") > 0)
            {
                this.webBrowser_0.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.webBrowser_0_DocumentCompleted);
                this.picLoader.Hide();
            }
            else if (document.Body.OuterHtml.IndexOf("Đăng nhập") > 0)
            {
                this.webBrowser_0.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.webBrowser_0_DocumentCompleted);
                MessageBox.Show("Đăng nhập Adword để sử dụng!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.picLoader.Hide();
            }
        }

        private void webBrowser_0_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if ((sender as WebBrowser).Document.Body.OuterHtml.IndexOf("Đăng nhập") > 0)
            {
                MessageBox.Show("Email or Mật khẩu sai, H\x00e3y thử lại!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.webBrowser_0.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.webBrowser_0_DocumentCompleted_1);
                MessageBox.Show("Đăng nhập th\x00e0nh c\x00f4ng, H\x00e3y nhập từ kho\x00e1 để kiểm tra!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.picLoader.Hide();
        }

        private void webProxy_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.btnPingViewAuto.Text.Equals("Dừng Lại"))
            {
                this.timer_6.Enabled = true;
                this.timer_6.Start();
            }
            this.picLoader.Hide();
        }

        private void webProxy_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.picLoader.Show();
        }

        private void webSubmit_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.txtSubmitAddress.Text = this.webSubmit.Document.Url.ToString();
            if (this.bool_6)
            {
                this.method_66();
            }
            this.bool_5 = true;
            if (this.bool_8)
            {
                this.method_67();
            }
            this.picLoader.Hide();
            this.method_99();
        }

        private void webSubmit_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.picLoader.Show();
        }

        private class Class10
        {
            public string string_0 = "";
            public string string_1 = "";
            public string string_2 = "";
            public string string_3 = "";
        }

        private class Class11
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private long long_0;
            [CompilerGenerated]
            private short short_0;
            [CompilerGenerated]
            private short short_1;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_1)
            {
                this.string_0 = string_1;
            }

            [CompilerGenerated]
            public long method_2() => 
                this.long_0;

            [CompilerGenerated]
            public void method_3(long long_1)
            {
                this.long_0 = long_1;
            }

            [CompilerGenerated]
            public short method_4() => 
                this.short_0;

            [CompilerGenerated]
            public void method_5(short short_2)
            {
                this.short_0 = short_2;
            }

            [CompilerGenerated]
            public short method_6() => 
                this.short_1;

            [CompilerGenerated]
            public void method_7(short short_2)
            {
                this.short_1 = short_2;
            }
        }

        private class Class12
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private short short_0;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_1)
            {
                this.string_0 = string_1;
            }

            [CompilerGenerated]
            public short method_2() => 
                this.short_0;

            [CompilerGenerated]
            public void method_3(short short_1)
            {
                this.short_0 = short_1;
            }
        }

        private class Class13
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private int int_0;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_1)
            {
                this.string_0 = string_1;
            }

            [CompilerGenerated]
            public int method_2() => 
                this.int_0;

            [CompilerGenerated]
            public void method_3(int int_1)
            {
                this.int_0 = int_1;
            }
        }

        private class Class14
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;
            [CompilerGenerated]
            private string string_2;
            [CompilerGenerated]
            private string string_3;
            [CompilerGenerated]
            private string string_4;
            [CompilerGenerated]
            private string string_5;
            [CompilerGenerated]
            private string string_6;
            [CompilerGenerated]
            private string string_7;
            [CompilerGenerated]
            private string string_8;
            [CompilerGenerated]
            private string string_9;
            [CompilerGenerated]
            private string string_10;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_11)
            {
                this.string_0 = string_11;
            }

            [CompilerGenerated]
            public string method_10() => 
                this.string_5;

            [CompilerGenerated]
            public void method_11(string string_11)
            {
                this.string_5 = string_11;
            }

            [CompilerGenerated]
            public string method_12() => 
                this.string_6;

            [CompilerGenerated]
            public void method_13(string string_11)
            {
                this.string_6 = string_11;
            }

            [CompilerGenerated]
            public string method_14() => 
                this.string_7;

            [CompilerGenerated]
            public void method_15(string string_11)
            {
                this.string_7 = string_11;
            }

            [CompilerGenerated]
            public string method_16() => 
                this.string_8;

            [CompilerGenerated]
            public void method_17(string string_11)
            {
                this.string_8 = string_11;
            }

            [CompilerGenerated]
            public string method_18() => 
                this.string_9;

            [CompilerGenerated]
            public void method_19(string string_11)
            {
                this.string_9 = string_11;
            }

            [CompilerGenerated]
            public string method_2() => 
                this.string_1;

            [CompilerGenerated]
            public string method_20() => 
                this.string_10;

            [CompilerGenerated]
            public void method_21(string string_11)
            {
                this.string_10 = string_11;
            }

            [CompilerGenerated]
            public void method_3(string string_11)
            {
                this.string_1 = string_11;
            }

            [CompilerGenerated]
            public string method_4() => 
                this.string_2;

            [CompilerGenerated]
            public void method_5(string string_11)
            {
                this.string_2 = string_11;
            }

            [CompilerGenerated]
            public string method_6() => 
                this.string_3;

            [CompilerGenerated]
            public void method_7(string string_11)
            {
                this.string_3 = string_11;
            }

            [CompilerGenerated]
            public string method_8() => 
                this.string_4;

            [CompilerGenerated]
            public void method_9(string string_11)
            {
                this.string_4 = string_11;
            }
        }

        private class Class15
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;
            [CompilerGenerated]
            private string string_2;
            [CompilerGenerated]
            private string string_3;
            [CompilerGenerated]
            private string string_4;
            [CompilerGenerated]
            private string string_5;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_6)
            {
                this.string_0 = string_6;
            }

            [CompilerGenerated]
            public string method_10() => 
                this.string_5;

            [CompilerGenerated]
            public void method_11(string string_6)
            {
                this.string_5 = string_6;
            }

            [CompilerGenerated]
            public string method_2() => 
                this.string_1;

            [CompilerGenerated]
            public void method_3(string string_6)
            {
                this.string_1 = string_6;
            }

            [CompilerGenerated]
            public string method_4() => 
                this.string_2;

            [CompilerGenerated]
            public void method_5(string string_6)
            {
                this.string_2 = string_6;
            }

            [CompilerGenerated]
            public string method_6() => 
                this.string_3;

            [CompilerGenerated]
            public void method_7(string string_6)
            {
                this.string_3 = string_6;
            }

            [CompilerGenerated]
            public string method_8() => 
                this.string_4;

            [CompilerGenerated]
            public void method_9(string string_6)
            {
                this.string_4 = string_6;
            }
        }

        private class Class16
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private int int_1;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_1)
            {
                this.string_0 = string_1;
            }

            [CompilerGenerated]
            public int method_2() => 
                this.int_0;

            [CompilerGenerated]
            public void method_3(int int_2)
            {
                this.int_0 = int_2;
            }

            [CompilerGenerated]
            public int method_4() => 
                this.int_1;

            [CompilerGenerated]
            public void method_5(int int_2)
            {
                this.int_1 = int_2;
            }
        }

        private class Class17
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;
            [CompilerGenerated]
            private string string_2;
            [CompilerGenerated]
            private int int_0;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_3)
            {
                this.string_0 = string_3;
            }

            [CompilerGenerated]
            public string method_2() => 
                this.string_1;

            [CompilerGenerated]
            public void method_3(string string_3)
            {
                this.string_1 = string_3;
            }

            [CompilerGenerated]
            public string method_4() => 
                this.string_2;

            [CompilerGenerated]
            public void method_5(string string_3)
            {
                this.string_2 = string_3;
            }

            [CompilerGenerated]
            public int method_6() => 
                this.int_0;

            [CompilerGenerated]
            public void method_7(int int_1)
            {
                this.int_0 = int_1;
            }
        }

        private class Class18
        {
            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;
            [CompilerGenerated]
            private int int_1;

            [CompilerGenerated]
            public int method_0() => 
                this.int_0;

            [CompilerGenerated]
            public void method_1(int int_2)
            {
                this.int_0 = int_2;
            }

            [CompilerGenerated]
            public string method_2() => 
                this.string_0;

            [CompilerGenerated]
            public void method_3(string string_2)
            {
                this.string_0 = string_2;
            }

            [CompilerGenerated]
            public string method_4() => 
                this.string_1;

            [CompilerGenerated]
            public void method_5(string string_2)
            {
                this.string_1 = string_2;
            }

            [CompilerGenerated]
            public int method_6() => 
                this.int_1;

            [CompilerGenerated]
            public void method_7(int int_2)
            {
                this.int_1 = int_2;
            }
        }

        private class Class19
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;
            [CompilerGenerated]
            private string string_2;
            [CompilerGenerated]
            private string string_3;
            [CompilerGenerated]
            private string string_4;
            [CompilerGenerated]
            private string string_5;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_6)
            {
                this.string_0 = string_6;
            }

            [CompilerGenerated]
            public string method_10() => 
                this.string_5;

            [CompilerGenerated]
            public void method_11(string string_6)
            {
                this.string_5 = string_6;
            }

            [CompilerGenerated]
            public string method_2() => 
                this.string_1;

            [CompilerGenerated]
            public void method_3(string string_6)
            {
                this.string_1 = string_6;
            }

            [CompilerGenerated]
            public string method_4() => 
                this.string_2;

            [CompilerGenerated]
            public void method_5(string string_6)
            {
                this.string_2 = string_6;
            }

            [CompilerGenerated]
            public string method_6() => 
                this.string_3;

            [CompilerGenerated]
            public void method_7(string string_6)
            {
                this.string_3 = string_6;
            }

            [CompilerGenerated]
            public string method_8() => 
                this.string_4;

            [CompilerGenerated]
            public void method_9(string string_6)
            {
                this.string_4 = string_6;
            }
        }

        private class Class20
        {
            public string string_0;
            public string string_1;
            public string string_2;
            public bool bool_0;
            public bool bool_1;
        }

        [CompilerGenerated]
        private sealed class Class21
        {
            public int int_0;
            public int int_1;
            public int int_2;
            public string string_0;
            public string string_1;
            public string string_2;
            public string string_3;
            public List<frmMain.Class6> list_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                foreach (frmMain.Class5 class2 in this.frmMain_0.list_1)
                {
                    using (List<GClass8>.Enumerator enumerator2 = this.frmMain_0.gclass4_0.method_4(class2.string_0).GetEnumerator())
                    {
                        Predicate<frmMain.Class6> match = null;
                        Class22 class3 = new Class22 {
                            class21_0 = this
                        };
                        while (enumerator2.MoveNext())
                        {
                            class3.gclass8_0 = enumerator2.Current;
                            this.int_1++;
                            if (!string.IsNullOrEmpty(this.string_1) && (class3.gclass8_0.method_0().IndexOf(this.string_1) >= 0))
                            {
                                this.int_0 ??= this.int_1;
                            }
                            this.string_0 = this.string_0 + "<div class=\"item\">";
                            object[] objArray = new object[] { this.string_0, "<p class=\"title\"><span class=\"stt\">", this.int_1, "</span><a target=\"_blank\" href=", class3.gclass8_0.method_0(), ">", class3.gclass8_0.method_2(), "</a></p>" };
                            this.string_0 = string.Concat(objArray);
                            this.string_0 = this.string_0 + "<p>" + class3.gclass8_0.method_4().Replace("<a", "<a target=\"_blank\"") + "</p>";
                            this.string_0 = this.string_0 + "<p class=\"link\">Link: " + class3.gclass8_0.method_0() + "</p>";
                            this.string_0 = this.string_0 + "</div></div></div>";
                            try
                            {
                                string host = new Uri(class3.gclass8_0.method_0()).Host;
                                if ((host.IndexOf(this.string_2) >= 0) && (this.string_3.IndexOf(host) < 0))
                                {
                                    this.string_3 = this.string_3 + host + ", ";
                                }
                            }
                            catch
                            {
                            }
                            if (this.list_0.Count > 0)
                            {
                                if (match == null)
                                {
                                    match = new Predicate<frmMain.Class6>(class3.method_0);
                                }
                                int num = this.list_0.FindIndex(match);
                                if ((num >= 0) && (this.list_0[num].method_2() == 0))
                                {
                                    this.list_0[num].method_3(this.int_1);
                                }
                            }
                        }
                    }
                    if (this.int_0 > 0)
                    {
                        this.int_2 ??= class2.int_0;
                    }
                }
            }

            public void method_1()
            {
                decimal num = this.frmMain_0.gclass4_0.method_7(this.frmMain_0.list_1[0].string_0);
                string[] strArray = new string[] { "<div class=\"item\">", "<p><strong>Từ kho\x00e1:</strong> \"", this.frmMain_0.txtKeyword.Text.ToString(), "\" - Website: ", this.frmMain_0.txtDomain.Text.ToString(), "</p>" };
                string str = ((string.Concat(strArray) + "<p><strong>TOP " + this.int_0.ToString() + "</strong> - Trang: " + this.int_2.ToString() + " - T\x00ecm thấy: " + this.frmMain_0.gclass4_0.method_8(num)) + "<p><strong>Cạnh tranh DomainKey:</strong> " + this.string_3 + "</p>") + "<p><strong>Đối thủ:</strong> ";
                foreach (frmMain.Class6 class2 in this.list_0)
                {
                    int num2;
                    string str5 = str;
                    string[] strArray3 = new string[] { str5, class2.method_0(), " Top ", num2.ToString(), "; " };
                    num2 = class2.method_2();
                    str = string.Concat(strArray3);
                }
                str = str + "</p>" + "</div>";
                this.frmMain_0.webMain.DocumentText = "<html><head>\r\n                    <style>\r\n                    body{font-family:Arial, Helvetica, sans-serif; font-size:13px;}\r\n                    p{padding:4px; margin:0;}\r\n                    p.title{font-size:16px;}\r\n                    em{font-weight:bold; font-style:normal;}\r\n                    a{color:#2200C1;}\r\n                    span.stt{font-size:16px; color:#F00; font-weight:bold; margin-right:5px;}\r\n                    p.link{font-style:italic;}\r\n                    .item{padding-bottom:10px; border-bottom:1px dotted #CCC;}\r\n                    </style>\r\n                    </head><body>" + str + this.string_0 + "</body></html>";
                object[] objArray = new object[] { "SELECT * FROM Keywords WHERE CategoryID ='", this.frmMain_0.cbKeyCate.SelectedValue, "' AND Key='", this.frmMain_0.txtKeyword.Text.Trim(), "' AND Website='", this.frmMain_0.txtDomain.Text.Trim(), "' AND Lang='", this.frmMain_0.txtLang.Text.Trim(), "' AND Ext='" };
                objArray[9] = this.frmMain_0.txtExt.Text.Trim();
                objArray[10] = "'";
                string str2 = string.Concat(objArray);
                if (this.frmMain_0.gclass4_0.method_40(str2).Rows.Count > 0)
                {
                    object[] objArray2 = new object[] { "UPDATE Keywords SET TopOld=IIF([Top]=", this.int_0.ToString(), ", TopOld,[Top]), [Top]=", this.int_0.ToString(), ", SERP=", num.ToString(), " WHERE CategoryID ='", this.frmMain_0.cbKeyCate.SelectedValue, "' AND Key='" };
                    objArray2[9] = this.frmMain_0.txtKeyword.Text.Trim();
                    objArray2[10] = "' AND Website='";
                    objArray2[11] = this.frmMain_0.txtDomain.Text.Trim();
                    objArray2[12] = "' AND Lang='";
                    objArray2[13] = this.frmMain_0.txtLang.Text.Trim();
                    objArray2[14] = "' AND Ext='";
                    objArray2[15] = this.frmMain_0.txtExt.Text.Trim();
                    objArray2[0x10] = "'";
                    this.frmMain_0.gclass4_0.method_42(string.Concat(objArray2));
                    this.frmMain_0.method_26();
                }
                this.frmMain_0.picLoader.Hide();
            }

            private sealed class Class22
            {
                public frmMain.Class21 class21_0;
                public GClass8 gclass8_0;

                public bool method_0(frmMain.Class6 class6_0) => 
                    this.gclass8_0.method_0().IndexOf(class6_0.method_0()) >= 0;
            }
        }

        [CompilerGenerated]
        private sealed class Class23
        {
            public List<frmMain.Class7> list_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.frmMain_0.dtvResultCheck.Rows.Clear();
                foreach (frmMain.Class7 class2 in this.list_0)
                {
                    object[] values = new object[] { class2.method_0(), class2.method_2() };
                    this.frmMain_0.dtvResultCheck.Rows.Add(values);
                }
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class24
        {
            public string string_0;
            public string string_1;
            public frmMain frmMain_0;

            public void method_0()
            {
                object[] values = new object[] { this.string_1, this.string_0 };
                this.frmMain_0.dtvCheckResult.Rows.Add(values);
            }
        }

        [CompilerGenerated]
        private sealed class Class25
        {
            public string string_0;
            public string string_1;
            public string string_2;
            public List<frmMain.Class10> list_0;
            public string string_3;
            public List<frmMain.Class9> list_1;
            public List<frmMain.Class8> list_2;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.frmMain_0.dtvAnalytics.Rows.Clear();
                foreach (frmMain.Class10 class2 in this.list_0)
                {
                    object[] values = new object[] { class2.string_0, class2.string_1, class2.string_2, class2.string_3 };
                    this.frmMain_0.dtvAnalytics.Rows.Add(values);
                }
                this.frmMain_0.dtvAnalyticsHeading.Rows.Clear();
                int num = 0;
                foreach (frmMain.Class9 class3 in this.list_1)
                {
                    num += class3.method_2();
                    object[] values = new object[] { class3.method_0(), class3.method_4(), class3.method_2(), class3.method_6() };
                    this.frmMain_0.dtvAnalyticsHeading.Rows.Add(values);
                }
                string[] strArray = new string[] { this.list_1.Count.ToString(), " Thẻ Heading - Từ kho\x00e1 lặp \"", this.string_2, "\": ", num.ToString() };
                this.frmMain_0.lbAnalyticsHeading.Text = string.Concat(strArray);
                this.frmMain_0.dtvAnalyticsImage.Rows.Clear();
                int num2 = 0;
                foreach (frmMain.Class8 class4 in this.list_2)
                {
                    num2 += class4.method_2();
                    object[] values = new object[] { class4.method_0(), class4.method_6(), class4.method_2(), this.frmMain_0.gclass4_0.method_14(this.string_0, class4.method_4(), string.Empty) };
                    this.frmMain_0.dtvAnalyticsImage.Rows.Add(values);
                }
                string[] strArray2 = new string[] { this.list_2.Count.ToString(), " H\x00ecnh ảnh - Từ kho\x00e1 lặp \"", this.string_2, "\": ", num2.ToString() };
                this.frmMain_0.lbAnalyticsImage.Text = string.Concat(strArray2);
                this.frmMain_0.method_17();
                this.frmMain_0.dtvAnalyticsWord1.Rows.Clear();
                this.frmMain_0.dtvAnalyticsWord2.Rows.Clear();
                this.frmMain_0.dtvAnalyticsWord3.Rows.Clear();
                this.frmMain_0.dtvAnalyticsWord4.Rows.Clear();
                List<string> list = this.frmMain_0.gclass4_0.method_11(this.string_3);
                foreach (GClass10 class5 in this.frmMain_0.gclass4_0.method_9(list, 1, 1))
                {
                    object[] values = new object[] { class5.method_0(), class5.method_2(), class5.method_4() };
                    this.frmMain_0.dtvAnalyticsWord1.Rows.Add(values);
                }
                foreach (GClass10 class6 in this.frmMain_0.gclass4_0.method_9(list, 2, 3))
                {
                    object[] values = new object[] { class6.method_0(), class6.method_2(), class6.method_4() };
                    this.frmMain_0.dtvAnalyticsWord2.Rows.Add(values);
                }
                foreach (GClass10 class7 in this.frmMain_0.gclass4_0.method_9(list, 3, 3))
                {
                    object[] values = new object[] { class7.method_0(), class7.method_2(), class7.method_4() };
                    this.frmMain_0.dtvAnalyticsWord3.Rows.Add(values);
                }
                foreach (GClass10 class8 in this.frmMain_0.gclass4_0.method_9(list, 4, 3))
                {
                    object[] values = new object[] { class8.method_0(), class8.method_2(), class8.method_4() };
                    this.frmMain_0.dtvAnalyticsWord4.Rows.Add(values);
                }
                this.frmMain_0.txtAnalyticsHTML.Text = this.string_1;
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class26
        {
            public int int_0;
            public List<frmMain.Class12> list_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.int_0 = Convert.ToInt16(this.frmMain_0.cbDepthKey.Text);
            }

            public void method_1()
            {
                this.frmMain_0.dtvSuggest.Rows.Clear();
                lock (this.frmMain_0.list_3)
                {
                    foreach (frmMain.Class11 class2 in this.frmMain_0.list_3)
                    {
                        object[] values = new object[] { class2.method_0(), class2.method_6(), class2.method_2(), class2.method_4() };
                        int num = this.frmMain_0.dtvSuggest.Rows.Add(values);
                        this.frmMain_0.dtvSuggest.Rows[num].Tag = class2;
                    }
                    this.frmMain_0.lbSuggestTotal.Text = this.frmMain_0.list_3.Count.ToString() + " Từ kh\x00f3a li\x00ean quan!";
                    foreach (frmMain.Class11 class3 in this.frmMain_0.list_3)
                    {
                        Class27 class6 = new Class27();
                        char[] separator = new char[] { ' ' };
                        class6.string_0 = class3.method_0().Split(separator);
                        Predicate<frmMain.Class12> match = null;
                        Class28 class5 = new Class28 {
                            class27_0 = class6,
                            class26_0 = this,
                            int_0 = 0
                        };
                        while (class5.int_0 < class6.string_0.Length)
                        {
                            if (match == null)
                            {
                                match = new Predicate<frmMain.Class12>(class5.method_0);
                            }
                            int num2 = this.list_0.FindIndex(match);
                            if (num2 >= 0)
                            {
                                frmMain.Class12 local1 = this.list_0[num2];
                                local1.method_3((short) (local1.method_2() + 1));
                            }
                            else
                            {
                                frmMain.Class12 item = new frmMain.Class12();
                                item.method_1(class6.string_0[class5.int_0]);
                                item.method_3(1);
                                this.list_0.Add(item);
                            }
                            class5.int_0++;
                        }
                    }
                }
                this.frmMain_0.dtvTags.Rows.Clear();
                foreach (frmMain.Class12 class7 in this.list_0)
                {
                    object[] values = new object[] { class7.method_0(), class7.method_2() };
                    int num3 = this.frmMain_0.dtvTags.Rows.Add(values);
                    this.frmMain_0.dtvTags.Rows[num3].Tag = class7;
                }
                this.frmMain_0.lbTagsTotal.Text = this.list_0.Count.ToString() + " Từ được t\x00ecm thấy!";
                this.frmMain_0.picLoader.Hide();
            }

            private sealed class Class27
            {
                public string[] string_0;
            }

            private sealed class Class28
            {
                public frmMain.Class26.Class27 class27_0;
                public frmMain.Class26 class26_0;
                public int int_0;

                public bool method_0(frmMain.Class12 class12_0) => 
                    class12_0.method_0().Equals(this.class27_0.string_0[this.int_0]);
            }
        }

        [CompilerGenerated]
        private sealed class Class29
        {
            public XmlNode xmlNode_0;

            public bool method_0(frmMain.Class11 class11_0) => 
                class11_0.method_0().Equals(this.xmlNode_0.SelectSingleNode("suggestion/@data").InnerText);
        }

        [CompilerGenerated]
        private sealed class Class30
        {
            public string string_0;
            public int int_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                object[] values = new object[] { "PR " + this.int_0.ToString() + "/10", this.string_0 };
                this.frmMain_0.dtvCheckResult.Rows.Add(values);
                this.int_0 = 0;
            }
        }

        [CompilerGenerated]
        private sealed class Class31
        {
            public string string_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.string_0 = this.frmMain_0.cbKeyCate.SelectedValue.ToString();
            }
        }

        [CompilerGenerated]
        private sealed class Class32
        {
            public List<GClass11> list_0;
            public List<GClass11> list_1;
            public List<GClass11> list_2;
            public List<GClass11> list_3;
            public List<GClass12> list_4;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.frmMain_0.dtvRivalTop.Rows.Clear();
                foreach (GClass11 class2 in this.list_0)
                {
                    object[] values = new object[] { class2.method_0(), class2.method_2() };
                    this.frmMain_0.dtvRivalTop.Rows.Add(values);
                }
                this.frmMain_0.dtvRivalMonth1.Rows.Clear();
                foreach (GClass11 class3 in this.list_1)
                {
                    object[] values = new object[] { class3.method_0(), class3.method_2() };
                    this.frmMain_0.dtvRivalMonth1.Rows.Add(values);
                }
                this.frmMain_0.dtvRivalMonth2.Rows.Clear();
                foreach (GClass11 class4 in this.list_2)
                {
                    object[] values = new object[] { class4.method_0(), class4.method_2() };
                    this.frmMain_0.dtvRivalMonth2.Rows.Add(values);
                }
                this.frmMain_0.dtvRivalHigh.Rows.Clear();
                foreach (GClass11 class5 in this.list_3)
                {
                    object[] values = new object[] { class5.method_0(), class5.method_2() };
                    this.frmMain_0.dtvRivalHigh.Rows.Add(values);
                }
                this.frmMain_0.dtvRivalList.Rows.Clear();
                foreach (GClass12 class6 in this.list_4)
                {
                    object[] values = new object[] { class6.method_0(), class6.method_2(), class6.method_4() };
                    this.frmMain_0.dtvRivalList.Rows.Add(values);
                }
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class33
        {
            public string string_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                if (!string.IsNullOrEmpty(this.frmMain_0.cbSearchBLFilter.SelectedValue.ToString()))
                {
                    this.string_0 = this.string_0 + this.frmMain_0.cbSearchBLFilter.SelectedValue;
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class34
        {
            public frmMain.Class33 class33_0;
            public string string_0;

            public bool method_0(frmMain.Class16 class16_0) => 
                class16_0.method_0().Equals(this.string_0);
        }

        [CompilerGenerated]
        private sealed class Class35
        {
            public string string_0;
            public string string_1;
            public frmMain frmMain_0;

            public void method_0()
            {
                frmSERP mserp = new frmSERP();
                mserp.dtvSERP.Rows.Clear();
                foreach (frmMain.Class18 class2 in this.frmMain_0.list_12)
                {
                    object[] values = new object[] { class2.method_0(), class2.method_2(), class2.method_6(), class2.method_4() };
                    int num = mserp.dtvSERP.Rows.Add(values);
                    mserp.dtvSERP.Rows[num].Tag = class2;
                }
                string[] strArray = new string[] { "C\x00f3 ", this.frmMain_0.gclass4_0.method_8(this.frmMain_0.gclass4_0.method_7(this.string_1)), " kết quả t\x00ecm kiếm từ kho\x00e1 \"", this.string_0, "\"" };
                mserp.lbResult.Text = string.Concat(strArray);
                mserp.ShowDialog();
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class36
        {
            public int int_0;
            public HtmlDocument htmlDocument_0;
            public string string_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.htmlDocument_0 = this.frmMain_0.webSubmit.Document;
                this.string_0 = this.frmMain_0.cbAuto.SelectedValue.ToString();
            }

            public void method_1()
            {
                MessageBox.Show("C\x00f3 " + this.int_0.ToString() + " thao t\x00e1c th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class37
        {
            public string string_0;
            public string string_1;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.frmMain_0.tbMain.SelectTab("tbHTML");
                this.frmMain_0.txtHTMLTitle.Text = !this.frmMain_0.ckNewsAuto1.Checked ? this.frmMain_0.dtvNews.CurrentRow.Cells[1].Value.ToString() : (this.frmMain_0.dtvNews.CurrentRow.Cells[1].Value.ToString() + " | " + this.frmMain_0.txtHTMLKeyword.Text.Trim());
                this.frmMain_0.txtHTMLDesc.Text = this.frmMain_0.dtvNews.CurrentRow.Cells[6].Value.ToString();
                this.string_0 = "<strong>" + this.frmMain_0.txtHTMLDesc.Text + "</strong>" + this.string_0;
                this.string_0 = this.string_0 + this.string_1;
                object[] objArray = new object[] { this.string_0 };
                this.frmMain_0.method_76("SetContents", objArray);
                string str = this.frmMain_0.dtvNews.CurrentRow.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    this.frmMain_0.gclass4_0.method_42("UPDATE NewsLogs SET [Status]=true WHERE NewsLogID='" + str + "'");
                }
                this.frmMain_0.dtvNews.CurrentRow.Cells[7].Value = true;
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class38
        {
            public bool bool_0;
            public string string_0;
            public List<frmMain.Class19> list_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                if (!this.bool_0)
                {
                    this.frmMain_0.dtvNews.Rows.Clear();
                    foreach (frmMain.Class19 class3 in this.list_0)
                    {
                        object[] values = new object[] { string.Empty, class3.method_0(), class3.method_4(), class3.method_8(), "http://www.baomoi.com" + class3.method_6() + ".epi", "http://www.baomoi.com/" + class3.method_10(), class3.method_2(), false };
                        this.frmMain_0.dtvNews.Rows.Add(values);
                    }
                }
                else
                {
                    foreach (frmMain.Class19 class2 in this.list_0)
                    {
                        try
                        {
                            string str = "INSERT INTO NewsLogs ([NewsLogID], [CategoryID], [Title], [Unique], [Source], [Link], [Url], [Image], [Desc], [Status], [Created]) VALUES('" + Guid.NewGuid() + "', @CategoryID, @Title, @Unique, @Source, @Link, @Url, @Image, @Desc, @Status, @Created)";
                            object[] objArray = new object[] { "@CategoryID", this.string_0, "@Title", class2.method_0(), "@Unique", this.string_0 + class2.method_0(), "@Source", class2.method_4(), "@Link" };
                            objArray[9] = class2.method_8();
                            objArray[10] = "@Url";
                            objArray[11] = class2.method_6();
                            objArray[12] = "@Image";
                            objArray[13] = class2.method_10();
                            objArray[14] = "@Desc";
                            objArray[15] = class2.method_2();
                            objArray[0x10] = "@Status";
                            objArray[0x11] = false;
                            objArray[0x12] = "@Created";
                            objArray[0x13] = DateTime.Now.ToString();
                            this.frmMain_0.gclass4_0.method_43(str, CommandType.Text, objArray);
                        }
                        catch
                        {
                        }
                    }
                    this.frmMain_0.method_105(this.string_0);
                }
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class39
        {
            public frmMain.Class38 class38_0;
            public GStruct3 gstruct3_0;

            public bool method_0(frmMain.Class19 class19_0) => 
                this.gstruct3_0.string_0.Equals(class19_0.method_0());
        }

        [CompilerGenerated]
        private sealed class Class40
        {
            public string string_0;
            public string string_1;
            public string[] string_2;
            public bool bool_0;
            public bool bool_1;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.string_0 = this.frmMain_0.method_76("GetContents", new object[0]).ToString();
                this.string_1 = this.frmMain_0.txtHTMLDesc.Text.Trim();
                this.string_2 = new string[this.frmMain_0.listHTMLCategory.SelectedItems.Count];
                int index = 0;
                foreach (DataRowView view in this.frmMain_0.listHTMLCategory.SelectedItems)
                {
                    this.string_2[index] = view[0].ToString();
                    index++;
                }
            }

            public void method_1()
            {
                if (this.bool_0)
                {
                    MessageBox.Show("Th\x00eam b\x00e0i th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (this.bool_1)
                {
                    MessageBox.Show("B\x00e0i viết đ\x00e3 tồn tại!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("C\x00f3 lỗi xảy ra! H\x00e3y kiểm tra lại kết nối!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.frmMain_0.picLoader.Hide();
                if (!this.frmMain_0.timer_4.Enabled || (this.frmMain_0.timer_4.Interval > 0x5265c00))
                {
                    this.frmMain_0.timer_4.Interval = 0xea60;
                    this.frmMain_0.timer_4.Enabled = true;
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class41
        {
            public string string_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.string_0 = this.frmMain_0.gclass4_0.method_36(this.frmMain_0.webSubmit.Document.Body.OuterHtml);
            }
        }

        [CompilerGenerated]
        private sealed class Class42
        {
            public string[] string_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                string str = this.frmMain_0.rtbRegexURL.Text.Trim();
                if (!string.IsNullOrEmpty(str))
                {
                    this.string_0 = Regex.Split(str, "\n");
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class43
        {
            public List<string> list_0;
            public List<string> list_1;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.frmMain_0.dtvPingProxy.Rows.Clear();
                using (List<string>.Enumerator enumerator = this.list_0.GetEnumerator())
                {
                    Predicate<string> match = null;
                    Class44 class2 = new Class44 {
                        class43_0 = this
                    };
                    while (enumerator.MoveNext())
                    {
                        class2.string_0 = enumerator.Current;
                        if (!this.frmMain_0.gclass4_0.method_37(this.frmMain_0.string_2).Equals(this.frmMain_0.infoSEO_0.Permission) && (this.list_1.Count > 20))
                        {
                            break;
                        }
                        if (!string.IsNullOrEmpty(class2.string_0))
                        {
                            if (match == null)
                            {
                                match = new Predicate<string>(class2.method_0);
                            }
                            if (this.list_1.FindIndex(match) < 0)
                            {
                                object[] values = new object[] { class2.string_0 };
                                this.frmMain_0.dtvPingProxy.Rows.Add(values);
                                this.list_1.Add(class2.string_0);
                            }
                        }
                    }
                }
                this.frmMain_0.picLoader.Hide();
            }

            private sealed class Class44
            {
                public frmMain.Class43 class43_0;
                public string string_0;

                public bool method_0(string string_1) => 
                    string_1.Equals(this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class45
        {
            public string string_0;
            public string string_1;
            public frmMain frmMain_0;

            public void method_0()
            {
                if (this.frmMain_0.cbHTMLAnchor.SelectedValue != null)
                {
                    this.string_0 = this.frmMain_0.cbHTMLAnchor.SelectedValue.ToString();
                }
                if (this.frmMain_0.cbHTMLContent.SelectedValue != null)
                {
                    this.string_1 = this.frmMain_0.cbHTMLContent.SelectedValue.ToString();
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class46
        {
            public frmMain.Class45 class45_0;
            public DataGridViewRow dataGridViewRow_0;

            public void method_0()
            {
                if (!string.IsNullOrEmpty(this.dataGridViewRow_0.Cells[0].Value.ToString()))
                {
                    this.class45_0.frmMain_0.gclass4_0.method_42("UPDATE NewsLogs SET [Status]=true WHERE NewsLogID='" + this.dataGridViewRow_0.Cells[0].Value.ToString() + "'");
                }
                this.dataGridViewRow_0.Cells[7].Value = true;
                this.dataGridViewRow_0.Selected = false;
            }
        }

        [CompilerGenerated]
        private sealed class Class47
        {
            public frmMain.Class46 class46_0;
            public frmMain.Class45 class45_0;
            public string[] string_0;

            public void method_0()
            {
                this.string_0 = new string[this.class45_0.frmMain_0.listHTMLCategory.SelectedItems.Count];
                int index = 0;
                foreach (DataRowView view in this.class45_0.frmMain_0.listHTMLCategory.SelectedItems)
                {
                    this.string_0[index] = view[0].ToString();
                    index++;
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class48
        {
            public string string_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.string_0 = this.frmMain_0.cbNewsCate.SelectedValue.ToString();
            }

            public void method_1()
            {
                this.frmMain_0.method_105(this.string_0);
                this.frmMain_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class49
        {
            public frmMain.Class48 class48_0;
            public GStruct3 gstruct3_0;

            public bool method_0(frmMain.Class19 class19_0) => 
                this.gstruct3_0.string_0.Equals(class19_0.method_0());
        }

        private class Class5
        {
            public int int_0;
            public string string_0;
        }

        [CompilerGenerated]
        private sealed class Class50
        {
            public string string_0;
            public frmMain frmMain_0;

            public void method_0()
            {
                this.frmMain_0.method_28(this.string_0);
                this.frmMain_0.picLoader.Hide();
            }
        }

        private class Class6
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private int int_0;

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_1)
            {
                this.string_0 = string_1;
            }

            [CompilerGenerated]
            public int method_2() => 
                this.int_0;

            [CompilerGenerated]
            public void method_3(int int_1)
            {
                this.int_0 = int_1;
            }
        }

        private class Class7
        {
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;

            public Class7(string A_0, string A_1)
            {
                this.method_1(A_0);
                this.method_3(A_1);
            }

            [CompilerGenerated]
            public string method_0() => 
                this.string_0;

            [CompilerGenerated]
            public void method_1(string string_2)
            {
                this.string_0 = string_2;
            }

            [CompilerGenerated]
            public string method_2() => 
                this.string_1;

            [CompilerGenerated]
            public void method_3(string string_2)
            {
                this.string_1 = string_2;
            }
        }

        private class Class8
        {
            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private int int_1;
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;

            [CompilerGenerated]
            public int method_0() => 
                this.int_0;

            [CompilerGenerated]
            public void method_1(int int_2)
            {
                this.int_0 = int_2;
            }

            [CompilerGenerated]
            public int method_2() => 
                this.int_1;

            [CompilerGenerated]
            public void method_3(int int_2)
            {
                this.int_1 = int_2;
            }

            [CompilerGenerated]
            public string method_4() => 
                this.string_0;

            [CompilerGenerated]
            public void method_5(string string_2)
            {
                this.string_0 = string_2;
            }

            [CompilerGenerated]
            public string method_6() => 
                this.string_1;

            [CompilerGenerated]
            public void method_7(string string_2)
            {
                this.string_1 = string_2;
            }
        }

        private class Class9
        {
            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private int int_1;
            [CompilerGenerated]
            private string string_0;
            [CompilerGenerated]
            private string string_1;

            [CompilerGenerated]
            public int method_0() => 
                this.int_0;

            [CompilerGenerated]
            public void method_1(int int_2)
            {
                this.int_0 = int_2;
            }

            [CompilerGenerated]
            public int method_2() => 
                this.int_1;

            [CompilerGenerated]
            public void method_3(int int_2)
            {
                this.int_1 = int_2;
            }

            [CompilerGenerated]
            public string method_4() => 
                this.string_0;

            [CompilerGenerated]
            public void method_5(string string_2)
            {
                this.string_0 = string_2;
            }

            [CompilerGenerated]
            public string method_6() => 
                this.string_1;

            [CompilerGenerated]
            public void method_7(string string_2)
            {
                this.string_1 = string_2;
            }
        }
    }
}

