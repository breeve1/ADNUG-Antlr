grammar Dsl;

options {
  language=CSharp3;
  output=AST;
  ASTLabelType=CommonTree;
  TokenLabelType=CommonToken;
 }

tokens {
	PROGRAM;
	LESS_THAN;
	LESS_THAN_EQUAL;
	NOT_EQUAL;
	GREATER_THAN;
	GREATER_THAN_EQUAL;
	WHEN_STATEMENT;
	AND_STATEMENT;
	OR_STATEMENT;
}

@lexer::namespace {ParserTree.AntlrCode}
@parser::namespace {ParserTree.AntlrCode}


public program
	: whenStatement* EOF -> ^(PROGRAM whenStatement*)
	;

whenStatement
	:  NEWLINE* WHEN booleanExpression NEWLINE+ booleanStatements+ -> ^(WHEN_STATEMENT booleanExpression booleanStatements+)
	;

booleanStatements
	: STAR booleanExpression (PLUS booleanExpression)* NEWLINE+ -> ^(AND_STATEMENT booleanExpression ^(OR_STATEMENT booleanExpression)*)
	;

booleanExpression
	: variable IS literal -> ^(EQUAL variable literal)
	| variable IS NOT literal -> ^(NOT_EQUAL variable literal)
	| variable GREATER THAN literal -> ^(GREATER_THAN variable literal)
	| variable GREATER THAN EQUAL literal -> ^(GREATER_THAN_EQUAL variable literal)
	| variable LESS THAN literal -> ^(LESS_THAN variable literal)
	| variable LESS THAN EQUAL literal -> ^(LESS_THAN_EQUAL variable literal)
	;
	
variable
	: '['!  VARIABLE^ ']'!
	;

literal
	: STRING_LITERAL
	| INT
	;
	
	
APOSTRAPHE : '\'';	
STAR: '*';
PLUS: '+';
EQUAL: 'equal';
GREATER: 'greater';
LESS: 'less';
THAN: 'than';
NOT: 'not';
IS: 'is';
WHEN: 'when';
VARIABLE: LETTER+;
NEWLINE: ('\n'|'\r');
STRING_LITERAL: APOSTRAPHE ~(APOSTRAPHE)* APOSTRAPHE;
INT : DIGIT+;
fragment LETTER :('a'..'z' | 'A'..'Z');
fragment DIGIT: '0'..'9';
WS :  (' '|'\t')+ {$channel = Hidden;};
COMMENT : '/*' .* '*/' {$channel = Hidden;};
LINE_COMMENT_SLASH : '//' ~NEWLINE* {$channel = Hidden;};


