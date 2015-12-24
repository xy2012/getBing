using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using getBing;

namespace getBing
{
    [DataContract]
    public class QueryResult : BindableBase
    {
        private LE _lexicon;
        private MT _machineTranslation;
        private SENTS _sentences;
        private SUGG _suggestion;
        private string _queryString;

        [DataMember(Name = "LEX")]
        public LE LexiconEntry
        {
            get
            {
                return this._lexicon;
            }
            set
            {
                if ((object.ReferenceEquals(this._lexicon, value) != true))
                {
                    this._lexicon = value;
                    this.OnPropertyChanged("Lexicon");
                }
            }
        }

            [DataMember(Name = "MT")]
             public MT MachineTranslation
             {
                 get
                 {
                     return this._machineTranslation;
                 }
                 set
                 {
                     if ((object.ReferenceEquals(this._machineTranslation, value) != true))
                     {
                         this._machineTranslation = value;
                         this.OnPropertyChanged("MachineTranslation");
                     }
                 }
             }

             [DataMember(Name = "SENT")]
             public SENTS Sentences
             {
                 get
                 {
                     return this._sentences;
                 }
                 set
                 {
                     if ((object.ReferenceEquals(this._sentences, value) != true))
                     {
                         this._sentences = value;
                         this.OnPropertyChanged("Sentences");
                     }
                 }
             }

             [DataMember(Name = "SUGG")]
             public SUGG Suggestion
             {
                 get
                 {
                     return this._suggestion;
                 }
                 set
                 {
                     if ((object.ReferenceEquals(this._suggestion, value) != true))
                     {
                         this._suggestion = value;
                         this.OnPropertyChanged("Suggestion");
                     }
                 }
             }

             [DataMember(Name = "Q")]
             public string QueryString
             {
                 get
                 {
                     return this._queryString;
                 }
                 set
                 {
                     if ((object.ReferenceEquals(this._queryString, value) != true))
                     {
                         this._queryString = value;
                         this.OnPropertyChanged("QueryString");
                     }
                 }
             } 
    }

    [DataContract(Name = "LE")]
    public class LE : BindableBase
    {
        private ObservableCollection<SENS> _crossSenses;
        private HW _headword;
        private ObservableCollection<SENS> _homeSenses;
        private ObservableCollection<INF> _inflections;
        private ObservableCollection<COLLS> _lexCollocations;
        private ObservableCollection<HW> _phrases;
        private ObservableCollection<PRON> _pronunciations;
        private ObservableCollection<THES> _thesauruses;

        [DataMember(Name = "C_DEF", IsRequired = false)]
        public ObservableCollection<SENS> CrossLangDef
        {
            get
            {
                return this._crossSenses;
            }
            set
            {
                if ((object.ReferenceEquals(this._crossSenses, value) != true))
                {
                    this._crossSenses = value;
                    this.OnPropertyChanged("CrossSenses");
                }
            }
        }

        [DataMember(Name = "HW", IsRequired = true)]
        public HW Headword
        {
            get
            {
                return this._headword;
            }
            set
            {
                if ((object.ReferenceEquals(this._headword, value) != true))
                {
                    this._headword = value;
                    this.OnPropertyChanged("Headword");
                }
            }
        }

        [DataMember(Name = "H_DEF", IsRequired = false)]
        public ObservableCollection<SENS> HomeSenses
        {
            get
            {
                return this._homeSenses;
            }
            set
            {
                if ((object.ReferenceEquals(this._homeSenses, value) != true))
                {
                    this._homeSenses = value;
                    this.OnPropertyChanged("HomeSenses");
                }
            }
        }

        [DataMember(Name = "INF", IsRequired = false)]
        public ObservableCollection<INF> Inflections
        {
            get
            {
                return this._inflections;
            }
            set
            {
                if ((object.ReferenceEquals(this.Inflections, value) != true))
                {
                    this._inflections = value;
                    this.OnPropertyChanged("Inflections");
                }
            }
        }

