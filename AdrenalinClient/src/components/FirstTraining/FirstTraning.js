import React from 'react';
import styles from './first.module.css';
import { HashLink } from 'react-router-hash-link';

export default function FirstTraning() {
  return (
    <div className={styles.firstWrapper}>
      <h1>Первая тренировка бесплатно!</h1>
      <button>
        <HashLink to="/#contactForm">Записаться!</HashLink>
      </button>
    </div>
  );
}
