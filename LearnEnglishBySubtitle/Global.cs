﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Studyzy.LearnEnglishBySubtitle.EngDict;

namespace Studyzy.LearnEnglishBySubtitle
{
    public static class Global
    {
        public static DictionaryService DictionaryService { get; set; }
        public static string PronunciationType { get; set; }
        public static bool PronunciationDownload { get; set; }
        public static  bool RemoveChinese { get; set; }
        public static bool ShortMean { get; set; }
    }
}
