grammar Markup;

options {
  language = CSharp;
}

@header {
  namespace AntlrCSharp.TextEnhancing;
}


markup  : (element | text)+ ;
element : bold | italic | color | mail | underline;

text      : TEXT ;
bold      : '[b]' markup '[/b]' ;
italic    : '[i]' markup '[/i]' ;
underline : '[u]' markup '[/u]' ;
mail      : '[mailto]' markup '[/mailto]' ;
color     : '[color=' colorcode ']' markup '[/color]' ;
colorcode : COLORCODE ;

COLORCODE : HEX HEX HEX HEX HEX HEX ;
HEX       : [0-9a-fA-F] ;
TEXT      : ~('[' | ']')+ ;
WS        : [ \t\r\n]+ -> skip ;
