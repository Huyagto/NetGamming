using QuảnLíTiệmNet;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;

[Serializable]
 class DataSource
{
    private static DataSource instance = null;
    private List<Computer> computers;
    private List<Customer> customers;
    private List<Service> services;
    private List<MenuMons> menuMons;
    private List<TaiKhoan> taiKhoan;
    private List<Pay> pays;
    [JsonConstructor]
    private DataSource()
    {
        this.computers = new List<Computer>();
        this.customers = new List<Customer>();
        this.services = new List<Service>();
        this.menuMons = new List<MenuMons>(); 
        this.taiKhoan = new List<TaiKhoan>();
        this.pays = new List<Pay>();
    }

    public static DataSource Init()
    {
        if (instance == null)
        {
            instance = new DataSource();
        }
        else if(instance.computers == null) instance.computers= new List<Computer>();
        else if(instance.customers ==null) instance.customers= new List<Customer>();    
        else if(instance.services == null) instance.services= new List<Service>();
        else if(instance.menuMons ==null) instance.menuMons= new List<MenuMons>();
        else if(instance.taiKhoan ==null) instance.taiKhoan= new List<TaiKhoan>();
        else if(instance.pays == null) instance.pays= new List<Pay>(); 
        return instance;
    }

    public List<Computer> GetComputers() => computers;

    public List<Customer> GetCustomers() => customers;
    public List <Service> GetServices() => services;
    public List<MenuMons> GetMenuMons() => menuMons;
    public List<TaiKhoan> GetTaiKhoans() => taiKhoan;
   
    public List<Pay> GetPays() => pays;
    public static void WriteComputersToFile(string filePath, List<Computer> computers)
    {
        if (computers == null || computers.Count == 0)
        {
            throw new ArgumentException("Danh Sách Máy Tính Rỗng!");
        }

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var computer in computers)
                {
                    writer.WriteLine($"{computer.idComputer.Trim()}|{computer.status.Trim()}|{computer.kind.Trim()}|{computer.room.Trim()}|{computer.price}");

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Đã xảy ra lỗi trong lúc ghi file: {ex.Message}");
        }
    }
    public static void WriteCustomersToFile(string filePath, List<Customer> customers)
    {
        if(customers == null || customers.Count == 0)
        {
            throw new ArgumentException("Danh Sách Khách Hàng Rỗng!");
        }
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var customer in customers)
                {
                    writer.WriteLine($"{customer.idCustomer.Trim()}|{customer.nameCustomer.Trim()}|{customer.dienThoai}|{customer.diaChi.Trim()}|{customer.email.Trim()}|{customer.ngaySinh:yyyy-MM-dd}|{customer.thoiGianDK:yyyy-MM-dd}|{customer.trangThai.Trim()}|{customer.gioiTinh.Trim()}|{customer.tien}|{customer.tenTK.Trim()}|{customer.mk.Trim()}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Đã xảy ra lỗi trong lúc ghi file: {ex.Message}");
        }
    }
    public static void WriteMenuMonsToFile(string filePath, List<MenuMons> menuMons)
    {
        if(menuMons == null  || menuMons.Count == 0)
        {
            throw new ArgumentException("Danh Sách Menu Rỗng!");
        }
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var menuMon in menuMons)
                {
                    writer.WriteLine($"{menuMon.idMon.Trim()}|{menuMon.tenMon.Trim()}|{menuMon.donViTinh.Trim()}|{menuMon.donGia}|{menuMon.loai.Trim()}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Đã xảy ra lỗi trong lúc ghi file: {ex.Message}");
        }
    }
    public static void WriteServicesToFile(string filePath, List<Service> services)
    {
        if(services == null || services.Count == 0) {
            throw new ArgumentException("Danh Sách Dịch Vụ Rỗng!");
        }
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var service in services)
                {
                    writer.WriteLine($"{service.IDCustomer.Trim()}|{service.IDMon}|{service.TienCustomer}|{service.SoLuong}|{service.TrangThai.Trim()}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Đã xảy ra lỗi trong lúc ghi file: {ex.Message}");
        }
    }
    public static void WritePaysToFile(string filePath, List<Pay> pays)
    {
        if(pays ==null || pays.Count == 0)
        {
            throw new ArgumentException("Danh Sách Thanh Toán Rỗng!");
        }
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var pay in pays)
                {
                    writer.WriteLine($"{pay.SoHoaDon.Trim()}|{pay.NgayLap:yyyy-MM-dd}|{pay.IDCustomer.Trim()}|{pay.TienGio}|{pay.TienNap}|{pay.HinhThuc.Trim()}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Đã xảy ra lỗi trong lúc ghi file: {ex.Message}");
        }
    }
    public static List<Computer> ReadComputersFromFile(string filePath)
    {
        List<Computer> computers = new List<Computer>();
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose(); 
        }
        using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                if (data.Length == 5) 
                {
                    computers.Add(new Computer(
                        data[0].Trim(),
                        data[1].Trim(),
                        data[2].Trim(),
                        data[3].Trim(),
                        double.Parse(data[4].Trim())
                    ));
                }
            }
          
        }
        return computers;
    }
    public static List<Customer> ReadCustomersFromFile(string filePath)
    {
        List<Customer> customers = new List<Customer>();
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose(); 
        }
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                if (data.Length == 12)
                {
                    customers.Add(new Customer(
                        data[0].Trim(),
                        data[1].Trim(),
                        decimal.Parse(data[2].Trim()),
                        data[3].Trim(),
                        data[4].Trim(),
                        DateTime.Parse(data[5]),
                        DateTime.Parse(data[6]),
                        data[7].Trim(),
                        data[8].Trim(),
                        double.Parse(data[9].Trim()),
                        data[10].Trim(),
                        data[11].Trim()
                    ));
                }
            }
        }
        return customers;
    }
    public static List<MenuMons> ReadMenuMonsFromFile(string filePath)
    {
        List<MenuMons> menuMons = new List<MenuMons>();
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                if (data.Length == 5){ 
                    menuMons.Add(new MenuMons(data[0].Trim(), data[1].Trim(), data[2].Trim(), double.Parse(data[3].Trim()), data[4].Trim()));
            }
            }
        }
        return menuMons;
    }
    public static List<Service> ReadServicesFromFile(string filePath, List<MenuMons> allMenuMons)
    {
        List<Service> services = new List<Service>();
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }
        using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                if (data.Length == 5)
                {
                    string idCustomer = data[0].Trim();
                    MenuMons menu = allMenuMons.Find(m => m.idMon == data[1].Trim());
                    double tienCustomer = double.Parse(data[2].Trim());
                    int soLuong = int.Parse(data[3].Trim());
                    string trangThai = data[4].Trim();

                    services.Add(new Service(idCustomer, menu, tienCustomer, soLuong, trangThai));
                }
            }
        }
        return services;
    }

    public static List<Pay> ReadPaysFromFile(string filePath)
    {
        List<Pay> pays = new List<Pay>();
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                if (data.Length == 6)
                {
                    pays.Add(new Pay(data[0].Trim(), DateTime.Parse(data[1].Trim()), data[2].Trim(), double.Parse(data[3].Trim()), double.Parse(data[4].Trim()), data[5].Trim()));
                }
            }
        }
        return pays;
    }
    public static List<TaiKhoan> ReadAdminFromFile(string filePath)
    {
        List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }
        using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                if (data.Length == 2)
                {
                    taiKhoans.Add(new TaiKhoan(data[0].Trim(), data[1].Trim()));
                }
            }
        }
        return taiKhoans;
    }
}








