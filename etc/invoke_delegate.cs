myFormControl.Invoke(myformControl.myDelegate) 

하나의 Form을 다른 thread에서 접근하게 될 경우에 기존의 Form과 충돌이 날 수 있다. 
이 때 invoke 를 사용하여 실행하려고 하는 메소드의 대리자(delegate)를 실행시키면 된다.

멀티스레드 환경에서 데이터 보호를 위해 Invoke를 써야 합니다.

// 출처 : https://cartiertk.tistory.com/67


// 출처 : https://blog.naver.com/PostView.nhn?isHttpsRedirect=true&blogId=aorigin&logNo=100140073826


/*
Delegates are similar to function pointers in C or C++ languages. 
대리자는 C 또는 C++ 언어의 함수 포인터와 비슷합니다. 
Delegates encapsulate a reference to a method inside a delegate object. 
대리자는 대리자 개체 내의 메서드에 대한 참조를 캡슐화합니다.
The delegate object can then be passed to code that calls the referenced method, 
and the method to be invoked can be unknown at compile time. 
그런 다음 참조된 메서드를 호출하는 코드에 대리자 개체를 전달할 수 있으며 컴파일 시 호출할 메서드를 알 수 없습니다.
Unlike function pointers in C or C++, delegates are object-oriented, type-safe, and more secure.
C 또는 C++의 함수 포인터와 달리 대리자는 개체 지향적이고 형식이 안전하며 더 안전합니다.

The Invoke method searches up the control's parent chain until it finds a control or form that has a window handle
if the current control's underlying window handle does not exist yet.
메서드는 Invoke 현재 컨트롤의 기본 창 핸들이 아직 없는 경우 창 핸들이 있는 컨트롤 또는 폼을 검색할 때까지 컨트롤의 부모 체인을 검색합니다.
If no appropriate handle can be found, the Invoke method will throw an exception.
적절한 핸들을 찾을 수 없는 경우 메서드는 Invoke 예외를 throw합니다.
Exceptions that are raised during the call will be propagated back to the caller.
호출 중에 발생하는 예외는 호출자에게 다시 전파됩니다.
*/

// https://learn.microsoft.com/ko-kr/dotnet/api/system.windows.forms.control.invoke?view=windowsdesktop-7.0
