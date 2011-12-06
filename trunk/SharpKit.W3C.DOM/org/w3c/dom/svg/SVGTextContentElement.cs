//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.svg
{

using SharpKit.JavaScript;
using DOMException = org.w3c.dom.DOMException;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SVGTextContentElement : SVGElement
{

	// SVGTextContentElement
	public static short LENGTHADJUST_UNKNOWN = 0;
	public static short LENGTHADJUST_SPACING = 1;
	public static short LENGTHADJUST_SPACINGANDGLYPHS = 2;
	public SVGAnimatedLength textLength {get;private set;}
	public SVGAnimatedEnumeration lengthAdjust {get;private set;}
	public int numberOfChars {get;private set;}
	public float computedTextLength {get;private set;}
	public float getSubStringLength(int charnum, int nchars) { return default(float); }
	public SVGPoint getStartPositionOfChar(int charnum) { return default(SVGPoint); }
	public SVGPoint getEndPositionOfChar(int charnum) { return default(SVGPoint); }
	public SVGRect getExtentOfChar(int charnum) { return default(SVGRect); }
	public float getRotationOfChar(int charnum) { return default(float); }
	public int getCharNumAtPosition(SVGPoint point) { return default(int); }
	public void selectSubString(int charnum, int nchars) {}
}

}