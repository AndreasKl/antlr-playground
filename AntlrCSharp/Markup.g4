grammar Markup;

markup  : (element | text)+ ;
element : bold | italic | color ;

text      : TEXT ;
bold      : '[b]' markup '[/b]' ;
italic    : '[i]' markup '[/i]' ;
color     : '[color=' colorcode ']' markup '[/color]' ;
colorcode : COLORCODE ;

COLORCODE : HEX HEX HEX HEX HEX HEX ;
HEX       : [0-9a-fA-F] ;
TEXT      : ~('[' | ']')+ ;
WS        : [ \t\r\n]+ -> skip ;
