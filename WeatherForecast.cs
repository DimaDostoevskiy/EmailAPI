using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EmailAPI;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    [NotMapped]
    public string[] SummarysList
    {
        get => _summarys.Split(',').ToArray<string>();
        set => _summarys = string.Join(",", value); 
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [JsonIgnore]
    private string _summarys { get; set; } = string.Empty;


}
