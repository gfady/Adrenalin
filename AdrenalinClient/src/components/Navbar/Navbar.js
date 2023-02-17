import { useState } from 'react';
import logo from '../../assets/img/logo.png';
import styles from './navbar.module.css';
import { HashLink as Link } from 'react-router-hash-link';

export default function Navbar() {
  return (
    <nav className={styles.navbar}>
      <div className={styles.navLinks}>
        <div className={styles.navItem}>
          <Link to="/about">Главная</Link>
        </div>
        <div className={styles.navItem}>
          <Link to="/news">Новости</Link>
        </div>
        <div className={styles.navItem}>
          <Link to="/lessons">Видео-уроки</Link>
        </div>
        <div className={styles.navItem}>
          <Link to="/rules">Правила</Link>
        </div>
        <div className={styles.navItem}>
          <Link to="/vacancies">Вакансии</Link>
        </div>
      </div>
    </nav>
  );
}
