grammar Markup;

markup  : (element | TEXT)+ ;
element : bold | italic | color ;

bold      : '[b]' markup? '[/b]' ;
italic    : '[i]' markup? '[/i]' ;
color     : '[color=' COLORCODE ']' markup? '[/color]' ;


// Lexer rules
COLORCODE : HEX HEX HEX HEX HEX HEX ;
HEX       : [0-9a-fA-F] ;
TEXT      : ~('[' | ']')+ ;
WS        : [ \t\r\n]+ -> skip ;
