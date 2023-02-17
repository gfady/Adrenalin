import React from 'react';
import styles from './infoblock.module.css';
import coaches from '../../assets/img/coaches.png';
import Centrum3 from '../../assets/img/Centrum3.png.webp.png';
import fitness from '../../assets/img/partner_ft.png.webp.png';
import sber from '../../assets/img/Sber.png.webp.png';
import fruds from '../../assets/img/fruds250.png.webp.png';
import expert from '../../assets/img/partner1.png.webp.png';
import synevo from '../../assets/img/partner15-2.png.webp.png';
import franshiza from '../../assets/img/adrenalin_franchaising_banner.png';

const partnerImages = [Centrum3, fitness, sber, fruds, expert, synevo];

export default function InfoBlock() {
  return (
    <div className={styles.infoBlockWrapper}>
      <div className={styles.mainInfo}>
        <img src={coaches} alt="coaches" />
        <div className={styles.textWrapper}>
          <p>Сеть фитнес-клубов «Адреналин» работает с 2012 года.</p>
          <br />
          <p>
            Тренеры прошли обучение, имеют специальную подготовку и обладают
            богатым опытом по ведению занятий. Мастерство наших инструкторов
            подтверждается многочисленными наградами.
          </p>
          <br />
          <p>
            Сегодня заниматься в фитнес центрах Минска недёшево. Но цены на наши
            услуги вас приятно удивят.
          </p>
          <br />
          <p>
            «Адреналин» — это настоящая семья, где царит дружная атмосфера. Все
            клиенты это наши друзья, которым мы всегда готовы помочь!
          </p>
          <br />
          <p>
            Мы уверены, что уже после первого занятия «Адреналин» станет для вас
            родным.
          </p>
          <img src={franshiza} alt="franshiza" />
        </div>
      </div>
      <hr />
      <div className={styles.partnersWrapper}>
        {partnerImages.map((img, i) => (
          <img key={Date.now() + Math.random(1, 100)} src={img} alt="alt" />
        ))}
      </div>
    </div>
  );
}
