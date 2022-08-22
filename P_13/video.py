import cv2

cap = cv2.VideoCapture(0) # если подключаем камеру, то в скобках VideoCapture(0) ставим 0, если у нас одна камера
                          # 1 - если у нас 2 камеры и т.д. 
                          # Если мы хотим работать с видео, то в скобках в ковычках пишем название файла 
                          # (файл надо положить в эту же папку, что и наш файл)

while True:
    success, frame = cap.read()
    cv2.imshow("camera", frame)
    
    if cv2.waitKey(1) & 0xff == ord("q"):
       break

