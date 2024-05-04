# Các Quy Tắc Và Kiến Thức Liên Quan Đến Cơ Sở Dữ Liệu Phân Tán

## 3 Quy Tắc Phân Mảnh

- **Tính đầy đủ**: Dữ liệu nằm ít nhất ở 1 mảnh.
- **Tính tái thiết được**: Thỏa tính đầy đủ thì thỏa tính tái thiết. Định nghĩa một phép toán để tái thiết dữ liệu: ngang là phép hội, dọc là phép kết tự nhiên trên khóa chính.
- **Tính tách biệt**: Dữ liệu chỉ nằm duy nhất ở 1 mảnh (tính chất này có thể vi phạm, các bảng nhân bản có thể vi phạm tính chất này).

## 4 Tính Chất Của Giao Tác

- **Tính nguyên tử**: Một tập lệnh được xem như một lệnh, hoặc thực hiện được hết hoặc không lệnh nào được thực hiện.
- **Tính nhất quán**: Sau khi xử lý, dữ liệu chuyển từ trạng thái nhất quán này sang trạng thái nhất quán khác.
- **Tính bền vững**: Sau khi ủy thác, dữ liệu không bị xóa khỏi cơ sở dữ liệu -> để khôi phục dữ liệu.
- **Tính biệt lập**: Khi một giao tác đang thực thi, không lộ ra các kết quả của nó cho những giao tác khác đang cùng hoạt động trước khi nó ủy thác.

## Các Mức Độ Cô Lập

- `read uncommitted`
- `read committed`
- `repeatable read`
- `serializable`
- `snapshot`

## Những Cách Tối Ưu Hóa Truy Vấn

- **Chọn chiếu trước, kết sau.**
- **Khử phép kết nếu được.**

Ví dụ:

- Khi chưa khử kết: Lấy ra tên sinh viên và tên lớp của sinh viên thuộc lớp CN04: `SELECT SINHVIEN.TEN, LOP.TENLOP FROM SINHVIEN JOIN LOP ON SINHVIEN.MALOP=LOP.MALOP WHERE LOP.MALOP = 'CN04'`
- Khi đã khử kết: Dùng truy vấn lồng: `SELECT TEN, (SELECT TENLOP FROM LOP WHERE MALOP='CN04') AS tenlop FROM SINHVIEN WHERE MALOP = 'CN04'`

### Một số mẹo khác:

- Nếu điều kiện xuất hiện nhiều lần, hãy sử dụng phép biến đổi tương đương.
- MĐ `AND`: Điều kiện có xác suất sai cao nên đặt ở đầu.
- MĐ `OR`: Điều kiện có xác suất đúng cao nên đặt ở đầu.
- Field tham gia trong mệnh đề quan hệ nên được sắp xếp thứ tự trước và thứ tự này phải được sử dụng trong mệnh đề truy vấn với mệnh đề `WITH (Index_Tên_Index)`.

## Stored Procedure Trong Suốt

SP là trong suốt khi nó được thực thi ở bất kỳ server nào đều cho ra kết quả giống nhau.

Điều kiện để viết SP trong suốt:

- Link giống nhau, tên database giống nhau.

## Remote Login

### Link Server

- **Mục đích**: Cho phép truy cập dữ liệu từ server này sang server khác.
- **Cách tạo**: Ví dụ tạo link ở server 1 để truy xuất dữ liệu ở server 2:

  - Đứng ở server 2, tạo login `HOTROKETNOI`.
  - Đứng ở server 1, tạo link.

- **Số lượng link**: `n(n-1)`, trong đó `n` là số server phân mảnh.
- **Số tên link**: `n-1`.

- **Cú pháp sử dụng**: `TENLINK.TENDATABASE.DBO.TENBANGCANTRUYXUAT`

## Các Loại Phân Mảnh: Ngang, Dọc, Hỗn Hợp

- **Phân mảnh ngang nguyên thủy**: Phân mảnh của một quan hệ dựa trên một vị từ được định nghĩa trên quan hệ đó.
  - Ví dụ: `TENKHOA='VT'`
- **Phân mảnh ngang dẫn xuất**: Phân mảng của một quan hệ trên vị từ được định nghĩa trên quan hệ khác.
  - Ví dụ: `Sinhvien.MALOP=Lop.MALOP`
- **Phân mảnh dọc**: Phân mảnh dựa trên khóa chính của một quan hệ (phải có khóa chính để đảm bảo tính tái thiết).
- **Phân mảnh hỗn hợp**: Kết hợp giữa phân mảnh ngang và dọc.

## Điều Kiện Để Phân Tán

- Phải có dịch vụ `SQL Server Agent`.

## Giao Tác Là Gì?

Giao tác là một dãy các thao tác đọc ghi trên cơ sở dữ liệu cùng với các phép toán cần thiết: thêm, xóa, sửa có tính nhất quán để giải quyết các tình huống khi dữ liệu bị mất tính nhất quán khi có nhiều truy xuất đồng thời.

