그래픽버퍼링 BufferedGraphics
- 많은 양의 그림 뿌릴때 렉 해결
- 가상의 그래픽 객체 만들어 그곳에 뿌린 후, 다 되면 화면에 표시

Allocate - 가상의 객체
Render - 화면표시
Dispose - 다 끝난후 리소스 해제


OptimizedDoubleBuffer - true이면 컨트롤은 화면에 직접 그려지지 않고 먼저 버퍼에 그려지므로 깜빡임을 줄일 수 있습니다. 
　　　　　　　　　　　　이 속성을 true로 설정하는 경우 AllPaintingInWmPaint도 true로 설정해야 합니다.


// 출처 : https://cw-wd.tistory.com/12
// https://learn.microsoft.com/ko-kr/dotnet/desktop/winforms/advanced/how-to-manually-render-buffered-graphics
