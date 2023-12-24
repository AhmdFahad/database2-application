INSERT INTO guest (name, ssn, phone_number, age, email)
VALUES
    ('John Doe', '123-45-6789', '123-456-7890', 35, 'john@example.com'),
    ('Jane Smith', '987-65-4321', '987-654-3210', 28, 'jane@example.com'),
    ('Sam Wilson', '567-89-0123', '567-890-1234', 42, 'sam@example.com');


INSERT INTO bill (id, guest_guest_id, total_amount, payment_method, payment_status)
VALUES
    (301, 1, '250.00', 'Credit Card', 'Paid'),
    (302, 2, '180.50', 'Cash', 'Pending'),
    (303, 3, '500.25', 'Debit Card', 'Paid');


INSERT INTO staff (id, name, phone, position, email)
VALUES
    (101, 'Emily Johnson', '111-222-3333', 'Manager', 'emily@example.com'),
    (102, 'Michael Brown', '444-555-6666', 'Receptionist', 'michael@example.com'),
    (103, 'Sarah Davis', '777-888-9999', 'Housekeeping', 'sarah@example.com');


INSERT INTO review (id, rating, comment, guest_guest_id)
VALUES
    (501, 4, 'Great service!', 1),
    (502, 5, 'Amazing experience!', 2),
    (503, 3, 'Room could be cleaner.', 3);

INSERT INTO room (id, availability, floor, type, price)
VALUES
    (201, 1, '1st Floor', 'Standard', 99.99),
    (202, 1, '2nd Floor', 'Deluxe', 149.99),
    (203, 1, '3rd Floor', 'Suite', 249.99);

INSERT INTO reservation (id, check_i_out_date, check_in_date, guest_guest_id, staff_id, room_id)
VALUES
    (401, '2023-01-15', '2023-01-10', 1, 101, 201),
    (402, '2023-02-20', '2023-02-15', 2, 102, 202),
    (403, '2023-03-25', '2023-03-20', 3, 103, 203);

INSERT INTO amenities (name, desciption, room_id)
VALUES
    ('WiFi', 'High-speed internet access', 201),
    ('Gym', 'Fitness facilities available', 202),
    ('Pool', 'Outdoor swimming pool', 203);

