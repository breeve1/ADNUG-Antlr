grammar Dsl;

options {
  language=CSharp3;
  output=AST;
  ASTLabelType=CommonTree;
  TokenLabelType=CommonToken;
}


public program
	: whenStatement* EOF
	;

whenStatement
	: NEWLINE* WHEN booleanExpression NEWLINE+ booleanStatements+
	;

booleanStatements
	: STAR booleanExpression (PLUS booleanExpression)* NEWLINE+
	;

booleanExpression
	: VARIABLE IS literal
	| VARIABLE IS NOT literal
	| VARIABLE GREATER THAN literal
	| VARIABLE GREATER THAN EQUAL literal
	| VARIABLE LESS THAN literal
	| VARIABLE LESS THAN EQUAL literal
	;
	

literal
	: STRING_LITERAL
	| INT
	;
	
	
APOSTRAPHE : '\'';	
VARIABLE: '[' LETTER+ ']';
STAR: '*';
PLUS: '+';
EQUAL: 'equal';
GREATER: 'greater';
LESS: 'less';
THAN: 'than';
NOT: 'not';
IS: 'is';
WHEN: 'when';
NEWLINE: ('\n'|'\r');
STRING_LITERAL: APOSTRAPHE ~(APOSTRAPHE)* APOSTRAPHE;
INT : DIGIT+;
fragment LETTER :('a'..'z' | 'A'..'Z');
fragment DIGIT: '0'..'9';
WS :  (' '|'\t')+ {$channel = HIDDEN;};
COMMENT : '/*' .* '*/' {$channel = HIDDEN;};
LINE_COMMENT_SLASH : '//' ~NEWLINE* {$channel = HIDDEN;};


