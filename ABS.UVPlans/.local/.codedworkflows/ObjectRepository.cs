using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ABS.UVPlans.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Browser
        {
            static string _reference = "UrhlpJTAA0mM_0uS1fnqrw/RlMxTPfVZUqXuq2H70dB8A";
            public static _Implementation.___Browser.__Any_UV_Page Any_UV_Page { get; private set; } = new _Implementation.___Browser.__Any_UV_Page();
            public static _Implementation.___Browser.__Browser Browser { get; private set; } = new _Implementation.___Browser.__Browser();
            public static _Implementation.___Browser.__Chrome_Love__Bible_Reading_Plans___Daily_Devo Chrome_Love__Bible_Reading_Plans___Daily_Devo { get; private set; } = new _Implementation.___Browser.__Chrome_Love__Bible_Reading_Plans___Daily_Devo();
            public static _Implementation.___Browser.__YouVersion_Search YouVersion_Search { get; private set; } = new _Implementation.___Browser.__YouVersion_Search();
        }
    }
}

namespace ABS.UVPlans._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___Browser._Any_UV_Page
    {
        public class __LanguageSelector : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LanguageSelector(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/VmIMgpIBsE2acIrrlCBj6g",
                    DisplayName = "LanguageSelector",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Browser
    {
        public class __Any_UV_Page : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Any_UV_Page()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/81tL_Bb93UuQ_sV7fJ7xFQ",
                    DisplayName = "Any UV Page",
                    Screen = this
                };
                LanguageSelector = new _Implementation.___Browser._Any_UV_Page.__LanguageSelector(this, null);
            }

            public _Implementation.___Browser._Any_UV_Page.__LanguageSelector LanguageSelector { get; private set; }
        }
    }

    namespace ___Browser._Browser
    {
        public class __ProseArea : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ProseArea(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/xa8b__cE30K4t0fd16WJEQ",
                    DisplayName = "ProseArea",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Browser._Browser
    {
        public class __SampleDay1 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __SampleDay1(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/iMHhF6snT0WcOsSNP7C8jQ",
                    DisplayName = "SampleDay1",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Browser._Browser
    {
        public class __SearchResultArea : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __SearchResultArea(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/9DblU8yl0UqJfNpehoA8WA",
                    DisplayName = "SearchResultArea",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Browser
    {
        public class __Browser : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Browser()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/7wRqhOXXSEqyXAWnHr_BXA",
                    DisplayName = "Browser",
                    Screen = this
                };
                ProseArea = new _Implementation.___Browser._Browser.__ProseArea(this, null);
                SampleDay1 = new _Implementation.___Browser._Browser.__SampleDay1(this, null);
                SearchResultArea = new _Implementation.___Browser._Browser.__SearchResultArea(this, null);
            }

            public _Implementation.___Browser._Browser.__ProseArea ProseArea { get; private set; }
            public _Implementation.___Browser._Browser.__SampleDay1 SampleDay1 { get; private set; }
            public _Implementation.___Browser._Browser.__SearchResultArea SearchResultArea { get; private set; }
        }
    }

    namespace ___Browser
    {
        public class __Chrome_Love__Bible_Reading_Plans___Daily_Devo : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Love__Bible_Reading_Plans___Daily_Devo()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/sZEXaElZ8kqP_29mqxMyHw",
                    DisplayName = "Chrome Love  Bible Reading Plans & Daily Devo",
                    Screen = this
                };
            }
        }
    }

    namespace ___Browser
    {
        public class __YouVersion_Search : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __YouVersion_Search()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "UrhlpJTAA0mM_0uS1fnqrw/XDwRkDqE2UGqFYHpLvuZ9g",
                    DisplayName = "YouVersion Search",
                    Screen = this
                };
            }
        }
    }
}