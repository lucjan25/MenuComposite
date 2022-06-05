using System;
using System.Collections.Generic;

namespace MenuBiblioteka
{
    public abstract class MenuComponent
    {
        protected string url;
        protected string name;
        public MenuComponent(string name, string url)
        {
            this.name = name;
            this.url = url;
        }
        public string GetName()
        {
            return name;
        }
        public string GetUrl()
        {
            return url;
        }
        public abstract void Add(MenuComponent component);
        public abstract void DisplayMenu();
    }
    public class Menu : MenuComponent
    {
        List<MenuComponent> subMenus = new List<MenuComponent>();
        public Menu(string name, string url)
            : base(name, url)
        {
        }
        public override void Add(MenuComponent component)
        {
            subMenus.Add(component);
        }
        public override void DisplayMenu()
        {
            Console.WriteLine(GetName() + " " + GetUrl());
            foreach (MenuComponent component in subMenus)
            {
                component.DisplayMenu();
            }
        }
    }
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string url)
            : base(name, url)
        {
        }
        public override void Add(MenuComponent component)
        {
            return;
        }
        public override void DisplayMenu()
        {
            Console.WriteLine(GetName() + " " + GetUrl());
        }
    }
}
