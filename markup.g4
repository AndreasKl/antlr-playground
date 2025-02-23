grammar Markup;

// Parser rules
markup  : (element | TEXT)+ ;
element : bold | italic | color ;

bold    : '[b]' markup? '[/b]' ;
italic  : '[i]' markup? '[/i]' ;
color   : '[color=' HEX ']' markup? '[/color]' ;

// Lexer rules
HEX     : [0-9a-fA-F]{6} ;
TEXT    : ~[\[\]]+ ;
WS      : [ \t\r\n]+ -> skip ;