        [DataMember(Name = "LCS", IsRequired = false)]
        public ObservableCollection<COLLS> LexCollocations
        {
            get
            {
                return this._lexCollocations;
            }
            set
            {
                if ((object.ReferenceEquals(this._lexCollocations, value) != true))
                {
                    this._lexCollocations = value;
                    this.OnPropertyChanged("LexCollocations");
                }
            }
        }

        [DataMember(Name = "PHRASE", IsRequired = false)]
        public ObservableCollection<HW> Phrases
        {
            get
            {
                return this._phrases;
            }
            set
            {
                if ((object.ReferenceEquals(this._phrases, value) != true))
                {
                    this._phrases = value;
                    this.OnPropertyChanged("Phrases");
                }
            }
        }

        [DataMember(Name = "PRON", IsRequired = false)]
        public ObservableCollection<PRON> Pronunciations
        {
            get
            {
                return this._pronunciations;
            }
            set
            {
                if ((object.ReferenceEquals(this._pronunciations, value) != true))
                {
                    this._pronunciations = value;
                    this.OnPropertyChanged("Pronunciations");
                }
            }
        }

        [DataMember(Name = "THES", IsRequired = false)]
        public ObservableCollection<THES> Thesauruses
        {
            get
            {
                return this._thesauruses;
            }
            set
            {
                if ((object.ReferenceEquals(this._thesauruses, value) != true))
                {
                    this._thesauruses = value;
                    this.OnPropertyChanged("Thesauruses");
                }
            }
        }
    }

    public class HWINFS : HW
    {
        private IEnumerable<INF> _inflections;

        public IEnumerable<INF> Inflections
        {
            get
            {
                return this._inflections;
            }
            set
            {
                if ((object.ReferenceEquals(this._inflections, value) != true))
                {
                    this._inflections = value;
                    this.OnPropertyChanged("Inflections");
                }
            }
        }
    }

    [DataContract(Name = "HW")]
    public class HW : BindableBase
    {
        private string _definition;
        private string _signature;
        private string _value;

        [DataMember(Name = "DEF", IsRequired = false)]
        public string Definition
        {
            get
            {
                return this._definition;
            }
            set
            {
                if ((object.ReferenceEquals(this._definition, value) != true))
                {
                    this._definition = value;
                    this.OnPropertyChanged("Definition");
                }
            }
        }

