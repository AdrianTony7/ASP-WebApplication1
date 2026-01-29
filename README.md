# ASP.NET Razor Pages Tailwind & DaisyUI Template

This is a modern template project for **ASP.NET Core Razor Pages** that integrates **Tailwind CSS** and **DaisyUI**. It is designed to provide a flexible and highly customizable UI styling workflow without the overhead of complex build systems for initial development.

## 🚀 Features

- **ASP.NET Core Razor Pages**: A robust backend framework for building web applications.
- **Tailwind CSS 4**: A utility-first CSS framework for rapid UI development, loaded via the browser-based runtime for ease of use.
- **DaisyUI 5**: A popular component library for Tailwind CSS, providing beautiful, accessible components out of the box.
- **Responsive Layout**: Includes a pre-configured, mobile-friendly dashboard layout with a collapsible sidebar and glassmorphism effects.
- **Dark Mode Support**: Built-in theme switching capability using DaisyUI's theme controller.
- **Bootstrap Icons**: Integrated for a wide variety of high-quality web icons.

## 🛠️ Tech Stack

- **Framework**: [.NET 10+](https://dotnet.microsoft.com/)
- **UI Engine**: [Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/)
- **Styling**: [Tailwind CSS](https://tailwindcss.com/) & [DaisyUI](https://daisyui.com/)
- **Icons**: [Bootstrap Icons](https://icons.getbootstrap.com/)
- **Frontend Assets**: Loaded via CDN for immediate availability.

## 📂 Project Structure

- `Pages/`: Contains the Razor Pages and their associated logic.
- `Pages/Shared/_Layout.cshtml`: The main layout file where Tailwind and DaisyUI are initialized.
- `wwwroot/`: Static assets including custom CSS and JavaScript.

## 🚦 Getting Started

1.  **Clone the repository**:
    ```bash
    git clone <repository-url>
    ```
2.  **Restore dependencies**:
    ```bash
    dotnet restore
    ```
3.  **Run the application**:
    ```bash
    dotnet run
    ```
4.  Navigate to `https://localhost:5001` (or the port specified in your console) to view the application.

## 🎨 Customization

To customize the styling, you can:
- Use Tailwind utility classes directly in your `.cshtml` files.
- Use DaisyUI component classes (e.g., `btn`, `card`, `modal`).
- Modify the theme in `_Layout.cshtml` using the `data-theme` attribute on the `<html>` tag or via the theme controller.

---

*This template aims to accelerate the development of modern internal tools and dashboards using the power of .NET and utility-first CSS.*
