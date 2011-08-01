using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.svg
{

    public interface SVGFilterElement : SVGElement, SVGURIReference, SVGLangSpace, SVGExternalResourcesRequired, SVGStylable, SVGUnitTypes
    {
        // SVGFilterElement
        SVGAnimatedEnumeration filterUnits {get;}
        SVGAnimatedEnumeration primitiveUnits {get;}
        SVGAnimatedLength x {get;}
        SVGAnimatedLength y {get;}
        SVGAnimatedLength width {get;}
        SVGAnimatedLength height {get;}
        SVGAnimatedInteger filterResX {get;}
        SVGAnimatedInteger filterResY {get;}
        void setFilterRes(int filterResX, int filterResY);
    }

}