        [DataMember(Name = "SIG", IsRequired = false)]
        public string Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                if ((object.ReferenceEquals(this._signature, value) != true))
                {
                    this._signature = value;
                    this.OnPropertyChanged("Signature");
                }
            }
        }

        [DataMember(Name = "V", IsRequired = false)]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((object.ReferenceEquals(this._value, value) != true))
                {
                    this._value = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }

    }

    [DataContract(Name = "SENS")]
    public class SENS : BindableBase
    {

        private string _definition;
        private string _pos;
        private ObservableCollection<SEN> _senses;

        [DataMember(Name = "DEF")]
        public string Definition
        {
            get
            {
                return this._definition;
            }
            set
            {
                if ((object.ReferenceEquals(this._definition, value) != true))
                {
                    this._definition = value;
                    this.OnPropertyChanged("Definition");
                }
            }
        }

        [DataMember(Name = "POS")]
        public string POS
        {
            get
            {
                return this._pos;
            }
            set
            {
                if ((object.ReferenceEquals(this._pos, value) != true))
                {
                    this._pos = value;
                    this.OnPropertyChanged("POS");
                }
            }
        }

        [DataMember(Name = "SEN")]
        public ObservableCollection<SEN> Senses
        {
            get
            {
                return this._senses;
            }
            set
            {
                if ((object.ReferenceEquals(this._senses, value) != true))
                {
                    this._senses = value;
                    this.OnPropertyChanged("Senses");
                }
            }
        }
    }

    [DataContract(Name = "SEN")]
    public class SEN : BindableBase
    {
        private string _definition;
        private int _rank;
        private ObservableCollection<SENT_P> _sentencePairs;
        private string _url;

        [DataMember(Name = "D")]
        public string Definition
        {
            get
            {
                return this._definition;
            }
            set
            {
                if ((object.ReferenceEquals(this._definition, value) != true))
                {
                    this._definition = value;
                    this.OnPropertyChanged("Definition");
                }
            }
        }

        [IgnoreDataMember]
        public int Rank
        {
            get
            {
                return this._rank;
            }
            set
            {
                if ((this._rank.Equals(value) != true))
                {
                    this._rank = value;
                    this.OnPropertyChanged("Rank");
                }
            }
        }

        [DataMember(Name = "STS")]
        public ObservableCollection<SENT_P> EmbeddedSentences
        {
            get
            {
                return this._sentencePairs;
            }
            set
            {
                if ((object.ReferenceEquals(this._sentencePairs, value) != true))
                {
                    this._sentencePairs = value;
                    this.OnPropertyChanged("STS");
                }
            }
        }

        [DataMember(Name = "URL")]
        public string URL
        {
            get
            {
                return this._url;
            }
            set
            {
                if ((object.ReferenceEquals(this._url, value) != true))
                {
                    this._url = value;
                    this.OnPropertyChanged("URL");
                }
            }
        }
    }

    [DataContract(Name = "COLLS")]
    public class COLLS : BindableBase
    {
        private ObservableCollection<LC> _lexCollocation;
        private string _relation;

        [DataMember(Name = "LC")]
        public ObservableCollection<LC> LexCollocation
        {
            get
            {
                return this._lexCollocation;
            }
            set
            {
                if ((object.ReferenceEquals(this._lexCollocation, value) != true))
                {
                    this._lexCollocation = value;
                    this.OnPropertyChanged("LC");
                }
            }
        }

        [DataMember(Name = "RELA")]
        public string Relation
        {
            get
            {
                return this._relation;
            }
            set
            {
                if ((object.ReferenceEquals(this._relation, value) != true))
                {
                    this._relation = value;
                    this.OnPropertyChanged("Relation");
                }
            }
        }
    }

    [DataContract(Name = "LC")]
    public class LC : BindableBase
    {
        private string _term1;
        private string _term2;

        [DataMember(Name = "T1")]
        public string Term1
        {
            get
            {
                return this._term1;
            }
            set
            {
                if ((object.ReferenceEquals(this._term1, value) != true))
                {
                    this._term1 = value;
                    this.OnPropertyChanged("Term1");
                }
            }
        }

        [DataMember(Name = "T2")]
        public string Term2
        {
            get
            {
                return this._term2;
            }
            set
            {
                if ((object.ReferenceEquals(this._term2, value) != true))
                {
                    this._term2 = value;
                    this.OnPropertyChanged("Term2");
                }
            }
        }
    }

    [DataContract(Name = "INF")]
    public class INF : BindableBase
    {
        private string _value;
        private string _category;

        [DataMember(Name = "IE")]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((object.ReferenceEquals(this._value, value) != true))
                {
                    this._value = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }

        [DataMember(Name = "T")]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                if ((object.ReferenceEquals(this._category, value) != true))
                {
                    this._category = value;
                    this.OnPropertyChanged("Category");
                }
            }
        }
    }

    [DataContract(Name = "MT")]
    public class MT : BindableBase
    {
        private string _from;
        private string _source;
        private string _target;
        private string _to;
        private int _wordAlignmentGroupCount;

        public string From
        {
            get
            {
                return this._from;
            }
            set
            {
                if ((object.ReferenceEquals(this._from, value) != true))
                {
                    this._from = value;
                    this.OnPropertyChanged("From");
                }
            }
        }

        [DataMember(Name = "S", IsRequired = true)]
        public string Source
        {
            get
            {
                return this._source;
            }
            set
            {
                if ((object.ReferenceEquals(this._source, value) != true))
                {
                    this._source = value;
                    this.OnPropertyChanged("Source");
                }
            }
        }

        [DataMember(Name = "T", IsRequired = true)]
        public string Target
        {
            get
            {
                return this._target;
            }
            set
            {
                if ((object.ReferenceEquals(this._target, value) != true))
                {
                    this._target = value;
                    this.OnPropertyChanged("Target");
                }
            }
        }

        public IEnumerable<WordAlignmentElement> SourceWordAlignmentDetail
        {
            get
            {
                return DictionaryExtension.ExtractWordAlignment(this.Source);
            }
        }

        public IEnumerable<WordAlignmentElement> TargetWordAlignmentDetail
        {
            get
            {
                return DictionaryExtension.ExtractWordAlignment(this.Target);
            }
        }

        public string To
        {
            get
            {
                return this._to;
            }
            set
            {
                if ((object.ReferenceEquals(this._to, value) != true))
                {
                    this._to = value;
                    this.OnPropertyChanged("To");
                }
            }
        }

        public int WordAlignmentGroupCount
        {
            get
            {
                return this._wordAlignmentGroupCount;
            }
            set
            {
                if ((this._wordAlignmentGroupCount.Equals(value) != true))
                {
                    this._wordAlignmentGroupCount = value;
                    this.OnPropertyChanged("WordAlignmentGroupCount");
                }
            }
        }
    }

    [DataContract(Name = "PRON")]
    public class PRON : BindableBase
    {

        private string _category;
        private string _value;

        [DataMember(Name = "L")]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                if ((object.ReferenceEquals(this._category, value) != true))
                {
                    this._category = value;
                    this.OnPropertyChanged("Category");
                }
            }
        }

        [DataMember(Name = "V")]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((object.ReferenceEquals(this._value, value) != true))
                {
                    this._value = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }

    [DataContract(Name = "SENT_P")]
    public class SENT_P : BindableBase
    {
        private DateTime _createDate;
        private int _id;
        private bool _oral;
        private int _rank;
        private int _read;
        private SENT _source;
        private SENT _target;
        private bool _tech;
        private bool _title;
        private int _wordAlignmentGroupCount;
        private string _wordAlignmentData;

        [IgnoreDataMember]
        public DateTime CreateDate
        {
            get
            {
                return this._createDate;
            }
            set
            {
                if ((this._createDate.Equals(value) != true))
                {
                    this._createDate = value;
                    this.OnPropertyChanged("CreateDate");
                }
            }
        }

        [IgnoreDataMember]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id.Equals(value) != true))
                {
                    this._id = value;
                    this.OnPropertyChanged("ID");
                }
            }
        }

        [IgnoreDataMember]
        public bool Oral
        {
            get
            {
                return this._oral;
            }
            set
            {
                if ((this._oral.Equals(value) != true))
                {
                    this._oral = value;
                    this.OnPropertyChanged("Oral");
                }
            }
        }

        [IgnoreDataMember]
        public int Rank
        {
            get
            {
                return this._rank;
            }
            set
            {
                if ((this._rank.Equals(value) != true))
                {
                    this._rank = value;
                    this.OnPropertyChanged("Rank");
                }
            }
        }

        [IgnoreDataMember]
        public int Read
        {
            get
            {
                return this._read;
            }
            set
            {
                if ((this._read.Equals(value) != true))
                {
                    this._read = value;
                    this.OnPropertyChanged("Read");
                }
            }
        }

        [DataMember(Name = "S")]
        public SENT Source
        {
            get
            {
                return this._source;
            }
            set
            {
                if ((object.ReferenceEquals(this._source, value) != true))
                {
                    this._source = value;
                    this.OnPropertyChanged("Source");
                }
            }
        }

        [DataMember(Name = "T")]
        public SENT Target
        {
            get
            {
                return this._target;
            }
            set
            {
                if ((object.ReferenceEquals(this._target, value) != true))
                {
                    this._target = value;
                    this.OnPropertyChanged("Target");
                }
            }
        }

        [IgnoreDataMember]
        public bool Tech
        {
            get
            {
                return this._tech;
            }
            set
            {
                if ((this._tech.Equals(value) != true))
                {
                    this._tech = value;
                    this.OnPropertyChanged("Tech");
                }
            }
        }

        [IgnoreDataMember]
        public bool Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if ((this._title.Equals(value) != true))
                {
                    this._title = value;
                    this.OnPropertyChanged("Title");
                }
            }
        }

        [IgnoreDataMember]
        public int WordAlignmentGroupCount
        {
            get
            {
                return this._wordAlignmentGroupCount;
            }
            set
            {
                if ((this._wordAlignmentGroupCount.Equals(value) != true))
                {
                    this._wordAlignmentGroupCount = value;
                    this.OnPropertyChanged("WordAlignmentGroupCount");
                }
            }
        }

        [IgnoreDataMember]
        public string WordAlignmentData
        {
            get
            {
                return this._wordAlignmentData;
            }
            set
            {
                if ((object.ReferenceEquals(this._wordAlignmentData, value) != true))
                {
                    this._wordAlignmentData = value;
                    this.OnPropertyChanged("WordAlignmentData");
                }
            }
        }
    }

    public class WordAlignmentElement
    {
        public int? Id { get; set; }
        public bool Highlight { get; set; }
        public string Text { get; set; }
    }

    [DataContract(Name = "SENT")]
    public class SENT : BindableBase
    {
        private string _additionalInfomation;
        private ObservableCollection<COLL> _collocations;
        private string _value;
        private ObservableCollection<string> _imes;
        private int _media;
        private string _signature;
        private ObservableCollection<string> _tags;
        private string _url;
        private ObservableCollection<string> _words;

        [IgnoreDataMember]
        public string AdditionalInfomation
        {
            get
            {
                return this._additionalInfomation;
            }
            set
            {
                if ((object.ReferenceEquals(this._additionalInfomation, value) != true))
                {
                    this._additionalInfomation = value;
                    this.OnPropertyChanged("AdditionalInfomation");
                }
            }
        }

        [IgnoreDataMember]
        public ObservableCollection<COLL> Collocations
        {
            get
            {
                return this._collocations;
            }
            set
            {
                if ((object.ReferenceEquals(this._collocations, value) != true))
                {
                    this._collocations = value;
                    this.OnPropertyChanged("Collocations");
                }
            }
        }

        [DataMember(Name = "D")]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((object.ReferenceEquals(this._value, value) != true))
                {
                    this._value = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }

        public IEnumerable<WordAlignmentElement> AlignmentDetail
        {
            get
            {
                return DictionaryExtension.ExtractWordAlignment(this.Value);
            }
        }

        [IgnoreDataMember]
        public ObservableCollection<string> IMEs
        {
            get
            {
                return this._imes;
            }
            set
            {
                if ((object.ReferenceEquals(this._imes, value) != true))
                {
                    this._imes = value;
                    this.OnPropertyChanged("IMEs");
                }
            }
        }

        [DataMember(Name = "M")]
        public int Media
        {
            get
            {
                return this._media;
            }
            set
            {
                if ((this._media.Equals(value) != true))
                {
                    this._media = value;
                    this.OnPropertyChanged("Media");
                }
            }
        }

        [DataMember(Name = "SIG")]
        public string Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                if ((object.ReferenceEquals(this._signature, value) != true))
                {
                    this._signature = value;
                    this.OnPropertyChanged("Signature");
                }
            }
        }

        [IgnoreDataMember]
        public ObservableCollection<string> Tags
        {
            get
            {
                return this._tags;
            }
            set
            {
                if ((object.ReferenceEquals(this._tags, value) != true))
                {
                    this._tags = value;
                    this.OnPropertyChanged("Tags");
                }
            }
        }

        [DataMember(Name = "URL")]
        public string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                if ((object.ReferenceEquals(this._url, value) != true))
                {
                    this._url = value;
                    this.OnPropertyChanged("Url");
                }
            }
        }

        [IgnoreDataMember]
        public ObservableCollection<string> Words
        {
            get
            {
                return this._words;
            }
            set
            {
                if ((object.ReferenceEquals(this._words, value) != true))
                {
                    this._words = value;
                    this.OnPropertyChanged("Words");
                }
            }
        }
    }

    [DataContract(Name = "COLL")]
    public class COLL : BindableBase
    {
        private int _position1;
        private int _position2;
        private string _relation;

        public int Position1
        {
            get
            {
                return this._position1;
            }
            set
            {
                if ((this._position1.Equals(value) != true))
                {
                    this._position1 = value;
                    this.OnPropertyChanged("Position1");
                }
            }
        }

        public int Position2
        {
            get
            {
                return this._position2;
            }
            set
            {
                if ((this._position2.Equals(value) != true))
                {
                    this._position2 = value;
                    this.OnPropertyChanged("Position2");
                }
            }
        }

        public string Relation
        {
            get
            {
                return this._relation;
            }
            set
            {
                if ((object.ReferenceEquals(this._relation, value) != true))
                {
                    this._relation = value;
                    this.OnPropertyChanged("Relation");
                }
            }
        }
    }

    [DataContract(Name = "SENTS")]
    public class SENTS : BindableBase
    {
        private int _count;
        private int _offset;
        private ObservableCollection<SENT_P> _pairs;
        private int _total;

        [DataMember(Name = "COUNT")]
        public int Count
        {
            get
            {
                return this._count;
            }
            set
            {
                if ((this._count.Equals(value) != true))
                {
                    this._count = value;
                    this.OnPropertyChanged("Count");
                }
            }
        }

        [DataMember(Name = "OFFSET")]
        public int Offset
        {
            get
            {
                return this._offset;
            }
            set
            {
                if ((this._offset.Equals(value) != true))
                {
                    this._offset = value;
                    this.OnPropertyChanged("Offset");
                }
            }
        }

        [DataMember(Name = "ST")]
        public ObservableCollection<SENT_P> Pairs
        {
            get
            {
                return this._pairs;
            }
            set
            {
                if ((object.ReferenceEquals(this._pairs, value) != true))
                {
                    this._pairs = value;
                    this.OnPropertyChanged("Pairs");
                }
            }
        }

        [DataMember(Name = "TOTAL")]
        public int Total
        {
            get
            {
                return this._total;
            }
            set
            {
                if ((this._total.Equals(value) != true))
                {
                    this._total = value;
                    this.OnPropertyChanged("Total");
                }
            }
        }
    }

    [DataContract(Name = "SUGG")]
    public class SUGG : BindableBase
    {
        private ObservableCollection<HW> _autoCompletion;
        private ObservableCollection<HW> _phonetic;
        private ObservableCollection<HW> _pinYin;
        private ObservableCollection<HW> _spelling;

        [DataMember(Name = "AC", IsRequired = false)]
        public ObservableCollection<HW> AutoCompletion
        {
            get
            {
                return this._autoCompletion;
            }
            set
            {
                if ((object.ReferenceEquals(this._autoCompletion, value) != true))
                {
                    this._autoCompletion = value;
                    this.OnPropertyChanged("AutoCompletion");
                }
            }
        }

        [DataMember(Name = "PH", IsRequired = false)]
        public ObservableCollection<HW> Phonetic
        {
            get
            {
                return this._phonetic;
            }
            set
            {
                if ((object.ReferenceEquals(this._phonetic, value) != true))
                {
                    this._phonetic = value;
                    this.OnPropertyChanged("Phonetic");
                }
            }
        }

        [DataMember(Name = "PY", IsRequired = false)]
        public ObservableCollection<HW> PinYin
        {
            get
            {
                return this._pinYin;
            }
            set
            {
                if ((object.ReferenceEquals(this._pinYin, value) != true))
                {
                    this._pinYin = value;
                    this.OnPropertyChanged("PinYin");
                }
            }
        }

        [DataMember(Name = "SP", IsRequired = false)]
        public ObservableCollection<HW> Spelling
        {
            get
            {
                return this._spelling;
            }
            set
            {
                if ((object.ReferenceEquals(this._spelling, value) != true))
                {
                    this._spelling = value;
                    this.OnPropertyChanged("Spelling");
                }
            }
        }
    }

    [DataContract(Name = "THES")]
    public class THES : BindableBase
    {
        private string[] _antonyms;
        private string _pos;
        private string[] _synonyms;

        [DataMember(Name = "A")]
        public string[] Antonyms
        {
            get
            {
                return this._antonyms;
            }
            set
            {
                if ((object.ReferenceEquals(this._antonyms, value) != true))
                {
                    this._antonyms = value;
                    this.OnPropertyChanged("Antonyms");
                }
            }
        }

        [DataMember(Name = "POS")]
        public string POS
        {
            get
            {
                return this._pos;
            }
            set
            {
                if ((object.ReferenceEquals(this._pos, value) != true))
                {
                    this._pos = value;
                    this.OnPropertyChanged("POS");
                }
            }
        }

        [DataMember(Name = "S")]
        public string[] Synonyms
        {
            get
            {
                return this._synonyms;
            }
            set
            {
                if ((object.ReferenceEquals(this._synonyms, value) != true))
                {
                    this._synonyms = value;
                    this.OnPropertyChanged("Synonyms");
                }
            }
        }
    }

    static public class DictionaryExtension
    {
        public static IEnumerable<WordAlignmentElement> ExtractWordAlignment(string source)
        {
            IList<WordAlignmentElement> elements = new List<WordAlignmentElement>();
            ExtractWordAlignmentInternal(source, ref elements);
            return elements;
        }

        //{3#税率$3}
        //{##*{2#最高$2}*$$}
        //{#*{2#top$2}*$}
        //{#*{2#Can$2} {1#you$1} do me a {3#favor$3}*$} 
        //{##*{1#你$1}{2#能$2}{3#帮忙$3}*$$}
        //Don%27t {7#mention$7} it. It%27s the {4#least$4} {1#I$1} {#*{5#can$5} {6#do$6}*$} {2#for$2} {#*a*$} {3#friend$3}. By the way{8#,$8} {#*{9#you$9} {10#can$10} do {11#me$11} a {12#favor$12}*$} in {13#return$13}.
        static readonly Regex WordAlignment
            = new Regex(@"\{(##\*([^*]+)\*\$\$|#\*([^*]+)\*\$|(\d+)#([^$]+)\$\d+)\}", RegexOptions.IgnoreCase);

        static void ExtractWordAlignmentInternal(string source, ref IList<WordAlignmentElement> items, bool highlight = false)
        {
            int i = 0;
            while (i < source.Length)
            {
                Match match = WordAlignment.Match(source, i);
                if (!match.Success)
                {
                    break;
                }
                if (match.Index != i)
                {
                    items.Add(new WordAlignmentElement()
                    {
                        Text = source.Substring(i, match.Index - i),
                        Highlight = highlight
                    });
                }
                if (match.Groups[4].Success && match.Groups[5].Success)
                {
                    items.Add(new WordAlignmentElement()
                    {
                        Text = match.Groups[5].Value,
                        Highlight = highlight,
                        Id = Int32.Parse(match.Groups[4].Value)
                    });
                }
                else if (match.Groups[2].Success)
                {
                    ExtractWordAlignmentInternal(match.Groups[2].Value, ref items, true);
                }
                else if (match.Groups[3].Success)
                {
                    ExtractWordAlignmentInternal(match.Groups[3].Value, ref items, true);
                }
                else
                {
                    throw new Exception();
                }

                i = match.Index + match.Length;
            }

            if (i < source.Length)
            {
                items.Add(new WordAlignmentElement()
                {
                    Text = source.Substring(i),
                    Highlight = highlight
                });
            }
        }
    }

    public enum PronunciationType
    {
        us,
        gb
    }
}