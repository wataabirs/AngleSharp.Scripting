namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Html;
    using Jint;
    using Jint.Runtime;
    using Jint.Native;
    using Jint.Native.Object;
    using System;

    partial class HTMLCommandElementInstance : HTMLElementInstance
    {
        readonly EngineInstance _engine;

        public HTMLCommandElementInstance(EngineInstance engine)
            : base(engine)
        {
            _engine = engine;
        }

        public static HTMLCommandElementInstance CreateHTMLCommandElementObject(EngineInstance engine)
        {
            var obj = new HTMLCommandElementInstance(engine);
            obj.Extensible = true;
            obj.Prototype = engine.Jint.Object.PrototypeObject;            
            return obj;
        }

        public override String Class
        {
            get { return "HTMLCommandElement"; }
        }

        public IHtmlCommandElement RefHTMLCommandElement
        {
            get;
            set;
        }
    }
}