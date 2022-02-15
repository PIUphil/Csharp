||||
:---:|:---|:---
**insert**| INSERT INTO accounts_table (name, phone) VALUES ('{0}', '{1}');|textBoxName.Text, textBoxPhone.Text
**update**| UPDATE accounts_table SET name = '{1}', phone = '{2}' WHERE id={0};|index, textBoxName.Text, textBoxPhone.Text
**delete**| DELETE FROM accounts_table WHERE id={0};|index
**select**| SELECT * FROM accounts_table
  
||
|---|
|INSERT INTO 테이블이름 [column1, column2, ...] VALUES (value1, value2, ...);|
|UPDATE 테이블이름 SET column1 = value1 [, column2 = value2 ...] [WHERE 조건];|
|DELETE FROM 테이블이름 [WHERE 조건];|
|SELECT * FROM 테이블이름;|
  
```  
SELECT * FROM [테이블명];						데이터 조회
CREATE TABLE [생성할 테이블명] AS (SELECT * FROM [기존 테이블명]);	조회된 데이터로 테이블 만들기
SELECT [열1, 열2, ...] FROM [테이블명] ORDER BY [열1, 열2, ...] ASC LIMIT 5;	검색결과 일부 출력 후 정렬하기 (내림차순 DESC)
```  

  
-**reindexing**-

```
ALTER TABLE [테이블명] AUTO_INCREMENT=1;  
SET @COUNT=0;  
UPDATE [테이블명] SET [AUTO_INCREMENT 열이름]=@COUNT:=@COUNT+1;  
```
```
// ALTER TABLE table2 AUTO_INCREMENT=1;  
// SET @COUNT=0;  
// UPDATE table2 SET id=@COUNT:=@COUNT+1;  
```
-- SafeMode해제 =>  Edit - Preferences - SQL Editor - SafeUpdates [체크해제]
   
 
https://opentutorials.org/course/3161  
https://365kim.tistory.com/102
