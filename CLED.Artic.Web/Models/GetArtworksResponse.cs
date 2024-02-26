namespace CLED.Artic.Web.Models;

using System.Text.Json.Serialization;

public class GetArtworksResponse
{
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; set; }

    [JsonPropertyName("data")]
    public Artwork[] Data { get; set; }

    [JsonPropertyName("info")]
    public Info Info { get; set; }

    [JsonPropertyName("config")]
    public Config Config { get; set; }
}

public class Pagination
{
    public int total { get; set; }
    public int limit { get; set; }
    public int offset { get; set; }
    public int total_pages { get; set; }
    public int current_page { get; set; }
    public string next_url { get; set; }
}

public class Info
{
    public string license_text { get; set; }
    public string[] license_links { get; set; }
    public string version { get; set; }
}

public class Config
{
    public string iiif_url { get; set; }
    public string website_url { get; set; }
}

public class Artwork
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    public string api_model { get; set; }
    public string api_link { get; set; }
    public bool is_boosted { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    public object alt_titles { get; set; }
    public Thumbnail thumbnail { get; set; }
    public string main_reference_number { get; set; }
    public bool has_not_been_viewed_much { get; set; }
    public object boost_rank { get; set; }
    public int date_start { get; set; }
    public int date_end { get; set; }
    public string date_display { get; set; }
    public string date_qualifier_title { get; set; }
    public object date_qualifier_id { get; set; }
    public string artist_display { get; set; }
    public string place_of_origin { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("short_description")]
    public string ShortDescription { get; set; }
    public string dimensions { get; set; }
    public Dimensions_Detail[] dimensions_detail { get; set; }
    public string medium_display { get; set; }
    public string inscriptions { get; set; }
    public string credit_line { get; set; }
    public string catalogue_display { get; set; }
    public string publication_history { get; set; }
    public string exhibition_history { get; set; }
    public string provenance_text { get; set; }
    public object edition { get; set; }
    public string publishing_verification_level { get; set; }
    public int internal_department_id { get; set; }
    public int? fiscal_year { get; set; }
    public object fiscal_year_deaccession { get; set; }
    public bool is_public_domain { get; set; }
    public bool is_zoomable { get; set; }
    public int max_zoom_window_size { get; set; }
    public string copyright_notice { get; set; }
    public bool has_multimedia_resources { get; set; }
    public bool has_educational_resources { get; set; }
    public bool has_advanced_imaging { get; set; }
    public float colorfulness { get; set; }
    public Color color { get; set; }
    public float? latitude { get; set; }
    public float? longitude { get; set; }
    public string latlon { get; set; }
    public bool is_on_view { get; set; }
    public string on_loan_display { get; set; }
    public object gallery_title { get; set; }
    public object gallery_id { get; set; }
    public object nomisma_id { get; set; }
    public string artwork_type_title { get; set; }
    public int artwork_type_id { get; set; }
    public string department_title { get; set; }
    public string department_id { get; set; }
    public int? artist_id { get; set; }
    public string artist_title { get; set; }
    public object[] alt_artist_ids { get; set; }
    public int?[] artist_ids { get; set; }
    public string[] artist_titles { get; set; }
    public string[] category_ids { get; set; }
    public string[] category_titles { get; set; }
    public string[] term_titles { get; set; }
    public string style_id { get; set; }
    public string style_title { get; set; }
    public object[] alt_style_ids { get; set; }
    public string[] style_ids { get; set; }
    public string[] style_titles { get; set; }
    public string classification_id { get; set; }
    public string classification_title { get; set; }
    public string[] alt_classification_ids { get; set; }
    public string[] classification_ids { get; set; }
    public string[] classification_titles { get; set; }
    public string subject_id { get; set; }
    public string[] alt_subject_ids { get; set; }
    public string[] subject_ids { get; set; }
    public string[] subject_titles { get; set; }
    public string material_id { get; set; }
    public string[] alt_material_ids { get; set; }
    public string[] material_ids { get; set; }
    public string[] material_titles { get; set; }
    public string technique_id { get; set; }
    public string[] alt_technique_ids { get; set; }
    public string[] technique_ids { get; set; }
    public string[] technique_titles { get; set; }
    public string[] theme_titles { get; set; }
    [JsonPropertyName("image_id")]
    public string ImageId { get; set; }
    public string[] alt_image_ids { get; set; }
    public string[] document_ids { get; set; }
    public string[] sound_ids { get; set; }
    public object[] video_ids { get; set; }
    public object[] text_ids { get; set; }
    public object[] section_ids { get; set; }
    public object[] section_titles { get; set; }
    public object[] site_ids { get; set; }
    public Suggest_Autocomplete_All[] suggest_autocomplete_all { get; set; }
    public DateTime source_updated_at { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime timestamp { get; set; }
    public string suggest_autocomplete_boosted { get; set; }
}

public class Thumbnail
{
    public string lqip { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string alt_text { get; set; }
}

public class Color
{
    public int h { get; set; }
    public int l { get; set; }
    public int s { get; set; }
    public float percentage { get; set; }
    public int population { get; set; }
}

public class Dimensions_Detail
{
    public int? depth { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public object diameter { get; set; }
    public string clarification { get; set; }
}

public class Suggest_Autocomplete_All
{
    public string[] input { get; set; }
    public Contexts contexts { get; set; }
    public int weight { get; set; }
}

public class Contexts
{
    public string[] groupings { get; set; }
}
