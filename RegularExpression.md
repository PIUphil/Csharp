|요소|설명|
|---|:---|
|.|\n(new line) 문자를 제외한 모든 문자|
|\d|	10진수|
|\D|	10진수가 아닌 문자|
|\s|	공백문자|
|\S|	공백문자가 아닌 문자|
|\w|	알파벳이나 한글 및 숫자 같은 문자|
|\W|	문자가 아닌 것|
|^|	문자열이나 줄의 시작|
|\A|	일치하는 부분이 문자열의 시작에 있어야 함|
|$|	문자열이나 줄의 끝|
|\z|	일치하는 부분이 문자열의 끝에 있어야 함|
|pipe|	파이프로 구분된 값들 중 일치하는 하나를 찾음. This/That/What 는 This나 That, What중 하나가 있을 경우 일치하게 됨|
|[abc]|	대괄호 안의 문자 중 일치하는 하나를 찾음. [QwEr]은 Q, w, E, r 중 하나가 있을 경우 일치하게 됨|
|[^abc]|	^기호 뒤에 오는 문자가 아닌 문자를 찾음. [^QwEr]은 a나b는 찾지만 Q나 w는 찾지 못함|
|[a-z]|	지정된 문자 범위 내에 있는 문자를 찾음. [A-C]는 A, B, C를 찾음|
|( )|	정규표현식 내부의 또 다른 부분 정규표현식을 나타냄|
|?|	?앞의 식이 있거나 없을 수 있음|
|*|	*앞의 식이 0번 이상 올 수 있음|
|+|	*앞의 식이 1번 이상 올 수 있음|
|{n}|	{n}앞의 식이 n개인 경우를 찾음|
|{n,}|	{n}앞의 식이 최소한 n개인 경우를 찾음|
|{n, m}|	{n, m}앞의 식이 최소 n개에서 최대 m개인 경우를 찾음|

|값|정규표현식|설명|
|---|---|:---|
|숫자|	^\d+$|	문자가 아닌 숫자|
|단순비밀번호|	^\w{6,8}$|	6~8자리까지의 문자(숫자 포함) 비밀 번호를 검사함|
|신용카드번호|	^\d{4}-?\d{4}-?\d{4}-?\d{4}$|	4자리 숫자가 4번 반복. 하이픈(-)은 없을수도 있음|
|주민등록번호|	^\d{6}-?\d{7}$|	6자리 숫자와 7자리 숫자의 가운데에 하이픈(-)이 들어감|
|이메일|	^[\w-]+@([\w-]+\.)+[\w-]+$|	이메일 주소를 검사함|
|URL|	^https?://([\w-]+\.)+[\w-]+(/[\w-./?&%=]*)?$|	URL을 검사함|
  
  
출처 : http://taeyo.net/columns/View.aspx?SEQ=390&PSEQ=31&IDX=3