- Để viết giao tác, cần phải bật dịch vụ `MSDTC` (Microsoft Distributed Transaction Coordinator).

## Quá Trình Phân Tán

- **Định nghĩa publication**: Là một container chứa các article (table, view, stored procedure, udf). Trong đó phải chỉ rõ các server:
  - Publisher chứa bản cơ sở dữ liệu gốc.
  - Distributor điều phối phân tán dữ liệu.
- **Định nghĩa subscription**: Là một container nhận publication. Trong đó phải chỉ rõ server subscriber chứa cơ sở dữ liệu sau khi phân tán.

- **Trong một server**: Có nhiều user, tên user có thể trùng nhau.
- **Trong một database**: Có nhiều user, tên không được trùng nhau.
- **Trong một server**: Có nhiều login, tên login không được trùng nhau.

- **Lệnh `select...union`**: Dùng để lấy dữ liệu từ các server phân mảnh về.
  - Ví dụ: `SELECT MALOP, TENLOP FROM DBO.LOP UNION SELECT MALOP, TENLOP FROM LINK1.QLDSV.DBO.LOP`

## Một Số Lưu Ý Khác

- **Trong lược đồ phân mảnh**: Số lượng DB trong publication và số lượng DB trong subscriber như thế nào? Số lượng DB trong publication nhiều hơn vì trong publication chứa nhiều subscription.
- **Trong DB**: Cái nào là nhân bản, cái nào là phân hoạch? (Mở cây dẫn xuất ra xem, cái nào không có trong cây dẫn xuất là nhân bản, cái đầu tiên là phân mảnh ngang nguyên thủy).
- **Nếu đã phân tán xong cơ sở dữ liệu**: Muốn thay đổi cấu trúc cột của server gốc thì làm như thế nào? Có thể thay đổi bằng cách viết SP dùng lệnh `ALTER TABLE` ở server gốc, sau đó đồng bộ xuống các server phân mảnh.
- **Dữ liệu sau khi nhập form**: Sẽ được đẩy về publisher sau đó đồng bộ xuống các subscriber.
- **Trong các table**: Cái nào mang tính đầy đủ, cái nào vi phạm tính tách biệt? Các table nhân bản thì vi phạm tính tách biệt, tất cả các table còn lại thì mang tính đầy đủ.

## Giao Tác Phân Tán Và Giao Tác Thường

- **Giống nhau**: Cả hai đều có 4 tính chất của giao tác.
- **Khác nhau**: Giao tác thường thực thi trên môi trường cơ sở dữ liệu tập trung, gồm có giao tác phẳng và giao tác lồng. Giao tác phân tán thực thi trên môi trường cơ sở dữ liệu phân tán.

## Các Câu Hỏi Liên Quan

- **Loginname nằm trong table nào?**: Nằm trong table `sys.sysuser` trong DB đó.
- **Tại sao biết user liên kết với login nào?**: Username và loginname liên kết với nhau qua trường `sid` (trên user và login đều có `sid`), nên từ loginname biết được username từ `sid`.
- **Hàm suy từ loginname đến username**: `SUSER.SID`(`ten login`) -> `sid` -> `username` -> `userid` -> `groupid` -> `rolename`.
- **Tên nhóm quyền nằm trong table nào?**: `sys.sysuser`.
- **`rowguid`**: Do hệ thống tự sinh ra, dùng để đồng bộ dữ liệu xuống phân mảnh, chỉ rõ table nào, cột nào để đưa dữ liệu xuống đúng vị trí đó.
- **Ưu khuyết điểm của nhân bản**: Truy xuất nhanh, đứng ở đâu cũng có thể select được. Nhưng update chậm vì có quá nhiều bản sao.
- **Ưu khuyết điểm của phân hoạch**: Select chậm nhưng insert và update nhanh do chỉ thao tác trên server gốc hoặc server phân mảnh cần truy xuất.
- **Trong suốt phân tán**: Có 4 mức trong suốt, người lập trình đứng ở mức 3 nhưng làm cho người dùng cảm thấy như đang ở mức 1.
- **Trong suốt phân mảnh**: Không cần chỉ rõ phân mảnh cũng như vị trí cấp phát cho phân mảnh.
- **Trong suốt vị trí**: Cung cấp tên phân mảnh nhưng không cần chỉ ra vị trí phân mảnh.
- **Trong suốt ánh xạ cục bộ**: Cung cấp tên phân mảnh và vị trí cấp phát.
- **Không trong suốt**.
- **Tại sao table đó nhân bản?**: Trong đề vật tư, vật tư nhân bản vì vật tư có thể có ở chi nhánh này cũng có thể có ở chi nhánh khác.
- **Trong đề trắc nghiệm**: Giáo viên nhân bản vì giáo viên có thể dạy ở cơ sở này cũng có thể dạy ở cơ sở khác, bộ đề đi theo giáo viên nên cũng nhân bản. Giáo viên cơ sở 1 có thể dạy ở cơ sở 2 nhưng không thể đăng ký thi cho lớp ở cơ sở 2.
