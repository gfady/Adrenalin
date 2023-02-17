import React from 'react';
import styles from './footer.module.css';
import { HashLink } from 'react-router-hash-link';
import play from '../../assets/img/play.png';
import app from '../../assets/img/app.png';
import appGallery from '../../assets/img/appGallery.png';

import applePay from '../../assets/img/applePay.png';
import bePaid from '../../assets/img/bePaid.png';
import pci from '../../assets/img/pci.png';

export default function Footer() {
  return (
    <div className={styles.footerWrapper}>
      <div className={styles.mainInfo}>
        <p>
          ООО "Спортех-Бел" Зарегистрировано Минским городским исполнительным
          комитетом за №193089979 , 07.06.2018г. Юридический адрес: 220118, г.
          Минск, ул. Кабушкина, д. 86А, пом. 160
        </p>
      </div>
      <div className={styles.links}>
        <ul>
          <li>
            <HashLink to="">Корпоративным клиентам</HashLink>
          </li>
          <li>
            <HashLink to="">О клубе</HashLink>
          </li>
          <li>
            <HashLink to="">Новости</HashLink>
          </li>
        </ul>
      </div>
      <div className={styles.links}>
        <ul>
          <li>
            <HashLink to="">Вакансии</HashLink>
          </li>
          <li>
            <HashLink to="">Правила</HashLink>
          </li>
          <li>
            <HashLink to="">Контакты</HashLink>
          </li>
          <li>
            <HashLink to="">Франшиза</HashLink>
          </li>
        </ul>
      </div>
      <div className={styles.apps}>
        <h3>Мобильное приложение Адреналин</h3>
        <div className={styles.imagesFooter}>
          <a href="#">
            <img src={play} alt=""></img>
          </a>
          <a href="#">
            <img src={app} alt=""></img>
          </a>
          <a href="#">
            <img src={appGallery} alt=""></img>
          </a>
        </div>
        <div className={styles.payment}>
          <label>Мы принимаем оплату: </label>
          <img src={applePay} alt=""></img>
          <img src={bePaid} alt=""></img>
          <img src={pci} alt=""></img>
        </div>
      </div>
    </div>
  );
}
