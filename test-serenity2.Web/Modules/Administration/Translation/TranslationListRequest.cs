﻿namespace test_serenity2.Administration;

public class TranslationListRequest : ListRequest
{
    public string SourceLanguageID { get; set; }
    public string TargetLanguageID { get; set; }
}