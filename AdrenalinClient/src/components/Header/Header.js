import React from 'react';
import styles from './header.module.css';
import logo from '../../assets/img/logo.png';
import CityLink from '../CityLink/CityLink.js';
import { HashLink } from 'react-router-hash-link';

const cities = ['Минске', 'Пинске', 'Гомеле', 'Лунинце', 'Орше'];

export default function Header() {
  return (
    <div className={styles.headerWrapper}>
      <div className={styles.headerTop}>
        <img src={logo} alt="logo" />
        <button className={styles.sheduleBtn}>Расписание клуба</button>
      </div>
      <div className={styles.headerMain}>
        <h1>Найди свой Адреналин!</h1>
        <button className={[styles.detailsBtn, styles.slideBottom].join()}>
          <HashLink to="/#clibsList">Подробнее</HashLink>
        </button>
      </div>
      <div className={styles.cityLinks}>
        {cities.map((city, i) => (
          <CityLink key={Date.now() + i} city={city}></CityLink>
        ))}
      </div>
    </div>
  );
}
