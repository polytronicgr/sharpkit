using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.css
{

    using MediaList = org.w3c.dom.stylesheets.MediaList;

    public interface CSSMediaRule : CSSRule
    {
        // CSSMediaRule
        MediaList media {get;set;}
        CSSRule[] cssRules {get;}
        int insertRule(string rule, int index);
        void deleteRule(int index);
    }

}