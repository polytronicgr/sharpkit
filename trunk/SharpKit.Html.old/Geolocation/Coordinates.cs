//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class Coordinates
{

	// Coordinates
	public double latitude {get; private set; }
	public double longitude {get; private set; }
	public double altitude {get; private set; }
	public double accuracy {get; private set; }
	public double altitudeAccuracy {get; private set; }
	public double heading {get; private set; }
	public double speed {get; private set; }
}

}