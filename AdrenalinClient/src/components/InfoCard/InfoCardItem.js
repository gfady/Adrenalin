import React, { useEffect } from 'react';
import styles from './infocarditem.module.css';

export default function InfoCardItem({ cardItem }) {
  return (
    <div className={styles.cardItem}>
      <img src={require('../../assets/img/' + cardItem.img)} alt="" />
      <h3>{cardItem.title}</h3>
      <p>{cardItem.text}</p>
    </div>
  );
}
