grammar Markup;

markup  : (element | text)+ ;
element : bold | italic | color ;

text      : TEXT ;
bold      : '[b]' markup '[/b]'                       | unmatched_bold ;
italic    : '[i]' markup '[/i]'                       | unmatched_italic ;
color     : '[color=' colorcode ']' markup '[/color]' | unmatched_color ;
colorcode : COLORCODE ;

unmatched_bold   : '[b]' markup* EOF { NotifyErrorListeners("Missing closing [/b] tag"); } ;
unmatched_italic : '[i]' markup* EOF { NotifyErrorListeners("Missing closing [/i] tag"); } ;
unmatched_color  : '[color=' colorcode ']' markup* EOF { NotifyErrorListeners("Missing closing [/color] tag"); } ;

COLORCODE : HEX HEX HEX HEX HEX HEX ;
HEX       : [0-9a-fA-F] ;
TEXT      : ~('[' | ']')+ ;
WS        : [ \t\r\n]+ -> skip ;
